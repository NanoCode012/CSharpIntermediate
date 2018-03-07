using System;

namespace CSharpIntermediate_Polymorphism
{
    sealed class Text : Shape //making this sealed means that no classes can derive from it
    {
        public override void Draw()
        {
            Console.WriteLine("I'm drawing a text");
        }
    }
}
