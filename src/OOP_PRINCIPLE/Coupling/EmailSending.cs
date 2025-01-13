using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.OOP_PRINCIPLE.Coupling
{
    public class EmailSending:INotificationService
    {
        public void SendNotification(string message){ System.Console.WriteLine("decoupling with interface "+ message);}
    }
}