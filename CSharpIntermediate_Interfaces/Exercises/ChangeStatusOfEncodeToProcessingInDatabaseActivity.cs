using System;

namespace CSharpIntermediate_Interfaces
{
    class ChangeStatusOfEncodeToProcessingInDatabaseActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changed Encoding status from Ready to Processing ..");
        }
    }

}
