using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_PendulumEngine;

namespace _08_PendulumWinForms
{
    internal class Renderer : IRenderer
    {
        public PictureBox Picture { get; set; }

        public Renderer(PictureBox picture)
        {
            Picture = picture;
        }

        public void Render(GameState state)
        {
            var bitmap = new Bitmap(Picture.Width, Picture.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, Picture.Width, Picture.Height));
                //                RenderPendulum(state, g);
                RenderSpiral(state, g);
                Picture.CreateGraphics().DrawImageUnscaled(bitmap, 0, 0);
            }
            bitmap.Dispose();
        }

        private static void RenderSpiral(GameState state, Graphics g)
        {
            Spiral spiral = state.Spiral;

            DrawLine(g, spiral.Pivot, spiral.Points[0]);

            for (int i = 1; i < spiral.Points.Count; i++)
            {
                DrawLine(g, spiral.Points[i - 1], spiral.Points[i]);
            }
        }

        private static void RenderPendulum(GameState state, Graphics g)
        {
            Pendulum pendulum = state.Pendulum;

            DrawLine(g, pendulum.Pivot, pendulum.Point);
            g.DrawEllipse(Pens.Black, new RectangleF(VectorToPoint(pendulum.Point) - new SizeF(10, 10), new SizeF(20, 20)));
        }

        private static PointF VectorToPoint(Vector2 vector)
        {
            return new PointF(vector.X, vector.Y);
        }

        private static void DrawLine(Graphics g, Vector2 point1, Vector2 point2)
        {
            g.DrawLine(Pens.Black, VectorToPoint(point1), VectorToPoint(point2));
        }
    }
}
