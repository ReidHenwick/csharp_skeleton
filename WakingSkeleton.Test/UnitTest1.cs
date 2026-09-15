namespace WakingSkeleton.Test;

using MarsRover;

public sealed class RoverTests
{

    [Test]
    public void RoverHasPosition()
    {
        var rover = new Rover(0);
        Assert.That(rover.PositionX, Is.EqualTo(0));
    }
}
