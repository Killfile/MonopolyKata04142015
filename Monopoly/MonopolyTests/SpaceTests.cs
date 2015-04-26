using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly;
using NUnit.Framework;
namespace Monopoly.Tests
{
    [TestFixture()]
    public class SpaceTests
    {
        [Test()]
        public void WhenSpaceIsContructed_NoExceptionsThrown()
        {
            Space space = new Space();
        }
    }
}
