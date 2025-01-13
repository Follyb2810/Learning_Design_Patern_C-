namespace Design.src.OOP_PRINCIPLE.Polymorphism
{
    public class Car:Vehicle
    {
       public int NumberOfDoors {get;set;} 
       public int NumberOfWheel {get;set;}
       public override void  Start(){System.Console.WriteLine("Vehicle Car is starting");}
       public override void  Stop(){System.Console.WriteLine("Vehicle Car is stopping");}
    }
}