﻿using System;

namespace SOLID._2._OCP
{
    class CircularRoom : Room
    {
        public double Radius { get; private set; }

        public CircularRoom(double radius)
        {
            Radius = radius;
        }


        public override double ComputeArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
