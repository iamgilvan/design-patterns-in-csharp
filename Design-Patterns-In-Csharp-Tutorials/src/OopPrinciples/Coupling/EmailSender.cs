using System;

namespace Design_Patterns_In_Csharp_Tutorials.Coupling
{
    public class EmailSender :INotificationService
    {
        public void SendNotification(string message)
        {
            // Email sending logic
            System.Console.WriteLine("Sending email: " + message);
        }
    }
}