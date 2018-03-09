using System;

namespace CSharpIntermediate_Interfaces
{
    class SMSService : INotificationService
    {
        public void Send(Message message)
        {
            Console.WriteLine("Notifying success through sms ...");
        }
    }
}
