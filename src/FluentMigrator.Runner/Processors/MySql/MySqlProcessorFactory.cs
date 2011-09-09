namespace FluentMigrator.Runner.Processors.MySql
{
    using System.Data.Common;
    using Generators.MySql;
    using FluentMigrator.Runner.Shared.Processors;
    using FluentMigrator.Runner.Shared;

    public class MySqlProcessorFactory : MigrationProcessorFactory
    {
        public override IMigrationProcessor Create(string connectionString, IAnnouncer announcer, IMigrationProcessorOptions options)
        {
            var factory = new MySqlDbFactory();
            DbConnection connection = factory.CreateConnection(connectionString);
            return new MySqlProcessor(connection, new MySqlGenerator(), announcer, options, factory);
        }
    }
}