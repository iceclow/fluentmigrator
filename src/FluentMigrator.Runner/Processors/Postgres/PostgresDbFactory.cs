using FluentMigrator.Runner.Shared.Processors;
namespace FluentMigrator.Runner.Processors.Postgres
{
    public class PostgresDbFactory : ReflectionBasedDbFactory
    {
        public PostgresDbFactory()
            : base("Npgsql", "Npgsql.NpgsqlFactory")
        {
        }
    }
}