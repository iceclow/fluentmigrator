using System.Data;

namespace FluentMigrator.Runner.Generators.Shared
{
    public interface ITypeMap
    {
        string GetTypeMap(DbType type, int size, int precision);
    }
}
