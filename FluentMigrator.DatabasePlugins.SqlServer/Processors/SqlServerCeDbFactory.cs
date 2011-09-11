using FluentMigrator.Runner.Shared.Processors;
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