namespace _01_VectorEditor.Drawing.WPF
{
    public class WpfDrawingStrategyFactory : AbstractDrawingStrategyFactory
    {
        public override AbstractDrawingStrategy LineSegmentDrawingStrategy()
        {
            return new WpfLineSegmentDrawingStrategy();
        }

        public override AbstractDrawingStrategy RectangleDrawingStrategy()
        {
            return new WpfRectangleDrawingStrategy();
        }
    }
}
