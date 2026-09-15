namespace MarsRover
{
    public class Rover
    {
        public Rover(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public Position Position { get; private set; }
        public Direction Direction { get; private set; }

        public void ProcessCommand(MovementCommand command)
        {
            switch (command)
            {
                case MovementCommand.F:
                    this.MoveForward();
                    break;
            }
        }

        public void MoveForward()
        {
            switch (this.Direction)
            {
                case Direction.North:
                    this.Position = new Position(this.Position.X, this.Position.Y + 1);
                    break;
                case Direction.East:
                    this.Position = new Position(this.Position.X + 1, this.Position.Y);
                    break;
                case Direction.South:
                    this.Position = new Position(this.Position.X, this.Position.Y - 1);
                    break;
                case Direction.West:
                    this.Position = new Position(this.Position.X - 1, this.Position.Y);
                    break;

            }
        }
    }
}
