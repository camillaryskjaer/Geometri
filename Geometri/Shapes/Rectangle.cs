using System;

namespace Geometri
{
    class Rectangle : Square
    {
        // parametrized constructor declaration!
        public Rectangle (double angA, double angB) : base (angA)
        {
            // initialization!
            angleB = angB;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double angleB { get; set; }

        // overriding methods!
        public override double Area()
        {
            return angleA * angleB;
        }

        public override double Circumference()
        {
            return (angleA + angleB) * 2;
        }
    }
}
