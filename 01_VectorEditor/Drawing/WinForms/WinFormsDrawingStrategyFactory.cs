namespace _01_VectorEditor.Drawing.WinForms
{
    public class WinFormsDrawingStrategyFactory : AbstractDrawingStrategyFactory
    {
        public override AbstractDrawingStrategy LineSegmentDrawingStrategy()
        {
            return new WinFormsLineSegmentDrawingStrategy();
        }

        public override AbstractDrawingStrategy RectangleDrawingStrategy()
        {
            return new WinFormsRectangleDrawingStrategy();
        }
    }
}
