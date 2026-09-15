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
    [TestCase(Direction.North)]
    [TestCase(Direction.East)]
    [TestCase(Direction.South)]
    [TestCase(Direction.West)]
    public void RoverHasDirection(Direction direction)
    {
        var rover = new Rover(new Position(0, 0), direction);
        Assert.That(rover.Direction, Is.EqualTo(direction));
    }
}
