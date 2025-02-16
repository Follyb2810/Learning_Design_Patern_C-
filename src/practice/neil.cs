// using System;

// class A {
//     protected int valueA;

//     public A(int a) {
//         valueA = a;
//         Console.WriteLine($"A initialized with valueA: {a}");
//     }
// }

// class B : A {
//     private string valueB;

//     public B(int a, string b) : base(a) {  // ✅ Call A's constructor
//         valueB = b;
//         Console.WriteLine($"B initialized with valueB: {b}");
//     }
// }

// class Program {
//     static void Main() {
//         B obj = new B(100, "Hello");  
//         // Output:
//         // A initialized with valueA: 100
//         // B initialized with valueB: Hello
//     }
// }
