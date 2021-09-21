﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warm_up_loops.Enum;
using Warm_up_loops.Game;

namespace Warm_up_loops_tests
{
    [TestClass]
    public class GuessNumber_tests
    {
        [TestMethod]
        public void Guess_HigherThanAnswer_ReturnsResponseHigher()
        {
            //Arrange
            var ui = new UserInterface_mock();
            var answer = 8;
            var guess = 9;
            var expected = GuessResponse.Higher;
            ui.AddToNumberQueue(guess);
            var sut = new GameGuessNumber(answer, ui);

            //Act
            var result = sut.Guess();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Guess_LowerThanAnswer_ReturnsResponseLower()//added by w
        {
            //Arrange
            var ui = new UserInterface_mock();
            var answer = 6;
            var guess = 2;
            var expected = GuessResponse.Lower;
            ui.AddToNumberQueue(guess);
            var sut = new GameGuessNumber(answer, ui);

            //Act
            var result = sut.Guess();

            //Assert
            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void Guess_EqualToAnswer_ReturnsResponseHigher()//added by w
        {
            //Arrange 
            var ui = new UserInterface_mock();
            var answer = 6;
            var guess = 6;
            var expected = GuessResponse.Correct;
            ui.AddToNumberQueue(guess);
            var sut = new GameGuessNumber(answer, ui);

            //Act
            var result = sut.Guess();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
