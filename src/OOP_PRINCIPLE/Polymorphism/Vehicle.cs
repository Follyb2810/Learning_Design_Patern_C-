namespace Design.src.OOP_PRINCIPLE.Polymorphism
{
    public class Vehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public virtual void Start(){System.Console.WriteLine("Vehicle start");}
        public virtual void Stop(){System.Console.WriteLine("Vehicle stop");}
    }
}