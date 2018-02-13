using System;

namespace Mission.Pluto
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


        internal void HandleCommand(Command command)
        {
            if (command == Command.Left || command == Command.Right)
                Rotate(command);
            else if (command == Command.Forward || command == Command.Backward)
                Move(command);
            else
                throw new InvalidOperationException($"Cannont handle command '{command}'");
        }

        internal void HandleCommand(string commands)
        {
            if (commands == null) return;

            foreach (var command in commands)
            {
                HandleCommand(command.ToCommand());
            }
        }

        private void Rotate(Command direction)
        {
            if (direction == Command.Left)
            {
                RotateLeft();
            }
            else if (direction == Command.Right)
            {
                RotateRight();
            }
            else
                throw new InvalidOperationException($"Cannont handle command {direction} to Rotate.");
        }

        private void Move(Command direction)
        {
            if (direction == Command.Forward)
            {
                MoveForward();
            }
            else if (direction == Command.Backward)
            {
                MoveBackwards();
            }
            else
                throw new InvalidOperationException($"Cannont handle command {direction} to Move.");
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
