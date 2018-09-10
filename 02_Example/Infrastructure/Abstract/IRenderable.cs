using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Example.Infrastructure
{
    public interface IRenderable
    {
        void Render(AbstractRenderer renderer);
    }
}
