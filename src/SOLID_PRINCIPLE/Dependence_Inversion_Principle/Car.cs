using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Dependence_Inversion_Principle
{
    public class Car
    {
        private readonly IEngine _engine;
        public Car(IEngine engine)
        {
            _engine = engine;
        }
        public void StartCar(){
            _engine.Start();
            System.Console.WriteLine("Car start here");
        }
    }
}