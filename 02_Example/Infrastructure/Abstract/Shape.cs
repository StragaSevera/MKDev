namespace _02_Example.Infrastructure.Abstract
{
    public abstract class Shape : IRenderable
    {
        public virtual void Render(AbstractRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
