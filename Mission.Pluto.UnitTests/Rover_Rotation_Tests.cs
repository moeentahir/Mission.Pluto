using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Rotation_Tests
    {
        [TestMethod]
        [DataRow(Direction.North, Direction.West)]
        [DataRow(Direction.West, Direction.South)]
        [DataRow(Direction.South, Direction.East)]
        [DataRow(Direction.East, Direction.North)]
        public void Rotating_Left_Should_Change_Direction_Anti_Clock_Wise(Direction startingFace, Direction expected)
        {
            var rover = new Rover(0, 0, startingFace);
            rover.HandleCommand(Command.Left);
            var actual = rover.Face;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(Direction.North, Direction.East)]
        [DataRow(Direction.East, Direction.South)]
        [DataRow(Direction.South, Direction.West)]
        [DataRow(Direction.West, Direction.North)]
        public void Rotating_Right_Should_Change_Direction_Clock_Wise(Direction startingFace, Direction expected)
        {
            var rover = new Rover(0, 0, startingFace);
            rover.HandleCommand(Command.Right);
            var actual = rover.Face;

            Assert.AreEqual(expected, actual);
        }
    }
}
