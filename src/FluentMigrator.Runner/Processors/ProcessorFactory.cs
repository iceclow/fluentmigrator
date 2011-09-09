using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentMigrator.Runner.Shared.Processors;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace FluentMigrator.Runner.Processors
{
    public static class ProcessorFactory
    {
        private static CompositionBatch batch;
        private static CompositionContainer container;

        static ProcessorFactory()
        {
            DirectoryCatalog catalog = new DirectoryCatalog("directory");

            container = new CompositionContainer(catalog);

            batch = new CompositionBatch();

            container.Compose(batch);
        }

        public static IMigrationProcessorFactory GetFactory(string processorName)
        {
            foreach (var factory in Factories)
            {
                var type = factory.GetType();
                var name = type.Name;

                if (name.StartsWith(processorName, StringComparison.OrdinalIgnoreCase))
                {
                    return factory;
                }
            }

            return null;
        }

        public static string ListAvailableProcessorTypes()
        {
            //TODO Do not instantiante every imported type

            var types = container.GetExports<IMigrationProcessorFactory>();

            return types.Select(x => x.Value.GetType().Name)
                        .Select(x => x.Substring(0, x.IndexOf("ProcessorFactory")).ToLowerInvariant())
                        .Aggregate((x, y) => x + "," + y);

        }

        private static object factoriesLock = new object();

        [ImportMany(typeof(IMigrationProcessorFactory), AllowRecomposition = true)]
        public static IEnumerable<IMigrationProcessorFactory> Factories;
    }
}