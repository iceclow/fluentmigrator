namespace FluentMigrator.Runner.Generators.Shared
{
    public interface IQuoter
    {
        string Quote(string value);
        string UnQuote(string value);
        string QuoteValue(object value);
        bool IsQuoted(string value);
        string QuoteColumnName(string columnName);
        string QuoteTableName(string tableName);
        string QuoteIndexName(string indexName);
        string QuoteSchemaName(string schemaName);
        string QuoteCommand(string command);
    }
}
