using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing.WinForms
{
    class WinFormsRenderer : AbstractRenderer
    {
        public override void Render(Shape shape)
        {
            Console.WriteLine($"Cannot render {shape.GetType()} from WinForms!");
        }

        public override void Render(LineSegment segment)
        {
            Console.WriteLine($"WinForms lineSegment: {segment.Point1}, {segment.Point2}");
        }

        public override void Render(Rectangle rectangle)
        {
            Console.WriteLine($"WinForms rectangle: {rectangle.Point1}, {rectangle.Point2}");
        }
    }
}
