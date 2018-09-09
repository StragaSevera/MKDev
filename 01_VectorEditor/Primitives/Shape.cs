using System.Numerics;

namespace _01_VectorEditor
{
    public abstract class Shape
    {
        public abstract void Draw();

        public abstract float GetDistanceFrom(Vector2 point);
    }
}