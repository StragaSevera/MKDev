namespace _01_VectorEditor.Drawing
{
    public abstract class AbstractDrawingStrategyFactory
    {
        public abstract AbstractDrawingStrategy LineSegmentDrawingStrategy();

        public abstract AbstractDrawingStrategy RectangleDrawingStrategy();
    }
}
