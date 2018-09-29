using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            Pendulum pendulum = state.Pendulum;
            var pivot = new PointF(pendulum.Pivot.X, pendulum.Pivot.Y);
            var point = new PointF(pendulum.Point.X, pendulum.Point.Y);

            var bitmap = new Bitmap(Picture.Width, Picture.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, Picture.Width, Picture.Height));
                g.DrawLine(Pens.Black, pivot, point);
                g.DrawEllipse(Pens.Black, new RectangleF(point - new SizeF(10, 10), new SizeF(20, 20)));
                Picture.CreateGraphics().DrawImageUnscaled(bitmap, 0, 0);
            }
            bitmap.Dispose();
        }
    }
}
