using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Interface_Segration
{
    public class BadSphere:IBadShape
    {
        public double Radius { get; set; }
         public double Area(){
            return 4 * Math.PI * Math.Pow(Radius, 2);
         }
         public double Volume(){
            return (4.0/3.0) *Math.PI * Math.Pow(Radius,3);
         }
    }
}