using System;

namespace CSharpIntermediate_Polymorphism
{
    abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        //Virtual means derived class can choose whether to overide
        //public virtual void Draw()
        //{
        //    Console.WriteLine("I'm drawing a shape");
        //}

        //Abstract member, which means containing class must be abstract as well
        //Abstract inherits virtual, but contains no implementation 
        //This provides safety, to make sure that Draw will be implemented in the derived class
        public abstract void Draw();

        //Abstract class can contain non-abstract members, but not the other way around
        public void Copy()
        {
            Console.WriteLine("I'm being copied!");
        }

        public void Select()
        {
            Console.WriteLine("I'm being selected!");
        }
    }
}
