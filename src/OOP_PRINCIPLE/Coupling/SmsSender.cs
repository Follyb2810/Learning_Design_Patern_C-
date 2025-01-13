namespace Design.src.OOP_PRINCIPLE.Coupling
{
    public class SmsSender:INotificationService
    {
     public void SendNotification(string message){
        System.Console.WriteLine("sending sms " + message);
     }   
    }
}