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
        //Properties skal altid begynde med stort begyndelsesbogstav
        public double angleA { get; set; }   
        
        // overriding methods!
        public override double Area()
        {
            return angleA * angleA;
        }

//Denne metode kan gå hen og blive farlig.....prøv at forstille dig, hvad der sker hvis nogle glemmer at overskrive metoden i f.eks. rectangle?
        public override double Circumference()
        {
            return angleA * 4;
        }
    }   
}
