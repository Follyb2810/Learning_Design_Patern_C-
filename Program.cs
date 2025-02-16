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
using System;
using System.Security.Cryptography;
using System.Text;

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

  public static void GenerateCrypto()
  {
    byte[] randomBytes = new byte[32];
    using (var rng = RandomNumberGenerator.Create())
    {
      rng.GetBytes(randomBytes);
    }
    string hexKey = BitConverter.ToString(randomBytes).Replace("-", "").ToLower();
    Console.WriteLine(hexKey);
    //         const crypto = require("crypto");
    // const randomKey = crypto.randomBytes(32).toString("hex");
    // console.log(randomKey);

  }
  public static void GeneraeSHA256Hash()
  {
    string input = "hello";
    using (SHA256 sha256 = SHA256.Create())
    {
      byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
      string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
      Console.WriteLine(hash);
    }
    //         const crypto = require("crypto");
    // const hash = crypto.createHash("sha256").update("hello").digest("hex");
    // console.log(hash);

  }
  public static void GenerateEncryptionDecryption()
  {
    string plaintext = "hello";
    byte[] key = GenerateRandomBytes(32); // AES-256 Key
    byte[] iv = GenerateRandomBytes(16);  // AES IV

    string encrypted = EncryptAES(plaintext, key, iv);
    Console.WriteLine($"Encrypted: {encrypted}");
    //     const crypto = require("crypto");

    // const key = crypto.randomBytes(32);
    // const iv = crypto.randomBytes(16);

    // const cipher = crypto.createCipheriv("aes-256-cbc", key, iv);
    // let encrypted = cipher.update("hello", "utf8", "hex");
    // encrypted += cipher.final("hex");
    // console.log(encrypted);

  }
  static byte[] GenerateRandomBytes(int length)
  {
    byte[] bytes = new byte[length];
    using (var rng = RandomNumberGenerator.Create())
    {
      rng.GetBytes(bytes);
    }
    return bytes;
  }

  static string EncryptAES(string plaintext, byte[] key, byte[] iv)
  {
    using (Aes aes = Aes.Create())
    {
      aes.Key = key;
      aes.IV = iv;
      aes.Mode = CipherMode.CBC;
      aes.Padding = PaddingMode.PKCS7;

      using (var encryptor = aes.CreateEncryptor())
      {
        byte[] plainBytes = Encoding.UTF8.GetBytes(plaintext);
        byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        return Convert.ToBase64String(encryptedBytes);
      }
    }
  }
  public static void GenerateHMACHashing()
  {
    //       const crypto = require("crypto");
    // const hmac = crypto.createHmac("sha256", "secret-key").update("message").digest("hex");
    // console.log(hmac);
    string message = "message";
    string secretKey = "secret-key";

    using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
    {
      byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
      string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
      Console.WriteLine(hash);
    }

  }
}