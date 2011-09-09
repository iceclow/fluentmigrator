namespace FluentMigrator.DatabasePlugins.SqlServer.Processors
{
    using System.Data.Common;
    using System.Data.SqlClient;
    using FluentMigrator.Runner.Processors.Shared;

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