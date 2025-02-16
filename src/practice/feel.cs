// using System;

// interface ICar {
//     void Drive();
// }

// interface IBoat {
//     void Sail();
// }

// class AmphibiousVehicle : ICar, IBoat {
//     private string name;
//     private int speed;

//     public AmphibiousVehicle(string name, int speed) {
//         this.name = name;
//         this.speed = speed;
//     }

//     public void Drive() {
//         Console.WriteLine($"{name} is driving at {speed} km/h.");
//     }

//     public void Sail() {
//         Console.WriteLine($"{name} is sailing at {speed / 2} knots.");
//     }
// }

// class Program {
//     static void Main() {
//         AmphibiousVehicle vehicle = new AmphibiousVehicle("AmphiCar", 60);
//         vehicle.Drive();
//         vehicle.Sail();

//         // Output:
//         // AmphiCar is driving at 60 km/h.
//         // AmphiCar is sailing at 30 knots.
//     }
// }
