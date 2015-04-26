using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTests
{
    public class FixtureTestBase
    {
        protected IFixture fixture;

        [SetUp]
        public void SetupFixture()
        {
            fixture = new Fixture().Customize(new AutoMoqCustomization());
        }
    }
}
