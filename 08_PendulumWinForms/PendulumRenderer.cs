using System.Drawing;
using System.Windows.Forms;
using _08_PendulumEngine;
using _08_PendulumEngine.Entities;

namespace _08_PendulumWinForms
{
    internal class PendulumRenderer : Renderer
    {
        public PendulumRenderer(PictureBox picture) : base(picture)
        {
        }

        protected override void Render(Entity entity, Graphics g)
        {
            var pendulum = (Pendulum) entity;

            DrawLine(g, pendulum.Pivot, pendulum.Point);
            g.DrawEllipse(Pens.Black, new RectangleF(
                VectorToPoint(pendulum.Point) - new SizeF(10, 10),
                new SizeF(20, 20)
            ));
        }
    }
}
