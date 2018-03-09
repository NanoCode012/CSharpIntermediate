using System;

namespace CSharpIntermediate_Interfaces
{
    class UploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading ..");
        }
    }

}
