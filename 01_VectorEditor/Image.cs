using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using _01_VectorEditor.Drawing;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor
{
    public class Image
    {
        public Image()
        {
            Shapes = new List<Shape>();
        }

        public List<Shape> Shapes { get; }

        // И что, с каждым новым классом фигуры растить методы?..
        public void AddLineSegment(Vector2 point1, Vector2 point2)
        {
            LineSegment segment = CreateSegment(point1, point2);
            Shapes.Add(segment);
        }
        
        public void AddRectangle(Vector2 point1, Vector2 point2)
        {
            Rectangle rectangle = CreateRectangle(point1, point2);
            Shapes.Add(rectangle);
        }
        
        public void Draw()
        {
            Shapes.ForEach(shape => shape.Draw());
        }

        public Shape SelectShapeAt(Vector2 point)
        {
            Shape nearestShape = Shapes.OrderBy(shape => shape.GetDistanceFrom(point)).First();
            return nearestShape.GetDistanceFrom(point) <= 1f ? nearestShape : null;
        }

        public void ResizeShape(Shape shape, Vector2 point1, Vector2 point2)
        {
            int index = Shapes.IndexOf(shape);
            Shapes.Remove(shape);
            switch (shape)  // Уродливо. Надо бы заюзать фабрику, но как?.. Передавать ей 
                            // enum - еще более уродливо
            {
                case LineSegment l:
                    Shapes.Insert(index, CreateSegment(point1, point2));
                    break;
                case Rectangle r:
                    Shapes.Insert(index, CreateRectangle(point1, point2));
                    break;
            }
        }

        private static LineSegment CreateSegment(Vector2 point1, Vector2 point2)
        {
            return new LineSegment(point1, point2, new LineDrawingStrategy());
        }

        private static Rectangle CreateRectangle(Vector2 point1, Vector2 point2)
        {
            return new Rectangle(point1, point2, new RectangleDrawingStrategy());
        }

    }
}
