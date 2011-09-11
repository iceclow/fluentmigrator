namespace FluentMigrator.DatabasePlugins.SqlServer.Processors
{
    using System.Data.Common;
    using Generators;
    using FluentMigrator.Runner.Shared.Processors;
    using FluentMigrator.Runner.Shared;
    using System.ComponentModel.Composition;

    [Export(typeof(IMigrationProcessorFactory))]
    public class SqlServerProcessorFactory : MigrationProcessorFactory
    {
        public override IMigrationProcessor Create(string connectionString, IAnnouncer announcer, IMigrationProcessorOptions options)
        {
            var factory = new SqlServerDbFactory();
            DbConnection connection = factory.CreateConnection(connectionString);
            return new SqlServerProcessor(connection, new SqlServer2008Generator(), announcer, options, factory);
        }

        public override bool IsForProvider(string provider)
        {
            return provider.ToLower().Contains("sqlclient");
        }
    }
}