using System;

namespace Geometri
{
    class RightAngleTriangle : Rectangle
    {
        // parametrized constructor declaration!
        public RightAngleTriangle (double angA, double angB, double hypo) : base(angA, angB)
        {
            // initialization!
            hypotenuse = hypo;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double hypotenuse { get; set; }

        public override double Area()
        {
            return 0.5 * (angleA * angleB);
        }

        // overriding methods!
        public override double Circumference()
        {
            return angleA + angleB + hypotenuse; 
        }
    }
}
