using System;

namespace _02_Example.Infrastructure.Renderers
{
    public class WinFormsRenderer : AbstractRenderer
    {
        public override void Render(Shape shape)
        {
            Console.WriteLine($"Rendering of this figure ({shape.GetType().Name}) has not been implemented yet ({GetType().Name}).");
        }

        public override void Render(Circle circle)
        {
            Console.WriteLine($"Rendering a circle ({GetType().Name}).");
        }
    }
}
