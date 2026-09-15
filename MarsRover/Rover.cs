using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public Rover(double positionX)
        {
            PositionX = positionX;
        }

        public double PositionX { get; private set; }
    }
}
