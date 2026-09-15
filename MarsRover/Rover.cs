namespace MarsRover
{
    public class Rover
    {
        public Rover(Position position)
        {
            Position = position;
        }

        public Position Position { get; private set; }
    }
}
