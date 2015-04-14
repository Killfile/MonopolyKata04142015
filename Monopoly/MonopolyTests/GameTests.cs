﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly;
using NUnit.Framework;
namespace Monopoly.Tests
{
    [TestFixture()]
    public class GameTests
    {
       

        [Test()]
        [ExpectedException(typeof(WrongNumberOfPlayersException))]
        public void WhenGameIsConstructedWithTooFewPlayers_ThrowException()
        {
            Game game = new Game(new List<string>(){"Horse"});
        }

        [Test()]
        [ExpectedException(typeof(WrongNumberOfPlayersException))]
        public void WhenGameIsConstructedWithTooManyPlayers_ThrowException()
        {
            Game game = new Game(new List<string>() { "Horse", "Car", "Battleship", "Thimble", "Horseman", "Iron", "Shoe", "Dog", "Top Hat" });
        }

        [Test]
        public void WhenGameIsConstructedTwoPlayers_DoNotThrowException()
        {
            Game game = new Game(new List<string>() { "Horse", "Car" });
        }

        [Test()]
        public void WhenGameIsConstructedWithEightPlayers_DoNotThrowException()
        {
            Game game = new Game(new List<string>() { "Horse", "Car", "Thimble", "Horseman", "Iron", "Shoe", "Dog", "Top Hat" });
        }




        
        
    }
}