using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Abstract
{
    public interface IPosition
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
    }
}
