using System;
using _08_PendulumEngine.Events;

namespace _08_PendulumEngine.Entities
{
    public abstract class Entity
    {
        public event EventHandler EntityTick;

        public void Tick(int timeElapsed)
        {
            Process(timeElapsed);
            EntityTick?.Invoke(this, new EventArgs());
        }

        public abstract void Process(int timeElapsed);

        public abstract void HandleInputEvent(InputEvent inputEvent);
    }
}