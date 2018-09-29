using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_PendulumEngine
{
    public class MovePendulumInputEvent : InputEvent
    {
        public Vector2 Position { get; }

        public MovePendulumInputEvent(Vector2 position)
        {
            Position = position;
        }

        public MovePendulumInputEvent(int x, int y) : this(new Vector2(x, y))
        {
        }
    }
}
