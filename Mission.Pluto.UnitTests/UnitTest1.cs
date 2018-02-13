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

        [TestMethod]
        public void When_Facing_West_Rotate_Left_Should_Face_South()
        {
            var rover = new Rover(0, 0, 'W');
            rover.Rotate('L');
            var expected = 'S';
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

        internal void Rotate(char direction)
        {
            if (direction == 'L')
            {
                if (Face == 'N')
                    Face = 'W';
                else if (Face == 'W')
                    Face = 'S';
            }
        }
    }
}
