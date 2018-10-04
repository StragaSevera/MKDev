using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using _08_PendulumEngine;
using _08_PendulumEngine.Entities;

namespace _08_PendulumWinForms
{
    internal class SpiralRenderer : Renderer
    {
        public SpiralRenderer(PictureBox picture) : base(picture)
        {
        }

        protected override void Render(Entity entity, Graphics g)
        {
            var spiral = (Spiral) entity;

            Vector2 lastPoint = spiral.Pivot;
            var points = spiral.Points;
            foreach (Vector2 point in points)
            {
                DrawLine(g, lastPoint, point);
                lastPoint = point;
            }
        }
    }
}
