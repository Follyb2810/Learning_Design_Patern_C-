using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.SingleResponsibility
{
    public class UserService
    {
         public void RegisterUser(User user){
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.Email!,"thanks for registering to our platform good single responsibility");       
        
     }  
    }
}