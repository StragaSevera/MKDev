using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_PendulumEngine;
using _08_PendulumEngine.Events;

namespace _08_PendulumWinForms
{
    public partial class Form1 : Form
    {
        private Renderer _renderer;
        private Engine _engine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            float dpi = pictureBox1.CreateGraphics().DpiX;
            _engine = new Engine(dpi);

            DialogResult dialogResult = MessageBox.Show("Render pendulum (yes) or spiral (no)?",
                "Rendering", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _renderer = new PendulumRenderer(pictureBox1);
                _renderer.SubscribeToEntity(_engine.Entities[0]);
            }
            else
            {
                _renderer = new SpiralRenderer(pictureBox1);
                _renderer.SubscribeToEntity(_engine.Entities[1]);
            }
            
            _engine.Start();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var inputEvent = new MoveInputEvent(e.X, e.Y);
            _engine.AddInputEvent(inputEvent);
        }
    }
}
