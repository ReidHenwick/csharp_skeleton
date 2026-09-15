namespace WakingSkeleton.Test;

public class Tests
{

    [Test]
    public void RoverHasPosition()
    {
        var rover = new Rover();
        Assert.That(rover.PositionX, Is.EqualTo(0));
        Assert.That(rover.PositionY, Is.EqualTo(0));
    }
}

public class Rover
{
    public int PositionX { get; private set; }
    public int PositionY { get; private set; }
}