using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08_PendulumEngine
{
    public class GameState
    {
        public Pendulum Pendulum { get; private set; }
        private float _dpi;

        public GameState(float dpi)
        {
            _dpi = dpi;
            Pendulum = new Pendulum(300, Math.PI / 4d, new Vector2(350, 10), _dpi);
        }

        public void Tick(int timeElapsed)
        {
            Pendulum.Tick(timeElapsed);
        }

        public void HandleEvent(InputEvent inputEvent)
        {
            switch (inputEvent)
            {
                case MovePendulumInputEvent e:
                    Pendulum = Pendulum.InitFromPoint(e.Position, Pendulum.Pivot, _dpi);
                    break;
            }
        }
    }
}
