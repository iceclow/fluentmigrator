using FluentMigrator.Runner.Processors.Shared;
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