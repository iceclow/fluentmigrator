namespace FluentMigrator.Runner.Processors.Postgres
{
    using System.Data.Common;
    using Generators.Postgres;
    using FluentMigrator.Runner.Shared.Processors;
    using FluentMigrator.Runner.Shared;

    public class PostgresProcessorFactory : MigrationProcessorFactory
    {
        public override IMigrationProcessor Create(string connectionString, IAnnouncer announcer, IMigrationProcessorOptions options)
        {
            var factory = new PostgresDbFactory();
            DbConnection connection = factory.CreateConnection(connectionString);
            return new PostgresProcessor(connection, new PostgresGenerator(), announcer, options, factory);
        }
    }
}