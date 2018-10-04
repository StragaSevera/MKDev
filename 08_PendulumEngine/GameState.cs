using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using _08_PendulumEngine.Entities;
using _08_PendulumEngine.Events;

namespace _08_PendulumEngine
{
    public class GameState
    {
        public List<IEntity> Entities { get; } = new List<IEntity>();

        public GameState(float dpi)
        {
            var pendulum = new Pendulum(300, Math.PI / 4d, new Vector2(350, 10), dpi);
            Entities.Add(pendulum);
            var spiral = new Spiral(20, 0, new Vector2(350, 350));
            Entities.Add(spiral);
        }

        public void Tick(int timeElapsed)
        {
            Entities.ForEach(e => e.Tick(timeElapsed));
        }

        public void HandleEvent(InputEvent inputEvent)
        {
            Entities.ForEach(e => e.HandleInputEvent(inputEvent));
        }
    }
}
