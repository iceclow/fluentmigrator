﻿using FluentMigrator.Runner.Shared.Generators.Generic;
using FluentMigrator.Runner.Shared;

namespace FluentMigrator.DatabasePlugins.SqlServer.Generators
{
    public class SqlServerQuoter : GenericQuoter
    {
        public override string OpenQuote { get { return "["; } }

        public override string CloseQuote { get { return "]"; } }

        public override string CloseQuoteEscapeString { get { return "]]"; } }

        public override string OpenQuoteEscapeString { get { return string.Empty; } }

        public override string QuoteSchemaName(string schemaName)
        {
            return (string.IsNullOrEmpty(schemaName)) ? "[dbo]" : Quote(schemaName);
        }
    }
}