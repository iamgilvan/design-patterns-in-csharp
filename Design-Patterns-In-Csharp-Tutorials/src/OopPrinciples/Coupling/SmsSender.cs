using System;

namespace Design_Patterns_In_Csharp_Tutorials.Coupling
{
    public class SmsSender : INotificationService
    {

        public void SendNotification(string message)
        {
            System.Console.WriteLine("Sms message: " + message);
        }
    }
}