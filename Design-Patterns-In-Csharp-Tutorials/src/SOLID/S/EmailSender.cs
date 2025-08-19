using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            System.Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}