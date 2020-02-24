using MarsRover.Abstract;
using MarsRover.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRover.Tests
{
    [TestClass]
   public class RoverTest
    {
        [TestMethod]
        public void FirstRoverCheckOutput()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.ApplyCommands("LMLMLMLMM");
            Assert.AreEqual(firstRover.ToString(), "1 3 N");
        }

        [TestMethod]
        public void SecondRoverCheckOutput()
        {
            Plateau plateauTwo = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Directions.E);
            secondRover.ApplyCommands("MMRMMRMRRM");
            Assert.AreEqual(secondRover.ToString(), "5 1 E");
        }

        
        [TestMethod]
        public void ThirdRoverCheckOutput()
        {
            Plateau plateauThree = new Plateau(new Position(6, 6));
            Rover thirdRover = new Rover(plateauThree, new Position(4, 3), Directions.S);
            thirdRover.ApplyCommands("LMMLMMLMRM");
            Assert.AreEqual(thirdRover.ToString(), "5 6 N");
        }

        [TestMethod]
        public void FourthRoverCheckOutput()
        {
            Plateau plateauFour = new Plateau(new Position(7, 7));
            Rover fourthRover = new Rover(plateauFour, new Position(4, 5), Directions.W);
            fourthRover.ApplyCommands("MMRMLMM");
            Assert.AreEqual(fourthRover.ToString(), "0 6 W");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectInput()
        {
            Plateau plateauOne = new Plateau(new Position(6, 6));
            Rover firstRover = new Rover(plateauOne, new Position(2, 2), Directions.S);
            firstRover.ApplyCommands("MLAAA");
        }
    }
}
