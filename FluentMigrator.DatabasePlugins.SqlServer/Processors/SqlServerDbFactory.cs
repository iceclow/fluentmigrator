namespace FluentMigrator.DatabasePlugins.SqlServer.Processors
{
    using System.Data.Common;
    using System.Data.SqlClient;
    using FluentMigrator.Runner.Shared.Processors;

    public class SqlServerDbFactory : DbFactoryBase
    {
        public SqlServerDbFactory()
            : base(SqlClientFactory.Instance)
        {
        }

        protected override DbProviderFactory CreateFactory()
        {
            return SqlClientFactory.Instance;
        }
    }
}