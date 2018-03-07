using System;

namespace CSharpIntermediate_Polymorphism
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm drawing a circle");
        }
    }
}
