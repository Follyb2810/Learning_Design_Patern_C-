namespace Design.src.SOLID_PRINCIPLE.Likov_Substitute_Principle
{
    public class BadSquare:Rectangle
    {
        public override double Width { get => base.Width; set =>base.Width =base.Height = value; }
        public override double Height { get => base.Height; set =>base.Height =base.Width = value; }
    }
}