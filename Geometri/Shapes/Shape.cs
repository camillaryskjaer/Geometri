using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // abstraction!
    public abstract class Shape
    {
        // method declaration!
        //Her kunne du godt være lidt mere skarp og dokumentere hvad metoderne gør!
        public abstract double Circumference();
        public abstract double Area();
    }
}
