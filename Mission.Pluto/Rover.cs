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

        internal void Move(char direction)
        {
            if (direction == 'F')
            {
                MoveForward();
            }
            else if (direction == 'B')
            {
                MoveBackwards();
            }
        }

        private void MoveForward()
        {
            if (Face == 'N')
                Y += 1;
            else if (Face == 'E')
                X += 1;
            else if (Face == 'S')
                Y -= 1;
            else if (Face == 'W')
                X -= 1;
        }

        private void MoveBackwards()
        {
            if (Face == 'N')
                Y -= 1;
            if (Face == 'E')
                X -= 1;
            else if (Face == 'S')
                Y += 1;
            else if (Face == 'W')
                X += 1;
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
