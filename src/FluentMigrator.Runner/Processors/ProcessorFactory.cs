using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentMigrator.Runner.Shared.Processors;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

namespace FluentMigrator.Runner.Processors
{
    public static class ProcessorFactory
    {
        private static CompositionContainer container;

        static ProcessorFactory()
        {
            var catalog = new DirectoryCatalog("DatabasePlugins");

            container = new CompositionContainer(catalog);
            //container.ComposeParts(this);
        }

        public static IMigrationProcessorFactory GetFactory(string processorName)
        {
            foreach (var factory in Factories)
            {
                if (factory.Name.StartsWith(processorName, StringComparison.OrdinalIgnoreCase))
                {
                    return factory;
                }
            }

            return null;
        }

        public static string ListAvailableProcessorTypes()
        {
            var types = container.GetExports<IMigrationProcessorFactory>();

            return types.Select(x => x.Value.Name)
                        .Aggregate((x, y) => x + "," + y);

        }

        private static object factoriesLock = new object();

        [ImportMany(typeof(IMigrationProcessorFactory), AllowRecomposition = true)]
        public static IEnumerable<IMigrationProcessorFactory> Factories;
    }
}