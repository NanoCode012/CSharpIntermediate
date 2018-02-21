using System;

namespace CSharpIntermediate_Polymorphism
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        //Virtual means derived class can choose whether to overide
        public virtual void Draw()
        {
            Console.WriteLine("I'm drawing a shape");
        }


    }
}
