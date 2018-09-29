using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_PendulumEngine
{
    public class Engine
    {
        private readonly IRenderer _renderer;
        private readonly GameState _state;
        private Timer _timer;
        private long _lastTickTime;

        public Engine(IRenderer renderer, float dpi)
        {
            _renderer = renderer;
            _state = new GameState(dpi);
        }

        public void Start()
        {
            _lastTickTime = TimeInMs();
            _timer = new Timer(Tick, null, 16, 16); // 16 ms => 60 fps
        }

        public void Stop()
        {
            _timer.Dispose();
        }

        public void Tick(object _)
        {
            // Вычисляем, сколько прошло времени на самом деле
            long currentTickTime = TimeInMs();
            int timeElapsed = (int)(currentTickTime - _lastTickTime);
            _lastTickTime = currentTickTime;

            _state.Tick(timeElapsed);
            _renderer.Render(_state);
        }

        private static long TimeInMs()
        {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }
    }
}
