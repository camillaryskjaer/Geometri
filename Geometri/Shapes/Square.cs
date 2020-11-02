using System;

namespace Geometri
{
    class Square : Shape
    {
        // parametrized constructor declaration!
        public Square (double angA)
        {
            // initialization!
            angleA = angA;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double angleA { get; set; }   
        
        // overriding methods!
        public override double Area()
        {
            return angleA * angleA;
        }

        public override double Circumference()
        {
            return angleA * 4;
        }
    }   
}
