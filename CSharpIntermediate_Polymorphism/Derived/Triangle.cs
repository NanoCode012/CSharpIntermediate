using System;

namespace CSharpIntermediate_Polymorphism
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm drawing a triangle");
        }
    }
}
