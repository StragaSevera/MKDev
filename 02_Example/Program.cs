using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Example.Infrastructure;
using _02_Example.Infrastructure.Abstract;
using _02_Example.Infrastructure.Renderers;
using _02_Example.Infrastructure.Shapes;

namespace _02_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var wpfRenderer = new WpfRenderer();
            var winFormsRenderer = new WinFormsRenderer();
            var dirtyRenderer = new DirtyRenderer();

            var circle = new Circle();
            var rectangle = new Rectangle();
            var newShape = new NewShape();

            Shape shape;

            // WPF renderer
            circle.Render(wpfRenderer);
            rectangle.Render(wpfRenderer);
            newShape.Render(wpfRenderer);
            Console.WriteLine();

            // WPF renderer, casting to Shape
            shape = circle;
            shape.Render(wpfRenderer);
            shape = rectangle;
            shape.Render(wpfRenderer);
            shape = newShape;
            shape.Render(wpfRenderer);
            Console.WriteLine();

            // WinForms renderer
            circle.Render(winFormsRenderer);
            rectangle.Render(winFormsRenderer);
            newShape.Render(winFormsRenderer);
            Console.WriteLine();

            // WinForms renderer, casting to Shape
            shape = circle;
            shape.Render(winFormsRenderer);
            shape = rectangle;
            shape.Render(winFormsRenderer);
            shape = newShape;
            shape.Render(winFormsRenderer);
            Console.WriteLine();

            // Dirty renderer, first attempt
            dirtyRenderer.Render(circle);
            dirtyRenderer.Render(rectangle);
            dirtyRenderer.Render(newShape);
            Console.WriteLine();

            // Dirty renderer, second attempt
            shape = circle;
            dirtyRenderer.Render(shape);
            shape = rectangle;
            dirtyRenderer.Render(shape);
            shape = newShape;
            dirtyRenderer.Render(shape);
            // There's a problem, ain't there?
            Console.WriteLine();

            // Dirty renderer, third attempt, dynamic dispatching (during runtime)
            dynamic dynamicShape;
            dynamicShape = circle;
            dirtyRenderer.Render(dynamicShape);
            dynamicShape = rectangle;
            dirtyRenderer.Render(dynamicShape);
            dynamicShape = newShape;
            dirtyRenderer.Render(dynamicShape);
            // Ugly, but works!
            Console.WriteLine();

        }
    }
}
