using System;

namespace Geometri
{
    class Trapezium : Parallelogram
    {
        // parametrized constructor declaration!
        public Trapezium (double angA, double angB, double angC, double angD, double heig) : base (angA, angB, heig)
        {
            // initialization!
            angleC = angC;
            angleD = angD;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public double angleC { get; set; }
        public double angleD { get; set; }

        // overriding methods!
        public override double Area()
        {
            return 0.5 * ((angleA + angleC) * aHeight);
        }

        public override double Circumference()
        {
            return angleA + angleB + angleC + angleD;
        }
    }
}
