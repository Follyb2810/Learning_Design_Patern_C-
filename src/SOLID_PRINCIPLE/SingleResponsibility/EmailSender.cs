using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.SOLID_PRINCIPLE.SingleResponsibility
{
    public class EmailSender
    {
        public void SendEmail(string email,string message){
            System.Console.WriteLine($"this message  {message} is to {email}");
        } 
    }
}