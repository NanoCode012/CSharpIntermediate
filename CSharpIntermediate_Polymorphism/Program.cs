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
        }
    }

    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes) shape.Draw();
        }
    }
}
