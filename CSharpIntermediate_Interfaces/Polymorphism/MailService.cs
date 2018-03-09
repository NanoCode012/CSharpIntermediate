using System;

namespace CSharpIntermediate_Interfaces
{
    class MailService : INotificationService
    {
        public void Send(Message message)
        {
            Console.WriteLine("Notifying success through email");
        }
    }
}
