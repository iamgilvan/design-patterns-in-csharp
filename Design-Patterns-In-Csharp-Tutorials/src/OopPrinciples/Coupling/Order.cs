using System;

namespace Design_Patterns_In_Csharp_Tutorials.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            // Place order logic
            notificationService.SendNotification("Order placed successfully");
        }
    }
}