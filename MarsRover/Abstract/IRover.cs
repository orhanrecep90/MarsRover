using MarsRover.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Abstract
{
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void ApplyCommands(string commands);
        string ToString();
    }
}
