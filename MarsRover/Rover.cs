namespace MarsRover
{
    public class Rover
    {
        public Rover(double positionX, double positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public double PositionX { get; private set; }
        public double PositionY { get; private set; }
    }
}
