namespace Design.src.SOLID_PRINCIPLE.SingleResponsibility
{
    public class BadUser
    {
     public string? UserName {get;set;}   
     public string? Email {get;set;} 
     public void RegisterUser(){
        //? violating single responsibility by having more than one purpose user model and register method
        BadUser badUser = new BadUser(){UserName="folly",Email="follt"};
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(Email!,"thanks for registering to our platform");
        emailSender.SendEmail(badUser.Email!,"thanks for registering to our platform inside the min");
        
        
     }  
    }
}