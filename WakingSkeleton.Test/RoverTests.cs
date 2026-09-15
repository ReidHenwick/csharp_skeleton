namespace WakingSkeleton.Test;

using MarsRover;

public sealed class RoverTests
{

    [Test]
    public void RoverHasPosition()
    {
        var position = new Position(0, 0);
        var rover = new Rover(position, Direction.North);
        Assert.That(rover.Position, Is.EqualTo(position));
    }

    [Test]
    public void RoverHasDirection()
    {
        var rover = new Rover(new Position(0, 0), Direction.North);
        Assert.That(rover.Direction, Is.EqualTo(Direction.North));
    }
}
