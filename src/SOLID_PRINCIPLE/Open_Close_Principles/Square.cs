using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Open_Close_Principles
{
    public class Square:Shape
    {
        public double Length {get;}
        public double Width {get;}
        public override double CalculateArea(){
            return Length * Width;
        }
    }
}