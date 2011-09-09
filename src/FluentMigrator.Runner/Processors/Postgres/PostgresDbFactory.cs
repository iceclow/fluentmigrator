using FluentMigrator.Runner.Processors.Shared;
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