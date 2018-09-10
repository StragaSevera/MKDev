using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Example.Infrastructure.Abstract;
using _02_Example.Infrastructure.Shapes;

namespace _02_Example.Infrastructure.Renderers
{
    public class DirtyRenderer
    {
        public void Render(Shape spape)
        {
            Console.WriteLine("No implementation found.");
        }

        public void Render(Circle circle)
        {
            Console.WriteLine("Rendering circle");
        }

        public void Render(Rectangle rectangle)
        {
            Console.WriteLine("Rendering rectangle");
        }

    }
}
