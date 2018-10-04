using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_PendulumEngine;
using _08_PendulumEngine.Entities;

namespace _08_PendulumWinForms
{
    internal abstract class Renderer
    {
        public PictureBox Picture { get; set; }

        protected Renderer(PictureBox picture)
        {
            Picture = picture;
        }

        public void SubscribeToEntity(Entity entity)
        {
            entity.EntityTick += OnEntityTick;
        }

        public void OnEntityTick(object sender, EventArgs eventArgs)
        {
            using (var bitmap = new Bitmap(Picture.Width, Picture.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.FillRectangle(Brushes.White, new Rectangle(0, 0, Picture.Width, Picture.Height));
                    Render((Entity) sender, g);
                    Picture.CreateGraphics().DrawImageUnscaled(bitmap, 0, 0);
                }
            }
        }

        protected abstract void Render(Entity entity, Graphics g);

        protected static PointF VectorToPoint(Vector2 vector)
        {
            return new PointF(vector.X, vector.Y);
        }

        protected static void DrawLine(Graphics g, Vector2 point1, Vector2 point2)
        {
            g.DrawLine(Pens.Black, VectorToPoint(point1), VectorToPoint(point2));
        }
    }
}
