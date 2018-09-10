﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Example.Infrastructure
{
    public abstract class Shape : IRenderable
    {
        public virtual void Render(AbstractRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
