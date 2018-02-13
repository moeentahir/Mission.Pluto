using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Multiple_Commands_Tests
    {
        [TestMethod]
        public void Handle_Forward_Forward_Right_Forward_Forward_Command(char startingFace, int expectedX, int expectedY)
        {
            var command = "FFRFF";
            var rover = new Rover(0, 0, startingFace);

            rover.HandleCommand(command);

            Assert.AreEqual(expectedX, rover.X);
            Assert.AreEqual(expectedY, rover.Y);
            Assert.AreEqual(startingFace, rover.Face);
        }
    }
}
