namespace WakingSkeleton.Test;

using MarsRover;

public sealed class RoverTests
{

    [Test]
    [TestCase(0,0)]
    [TestCase(1,1)]
    public void RoverHasPosition(int x, int y)
    {
        var actualPosition = new Position(x, y);
        var expectedPosition = new Position(x, y);
        var rover = new Rover(actualPosition, Direction.North);
        Assert.That(rover.Position, Is.EqualTo(expectedPosition));
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

    [Test]
    public void RoverProcessesMovementCommands()
    {
        var rover = new Rover(new Position(0, 0), Direction.North);
        var expectedPosition = new Position(0, 1);
        rover.ProcessCommand(MovementCommand.F);
        Assert.That(rover.Position, Is.EqualTo(expectedPosition));
    }
}
