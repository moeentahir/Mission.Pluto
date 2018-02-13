using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Movement_Tests
    {
        [TestMethod]
        public void Move_Up_When_Facing_North()
        {
            var expected = 1;
            var rover = new Rover(0, 0, 'N');
            rover.Move('F');
            var actual = rover.Y;

            Assert.AreEqual(expected, actual);
        }
    }
}
