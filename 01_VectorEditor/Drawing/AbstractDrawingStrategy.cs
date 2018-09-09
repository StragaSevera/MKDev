using System.Numerics;

namespace _01_VectorEditor.Drawing
{
    public abstract class AbstractDrawingStrategy
    {
        public abstract void Draw(Vector2 point1, Vector2 point2);
    }
}