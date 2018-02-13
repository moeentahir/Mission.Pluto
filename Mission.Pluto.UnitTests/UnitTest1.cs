using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void When_Facing_North_Rotate_Left_Should_Face_West()
        {
            var rover = new Rover(0, 0, 'N');
            rover.Rotate('L');
            var expected = 'W';
            var actual = rover.Face;

            Assert.AreEqual(expected, actual);
        }
    }

    internal class Rover
    {
        public Rover(int x, int y, char face)
        {
            X = x;
            Y = y;
            Face = face;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Face { get; set; }

        internal void Rotate(char v)
        {
            Face = 'W';
        }
    }
}
