using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class RoverTests
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
                else if (Face == 'S')
                    Face = 'E';
                else if (Face == 'E')
                    Face = 'N';
            }
            else if (direction == 'R')
            {
                if (Face == 'N')
                    Face = 'E';
                else if (Face == 'E')
                    Face = 'S';
                else if (Face == 'S')
                    Face = 'W';
                else if (Face == 'W')
                    Face = 'N';
            }
        }
    }
}
