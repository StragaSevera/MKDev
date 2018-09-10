using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Example.Infrastructure.Abstract;
using _02_Example.Infrastructure.Shapes;

namespace _02_Example.Infrastructure.Abstract
{
    public abstract class AbstractRenderer
    {
        public abstract void Render(Shape shape);

        public virtual void Render(Circle circle)
        {
            Console.WriteLine($"Rendering of this figure ({circle.GetType().Name}) has not been overridden yet ({GetType().Name}).");
        }

        public virtual void Render(Rectangle rectangle)
        {
            Console.WriteLine($"Rendering of this figure ({rectangle.GetType().Name}) has not been overridden yet ({GetType().Name}).");
        }
        
    }
}
