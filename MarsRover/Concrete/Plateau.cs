using MarsRover.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Concrete
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; private set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}
