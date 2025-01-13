using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Interface_Segration
{
    public class Circle:IShape2D
    {
         public double Radius { get; set; }
       public double Area(){
        return Math.PI * Math.Pow(Radius,2);
       }
    }
}