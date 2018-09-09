using System.Numerics;

namespace _01_VectorEditor.Primitives
{
    public abstract class Shape
    {
        public abstract void Draw();

        public abstract float GetDistanceFrom(Vector2 point);
    }
}