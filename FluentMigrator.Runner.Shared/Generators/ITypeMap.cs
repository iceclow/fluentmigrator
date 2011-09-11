using System.Data;

namespace FluentMigrator.Runner.Shared.Generators
{
    public interface ITypeMap
    {
        string GetTypeMap(DbType type, int size, int precision);
    }
}
