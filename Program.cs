// using Design.src.OOP_PRINCIPLE.Encapsulation;
// using Design.src.OOP_PRINCIPLE.Abstraction;
// using Design.src.OOP_PRINCIPLE.Inheritance;
// using Design.src.OOP_PRINCIPLE.Polymorphism;
// using Design.src.OOP_PRINCIPLE.Coupling;
// using Design.src.OOP_PRINCIPLE.Composition;
// using Design.src.SOLID_PRINCIPLE.SingleResponsibility;
// using Design.src.SOLID_PRINCIPLE.Likov_Substitute_Principle;
// using Design.src.SOLID_PRINCIPLE.Interface_Segration;
using Design.src.SOLID_PRINCIPLE.Dependence_Inversion_Principle;

public static class Program
{
  public static void Main(string[] args)
  {
    System.Console.WriteLine("hello world");
    
    //! Encapsulation hidden  the complexity of implementation from outside
    //? bad bankaccount
    // BadBankAccount badBankAccount = new BadBankAccount(){balance = 100};
    // System.Console.WriteLine(badBankAccount.balance);
    //? good bankaccount
    // BankAccount bankAccount = new BankAccount(20);
    // System.Console.WriteLine(bankAccount.GetBalance()+" account");
    // bankAccount.Deposit(100);
    // System.Console.WriteLine(bankAccount.GetBalance()+" account");
    // bankAccount.Deposit(100);
    // System.Console.WriteLine(bankAccount.GetBalance()+" account");
    // bankAccount.Withdraw(400);
    // System.Console.WriteLine(bankAccount.GetBalance());
    
    //! Abstraction reduce complaxity by hidden unnecessary details
    //? bad email service repeating badEmailService in all method
    // BadEmailService badEmailService = new BadEmailService();
    // badEmailService.SendEmail();
    // badEmailService.Connect();
    // badEmailService.Authenticate();
    // badEmailService.Disconnect();
    // badEmailService.LogUserInfo();
    //?  good because all method are private so we will call one which
    //?  is sendemail and it will call other method
    // EmailService emailService = new EmailService();
    // emailService.SendEmail();
    
    //! Inheritance
    /*
     Inheritance creating new class (Subclass or Derivedclass) base on existing class (Subclass or Derivedclass)
     Subclass inherit properties and behaviour of their superclass and can add new feaures or overide the existing ones
    */
   //* we dont have to rewrite common fields in all class 
  //  Vehicle vehicle = new Vehicle();
  //  vehicle.Brand ="vehicle folly";
  //  vehicle.Model="vehicle Babs";
  // vehicle.Year=2030;
  // vehicle.Start();
  // vehicle.Stop();  
  
  //*Inherit vehicle from Bike
  //   Bike bike = new Bike();
  //   bike.Brand ="bike folly";
  //  bike.Model="bike Babs";
  // bike.Year=2030;
  // bike.NumberOfWheel=2030;
  // bike.Start();
  // bike.Stop(); 
 //* Inherit vehicle from Car
  //   Car car = new Car();
  //   car.Brand ="car folly";
  //  car.Model="car Babs";
  // car.Year=2030;
  // car.NumberOfDoors=4;
  // car.NumberOfWheel=2030;
  // car.Start();
  // car.Stop(); 
  
  //! Polymorphism
  /*
  Polymorphism the ability of an object to take many forn
  poly:one
  morp= form
  
  */
 
 //* bad becuase vehicle inspaction will let use be nexting if else block
//  List<object> vehicles = new List<object>();
//  vehicles.Add(new Car(){Brand="Toyota",Model="Camry",Year=2030,NumberOfDoors=4});
//  vehicles.Add(new Bike(){Brand="Bajaj",Model="Suzuki",Year=2090});
//   foreach(var vehicle in vehicles){
//     System.Console.WriteLine(vehicle);
//     if(vehicle is Car){
//       var car = (Car)vehicle;
//       car.Start();
//     }else if(vehicle is Bike){
//       var bike = (Bike)vehicle;
//       bike.Start();
//     }
//   }
//? so because they are all ingeriting Vehicle we can call the method in vehicle
//  List<Vehicle> vehicles = new List<Vehicle>();
//  vehicles.Add(new Car(){Brand="Toyota",Model="Camry",Year=2030,NumberOfDoors=4});
//  vehicles.Add(new Bike(){Brand="Bajaj",Model="Suzuki",Year=2090});
//   foreach(var vehicle in vehicles){
//       vehicle.Start();
//   }

//! Coupling
/*
  Coupling the degree of dependebcy between classes
*/

// Order order = new Order(new EmailSending());
// order.PlaceOrder();
// Order smsMessage = new Order(new SmsSender());
// smsMessage.PlaceOrder();

//! Composition
//?
/*
 composition involves creating complex object by creating simple objects or componets.
 in composition object are assembled together to form larger structure with each components or object 
 maintaining it own state and behaviour.
  
*/
// Car car = new Car();
// car.StartCar();

//! SOLID PRICIPLE

//! Single Responsibility

//? A class should have one reason to change meaning it should have one purpose or responsibility
       //* violate single responsibilty by having more than two purpose
    //     BadUser badUser = new BadUser(){UserName="folly",Email="folly"};
    //     badUser.RegisterUser();
    //   //* Good
    //   User user = new User(){UserName="folly",Email="folly"};
    //  UserService userservice = new UserService();
    //  userservice.RegisterUser(user);

//! Open/Close Principle
//? software enity(classes,function,modules) should be open to extension but close to modification 
        
//! Likov Substitute Principle
//? object of a super class should be replaceable with object of subclass without affecting the corrcetness of the program
  
  // BadShape rectangle = new Rectangle(){Width=10,Height= 4};
  // System.Console.WriteLine(rectangle.Area());
  // BadShape square = new BadSquare(){Width=10,Height= 4};
  // System.Console.WriteLine(square.Area());
  // BadShape Gsquare = new GoodSquare(){SideLength=10};
  // System.Console.WriteLine(Gsquare.Area());
  
  //! Interface Segration Principle
  //? client should not be force to depend on interface they do not use
  // Sphere sphere = new Sphere(){Radius=10};
  // System.Console.WriteLine(sphere.Volume());
  // System.Console.WriteLine(sphere.Area());
  // Circle circle = new Circle(){Radius=10};
  // System.Console.WriteLine(circle.Volume());
  // System.Console.WriteLine(circle.Area());
  
  //! Dependency Inversion
  //? high level modules should not depends on low level. both should depens on abstraction
  BadCar car = new BadCar();
  car.StartCar();
  Car Icar = new Car(new Engine());
  Icar.StartCar();
  
  }   
}