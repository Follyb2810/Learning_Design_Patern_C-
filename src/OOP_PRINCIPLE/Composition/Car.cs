using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.OOP_PRINCIPLE.Composition
{
    public class Car
    {
        private Engine engine = new Engine();
        private Wheel wheel = new Wheel();
        private Seat seat = new Seat();
        private Chasis chasis = new Chasis();   
        public void StartCar(){
            engine.Start();
            wheel.Rotate();
            chasis.Support();
            seat.Sit();
            System.Console.WriteLine("this is car start in composition");
        }
    }
}