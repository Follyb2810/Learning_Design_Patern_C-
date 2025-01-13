namespace Design.src.SOLID_PRINCIPLE.Open_Close_Principles
{
    public class BadShape
    {
        public ShapeType Type { get; set; }
        public double Radius {get;set;}
        public double Length {get;}
        public double Width {get;}
        
        public double CalculateArea(){
            switch (Type)
            {
                case ShapeType.Circle:
                  return Math.PI * Math.Pow(Radius, 2);
                case ShapeType.Square:
                    return Length * Width;
                case ShapeType.Rectangle:
                    return 2*(Length * Width);
                default:
                  throw new InvalidOperationException("We do not support the squre");
            }
        }
    }
}