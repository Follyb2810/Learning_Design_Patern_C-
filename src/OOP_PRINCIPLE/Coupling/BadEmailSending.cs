namespace Design.src.OOP_PRINCIPLE.Coupling
{
    public class BadEmailSending
    {
       public void SendEmail(string message){
        System.Console.WriteLine($"we are sending {message}");
       } 
    }
}