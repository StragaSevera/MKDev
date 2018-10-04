using _08_PendulumEngine.Events;

namespace _08_PendulumEngine.Entities
{
    public interface IEntity
    {
        void Tick(int timeElapsed);
        void HandleInputEvent(InputEvent inputEvent);
    }
}