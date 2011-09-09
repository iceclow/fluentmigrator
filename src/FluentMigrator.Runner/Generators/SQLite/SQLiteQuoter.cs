using FluentMigrator.Runner.Generators.Shared.Generic;

namespace FluentMigrator.Runner.Generators.SQLite
{
	public class SqliteQuoter : GenericQuoter
	{
		public override string OpenQuote { get { return "'"; } }
		public override string CloseQuote { get { return "'"; } }
	}
}
