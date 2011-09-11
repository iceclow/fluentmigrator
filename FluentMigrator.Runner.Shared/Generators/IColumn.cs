using FluentMigrator.Expressions;
using FluentMigrator.Model;
using System.Collections.Generic;

namespace FluentMigrator.Runner.Shared.Generators
{
    public interface IColumn
    {
        string Generate(ColumnDefinition column);
        string Generate(IEnumerable<ColumnDefinition> columns, string tableName);
    }
}
