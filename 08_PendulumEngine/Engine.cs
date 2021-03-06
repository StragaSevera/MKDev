﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _08_PendulumEngine.Entities;
using _08_PendulumEngine.Events;

namespace _08_PendulumEngine
{
    public class Engine
    {
        private readonly GameState _state;
        private Timer _timer;
        private long _lastTickTime;
        private readonly List<InputEvent> _inputEvents;

        public List<Entity> Entities => _state.Entities;

        public Engine(float dpi)
        {
            _state = new GameState(dpi);
            _inputEvents = new List<InputEvent>();
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

        public void AddInputEvent(InputEvent inputEvent)
        {
            _inputEvents.Add(inputEvent);
        }

        private void Tick(object _)
        {
            // Вычисляем, сколько прошло времени на самом деле
            long currentTickTime = TimeInMs();
            int timeElapsed = (int)(currentTickTime - _lastTickTime);
            _lastTickTime = currentTickTime;

            _inputEvents.ForEach(e => _state.HandleEvent(e));
            _inputEvents.Clear();

            _state.Tick(timeElapsed);
        }

        private static long TimeInMs()
        {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }
    }
}
