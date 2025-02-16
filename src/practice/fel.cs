// using System;

// class Engine {
//     public Engine(string type) {
//         Console.WriteLine($"Engine of type {type} initialized.");
//     }
// }

// class Wheels {
//     public Wheels(int count) {
//         Console.WriteLine($"Car has {count} wheels.");
//     }
// }

// class Car {
//     private Engine engine;
//     private Wheels wheels;

//     public Car(string engineType, int wheelCount) {
//         engine = new Engine(engineType);  // ✅ Creating an Engine object
//         wheels = new Wheels(wheelCount);  // ✅ Creating a Wheels object
//         Console.WriteLine("Car is ready.");
//     }
// }

// class Program {
//     static void Main() {
//         Car myCar = new Car("V8", 4);

//         // Output:
//         // Engine of type V8 initialized.
//         // Car has 4 wheels.
//         // Car is ready.
//     }
// }
