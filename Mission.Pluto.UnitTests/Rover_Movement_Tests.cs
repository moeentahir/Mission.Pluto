using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Movement_Tests
    {
        [TestMethod]
        [DataRow('N', 0, 1)]
        [DataRow('E', 1, 0)]
        [DataRow('S', 0, -1)]
        [DataRow('W', -1, 0)]
        public void Move_Forward_When_Facing_In_Different_Directions(char startingFace, int expectedX, int expectedY)
        {
            var rover = new Rover(0, 0, startingFace);
            rover.Move('F');

            Assert.AreEqual(expectedX, rover.X);
            Assert.AreEqual(expectedY, rover.Y);
            Assert.AreEqual(startingFace, rover.Face);
        }

        [TestMethod]
        [DataRow('N', 0, -1)]
        [DataRow('E', -1, 0)]
        public void Move_Backwards_When_Facing_In_Different_Directions(char startingFace, int expectedX, int expectedY)
        {
            var rover = new Rover(0, 0, startingFace);
            rover.Move('B');

            Assert.AreEqual(expectedX, rover.X);
            Assert.AreEqual(expectedY, rover.Y);
            Assert.AreEqual(startingFace, rover.Face);
        }
    }
}
