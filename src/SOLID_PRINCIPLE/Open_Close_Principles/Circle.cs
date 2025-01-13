using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Open_Close_Principles
{
    public class Circle :Shape
    {
      public double Radius {get;set;}
    public override double CalculateArea(){
          return Math.PI * Math.Pow(Radius, 2);
    } 
    }
}