using System;

namespace Geometri
{
    class Parallelogram : Rectangle
    {
        // parametrized constructor declaration!
        public Parallelogram (double angA, double angB, double heig) : base(angA, angB)
        {
            // initialization!
            aHeight = heig;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double aHeight { get; set; }

        // overriding methods!
        public override double Area()
        {
            return angleA * aHeight;
        }

        public override double Circumference()
        {
            return (2 * angleA) + (2 * angleB);
        }
    }
}
