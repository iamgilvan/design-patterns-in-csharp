using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.S
{
    public class UserService
    {
         public void Register(User user)
        {
            // Register user logic...

            // Send Email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform");
        }
    }
}