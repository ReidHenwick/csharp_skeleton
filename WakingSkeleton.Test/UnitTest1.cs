namespace WakingSkeleton.Test;

using MarsRover;

public sealed class RoverTests
{

    [Test]
    public void RoverHasPositionX()
    {
        var rover = new Rover(0, 0);
        Assert.That(rover.PositionX, Is.EqualTo(0));
    }

    [Test]
    public void RoverHasPositionY()
    {
        var rover = new Rover(0, 0);
        Assert.That(rover.PositionY, Is.EqualTo(0));
    }
}
