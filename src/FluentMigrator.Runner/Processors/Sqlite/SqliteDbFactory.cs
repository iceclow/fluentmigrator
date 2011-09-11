using FluentMigrator.Runner.Shared.Processors;
namespace FluentMigrator.Runner.Processors.Sqlite
{
    public class SqliteDbFactory : ReflectionBasedDbFactory
    {
        public SqliteDbFactory()
            : base("System.Data.SQLite", "System.Data.SQLite.SQLiteFactory")
        {
        }
    }
}