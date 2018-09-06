﻿using System.Collections.Generic;
using System.Linq;
using System.Numerics;

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
        public void AddLine(Vector2 point1, Vector2 point2)
        {
            Shapes.Add(new Line(point1, point2));
        }

        public void AddRectangle(Vector2 point1, Vector2 point2)
        {
            Shapes.Add(new Rectangle(point1, point2));
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
                case Line l:
                    Shapes.Insert(index, new Line(point1, point2));
                    break;
                case Rectangle r:
                    Shapes.Insert(index, new Rectangle(point1, point2));
                    break;
            }
        }
    }
}
