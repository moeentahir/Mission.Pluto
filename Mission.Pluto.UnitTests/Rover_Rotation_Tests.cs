using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Rotation_Tests
    {
        [TestMethod]
        [DataRow('N','W')]
        [DataRow('W', 'S')]
        [DataRow('S', 'E')]
        [DataRow('E', 'N')]
        public void Rotating_Left_Should_Change_Direction_Anti_Clock_Wise(char startingFace, char expected)
        {
            var rover = new Rover(0, 0, startingFace);
            rover.Rotate('L');
            var actual = rover.Face;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow('N', 'E')]
        [DataRow('E', 'S')]
        [DataRow('S', 'W')]
        [DataRow('W', 'N')]
        public void Rotating_Right_Should_Change_Direction_Clock_Wise(char startingFace, char expected)
        {
            var rover = new Rover(0, 0, startingFace);
            rover.Rotate('R');
            var actual = rover.Face;

            Assert.AreEqual(expected, actual);
        }
    }
}
