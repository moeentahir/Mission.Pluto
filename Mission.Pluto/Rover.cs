using System;

namespace Mission.Pluto
{
    public class Rover
    {
        public Rover(int x, int y, Direction face)
        {
            X = x;
            Y = y;
            Face = face;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Face { get; set; }


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
            if (Face == Direction.North)
                Y += 1;
            else if (Face == Direction.East)
                X += 1;
            else if (Face == Direction.South)
                Y -= 1;
            else if (Face == Direction.West)
                X -= 1;
        }

        private void MoveBackwards()
        {
            if (Face == Direction.North)
                Y -= 1;
            else if (Face == Direction.East)
                X -= 1;
            else if (Face == Direction.South)
                Y += 1;
            else if (Face == Direction.West)
                X += 1;
        }

        private void RotateLeft()
        {
            var faceValue = (int)Face;
            faceValue -= 1;
            if (faceValue < 0) faceValue = 3;
            Face = (Direction)faceValue;
        }

        private void RotateRight()
        {
            var faceValue = (int)Face;
            faceValue = (faceValue + 1) % 4;
            Face = (Direction)faceValue;
        }
    }
}
