using FluentMigrator.Runner.Processors.Shared;
namespace FluentMigrator.DatabasePlugins.SqlServer.Processors
{
    public class SqlServerCeDbFactory : ReflectionBasedDbFactory
    {
        public SqlServerCeDbFactory()
            : base("System.Data.SqlServerCe", "System.Data.SqlServerCe.SqlCeProviderFactory")
        {
        }
    }
}