using System;

namespace CSharpIntermediate_Interfaces
{
    class NotifyOwnerStartProcessingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notifying owner that encoding started ..");
        }
    }

}
