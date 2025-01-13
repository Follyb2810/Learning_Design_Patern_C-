namespace Design.src.OOP_PRINCIPLE.Abstraction
{
    public class EmailService
    {
       public void SendEmail(){
        Connect();
        Authenticate();
        Disconnect();
        LogUserInfo();
        System.Console.WriteLine("SendEmail");
       } 
       private void Connect(){System.Console.WriteLine("Connect");} 
       private void Authenticate(){System.Console.WriteLine("Authenticate");} 
       private void Disconnect(){System.Console.WriteLine("Disconnect");} 
       private void LogUserInfo(){System.Console.WriteLine("LogUserInfo");} 
    }
}