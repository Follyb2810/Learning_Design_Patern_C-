using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Open_Close_Principles
{
    public class Rectangle:Shape
    {
public double Length {get;}
        public double Width {get;}
    public override double CalculateArea(){
          return 2 *(Width * Length);
    } 
    }
}