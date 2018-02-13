using System;

namespace Mission.Pluto.UnitTests
{
    public class Rover
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
                RotateLeft();
            }
            else if (direction == 'R')
            {
                RotateRight();
            }
        }

        internal void Move(char v)
        {
            throw new NotImplementedException();
        }

        private void RotateLeft()
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

        private void RotateRight()
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
