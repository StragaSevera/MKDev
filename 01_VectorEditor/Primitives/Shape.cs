using System.Numerics;
using _01_VectorEditor.Drawing;

namespace _01_VectorEditor.Primitives
{
    public abstract class Shape
    {
        private readonly AbstractDrawingStrategy drawingStrategy;

        protected Shape(AbstractDrawingStrategy drawingStrategy)
        {
            this.drawingStrategy = drawingStrategy;
        }

        public void Draw()
        {
            drawingStrategy.Draw(this);
        }

        public abstract float GetDistanceFrom(Vector2 point);
    }
}