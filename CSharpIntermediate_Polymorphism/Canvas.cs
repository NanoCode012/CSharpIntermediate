using System.Collections.Generic;
namespace CSharpIntermediate_Polymorphism
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes) shape.Draw();
        }
    }
}
