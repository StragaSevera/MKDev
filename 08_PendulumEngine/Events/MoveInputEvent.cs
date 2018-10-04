using System.Numerics;
using _08_PendulumEngine.Entities;

namespace _08_PendulumEngine.Events
{
    public class MoveInputEvent : InputEvent
    {
        public Vector2 Position { get; }

        public MoveInputEvent(Vector2 position)
        {
            Position = position;
        }

        public MoveInputEvent(int x, int y) : this(new Vector2(x, y))
        {
        }

        public override void VisitEntity(IEntity entity)
        {
        }

        public override void VisitEntity(Pendulum entity)
        {
            entity.HandleInputEvent(this);
        }

        public override void VisitEntity(Spiral entity)
        {
            entity.HandleInputEvent(this);
        }
    }
}
