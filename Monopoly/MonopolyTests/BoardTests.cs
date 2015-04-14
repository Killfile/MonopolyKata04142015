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
    public class BoardTests
    {
        Board board;
        List<Space> spaces;

        [SetUp]
        public void SetupBoard()
        {
            spaces = new List<Space> {
                new Space(),
                new Space(),
                new Space()
            };

            board = new Board(spaces);

        }

        [Test()]
        public void BoardCanBeConstructed()
        {
            Assert.Pass();
        }

        [Test()]
        public void AdvanceCanBeCalled()
        {
            var expected = spaces[2];
            var actual = board.Advance(spaces[0], 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void AdvanceLoops()
        {
            var expected = spaces[0];
            var actual = board.Advance(spaces[0], spaces.Count);
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}
