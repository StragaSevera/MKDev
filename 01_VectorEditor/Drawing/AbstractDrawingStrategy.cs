using System.Numerics;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing
{
    public abstract class AbstractDrawingStrategy
    {
        public abstract void Draw(Shape shape);
    }
}