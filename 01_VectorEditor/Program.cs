using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using _01_VectorEditor.Drawing.WPF;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor
{
    class Program
    {
        private static void Main(string[] args)
        {
            var image = new Image(new WpfDrawingStrategyFactory());
            image.AddLineSegment(new Vector2(0, 0), new Vector2(2, 3));
            image.AddRectangle(new Vector2(-1, -1), new Vector2(5, 5));
            image.Draw();

            Console.WriteLine("Selecting shape at <0.8, 0.5>:");
            Shape shape = image.SelectShapeAt(new Vector2(0.8f, 0.5f));
            shape.Draw();

            Console.WriteLine("Resizing this line to <0, 0>, <3, 4>, drawing image:");
            image.ResizeShape(shape, new Vector2(0, 0), new Vector2(3, 4));
            image.Draw();
            Console.ReadLine();
        }
    }
}
