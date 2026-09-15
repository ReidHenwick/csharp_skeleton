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
            Position = Position with { Y = Position.Y + 1 };
        }
    }
}
