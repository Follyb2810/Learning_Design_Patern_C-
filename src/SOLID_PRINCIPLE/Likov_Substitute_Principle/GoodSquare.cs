using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Likov_Substitute_Principle
{
    public class GoodSquare:BadShape
    {
        public double SideLength {get;set;}
         public override double Area(){
       return SideLength * SideLength;
    } 
    }
}