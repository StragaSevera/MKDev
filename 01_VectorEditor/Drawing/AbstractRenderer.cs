using System;
using System.Numerics;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing
{
    public abstract class AbstractRenderer
    {
        public abstract void Render(Shape shape);

        public abstract void Render(LineSegment segment);
        public abstract void Render(Rectangle rectangle);
    }
}
