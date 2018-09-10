using System.Numerics;
using _01_VectorEditor.Drawing;

namespace _01_VectorEditor.Primitives
{
    public abstract class Shape
    {
        public void Draw(AbstractRenderer renderer)
        {
            renderer.Render(this);
        }

        public abstract float GetDistanceFrom(Vector2 point);
    }
}