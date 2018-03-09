using System;

namespace CSharpIntermediate_Interfaces
{
    class NotifyReadyForEncodeActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notifying third-party to encode video ..");
        }
    }

}
