using System.Numerics;
using _01_VectorEditor.Drawing;

namespace _01_VectorEditor.Primitives
{
    public abstract class Shape
    {
        public abstract void Draw(AbstractRenderer renderer);

        public abstract float GetDistanceFrom(Vector2 point);
    }
}