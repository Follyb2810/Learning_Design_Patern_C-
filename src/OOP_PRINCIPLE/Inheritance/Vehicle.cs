namespace Design.src.OOP_PRINCIPLE.Inheritance
{
    public class Vehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public void Start(){System.Console.WriteLine("Vehicle start");}
        public void Stop(){System.Console.WriteLine("Vehicle stop");}
    }
}