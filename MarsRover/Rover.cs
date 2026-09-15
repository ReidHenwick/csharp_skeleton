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
    }
}
