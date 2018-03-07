using System;

namespace CSharpIntermediate_AssociationBetweenClasses
{
    class Presentation
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object copied");
        }
        public void Delete()
        {
            Console.WriteLine("Object deleted");
        }
    }
}
