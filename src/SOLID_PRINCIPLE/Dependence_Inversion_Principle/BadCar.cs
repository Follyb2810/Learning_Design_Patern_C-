using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.Dependence_Inversion_Principle
{
    public class BadCar
    {
        private readonly Engine _engine;
        public BadCar()
        {
            _engine = new Engine();
        }
        public void StartCar(){
            _engine.Start();
            System.Console.WriteLine("Car started");
        }
    }
}