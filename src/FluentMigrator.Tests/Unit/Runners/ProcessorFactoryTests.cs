#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using FluentMigrator.Runner.Processors;
using FluentMigrator.Runner.Processors.Sqlite;
using FluentMigrator.DatabasePlugins.SqlServer.Processors;
using NUnit.Framework;
using FluentMigrator.Runner.Shared.Processors;

namespace FluentMigrator.Tests.Unit.Runners
{
    [TestFixture]
    public class ProcessFactoryTests
    {
        [Test]
        public void CanRetrieveFactoryWithArgumentString()
        {
            IMigrationProcessorFactory factory = ProcessorFactory.GetFactory("Sqlite");
            Assert.IsTrue(factory.GetType() == typeof(SqliteProcessorFactory));
        }

        [Test]
        public void CanRetrieveSqlServer2000FactoryWithArgumentString()
        {
            IMigrationProcessorFactory factory = ProcessorFactory.GetFactory("SqlServer2000");
            Assert.IsTrue(factory.GetType() == typeof(SqlServer2000ProcessorFactory));
        }

        [Test]
        public void CanRetrieveSqlServer2005FactoryWithArgumentString()
        {
            IMigrationProcessorFactory factory = ProcessorFactory.GetFactory("SqlServer2005");
            Assert.IsTrue(factory.GetType() == typeof(SqlServer2005ProcessorFactory));
        }

        [Test]
        public void CanRetrieveSqlServer2008FactoryWithArgumentString()
        {
            IMigrationProcessorFactory factory = ProcessorFactory.GetFactory("SqlServer2008");
            Assert.IsTrue(factory.GetType() == typeof(SqlServer2008ProcessorFactory));
        }
    }
}