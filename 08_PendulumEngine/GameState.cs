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
        public Pendulum Pendulum { get; }

        public GameState(float dpi)
        {
            Pendulum = new Pendulum(300, Math.PI / 4d, new Vector2(400, 10), dpi);
        }

        public void Tick(int timeElapsed)
        {
            Pendulum.Tick(timeElapsed);
        }
    }
}
