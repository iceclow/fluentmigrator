using FluentMigrator.Runner.Processors.Shared;
namespace FluentMigrator.Runner.Processors.Oracle
{
    public class OracleDbFactory : ReflectionBasedDbFactory
    {
        public OracleDbFactory()
            : base("Oracle.DataAccess", "Oracle.DataAccess.Client.OracleClientFactory")
        {
        }
    }
}