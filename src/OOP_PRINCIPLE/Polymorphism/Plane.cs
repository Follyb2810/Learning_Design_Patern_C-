namespace Design.src.OOP_PRINCIPLE.Polymorphism
{
    public class Plane:Vehicle
    {
         public override void  Start(){System.Console.WriteLine("Vehicle Plane is starting");}
       public override void  Stop(){System.Console.WriteLine("Vehicle Plane is stopping");}
    }
}