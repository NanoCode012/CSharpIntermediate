using System;

namespace CSharpIntermediate_Polymorphism
{
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm drawing a square");
        }
    }
}
