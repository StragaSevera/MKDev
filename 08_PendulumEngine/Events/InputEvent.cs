using _08_PendulumEngine.Entities;

namespace _08_PendulumEngine.Events
{
    public abstract class InputEvent
    {
        public abstract void VisitEntity(Entity entity);
        public abstract void VisitEntity(Pendulum entity);
        public abstract void VisitEntity(Spiral entity);
    }
}
