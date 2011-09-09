using FluentMigrator.Runner.Shared;

namespace FluentMigrator.Runner.Generators.Jet
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using FluentMigrator.Expressions;
    using FluentMigrator.Model;
    using FluentMigrator.Runner.Generators.Shared.Base;
    using FluentMigrator.Runner.Generators.Shared.Generic;

    public class JetGenerator : GenericGenerator
    {
        public JetGenerator()
            : base(new JetColumn(), new JetQuoter())
        {
        }

        public override string DropIndex { get { return "DROP INDEX {0} ON {1}"; } }

        public override string Generate(RenameTableExpression expression)
        {
            return compatabilityMode.HandleCompatabilty("Renaming of tables is not supporteed for MySql");
        }

        public override string Generate(RenameColumnExpression expression)
        {
            return compatabilityMode.HandleCompatabilty("Renaming of columns is not supporteed for MySql");
        }

        public override string Generate(AlterDefaultConstraintExpression expression)
        {
            return compatabilityMode.HandleCompatabilty("Altering of default constrints is not supporteed for MySql");
        }
    }
}
