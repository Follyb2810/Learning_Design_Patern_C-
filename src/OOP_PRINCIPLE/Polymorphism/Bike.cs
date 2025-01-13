
namespace Design.src.OOP_PRINCIPLE.Polymorphism
{
    public class Bike:Vehicle
    {
        public int NumberOfWheel {get;set;}   
               public override void  Start(){System.Console.WriteLine("Vehicle Bike is starting");}
       public override void  Stop(){System.Console.WriteLine("Vehicle Bike is stopping");}
    }
}