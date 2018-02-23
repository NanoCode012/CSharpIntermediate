using System.Collections.Generic;
namespace CSharpIntermediate_Polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Method overriding
            var shapes = new List<Shape>();
            shapes.Add(new Triangle());
            shapes.Add(new Circle());
            shapes.Add(new Triangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());
            shapes.Add(new Square());
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            //Abstract class cannot be instantiated
            //var shape = new Shape();
        }
    }
}
