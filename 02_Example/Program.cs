using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Example.Infrastructure;
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

            var circle = new Circle();
            var rectangle = new Rectangle();
            var newShape = new NewShape();

            circle.Render(wpfRenderer);
            rectangle.Render(wpfRenderer);
            newShape.Render(wpfRenderer);

            circle.Render(winFormsRenderer);
            rectangle.Render(winFormsRenderer);
            newShape.Render(winFormsRenderer);

        }
    }
}
