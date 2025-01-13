namespace Design.src.OOP_PRINCIPLE.Coupling
{
    public class Order
    {
       //? decoupling  
        private readonly INotificationService _notificationService;
        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void PlaceOrder(){
            //? bad because tight coupling with order class
            BadEmailSending badEmailSending = new BadEmailSending();
            badEmailSending.SendEmail("thank you, order placed successfully ");
            
            //? good decoupling
            _notificationService.SendNotification("Order place successfully");
            
        }
        
    }
}