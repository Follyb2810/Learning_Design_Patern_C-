 namespace Design.src.SOLID_PRINCIPLE.Likov_Substitute_Principle
{
    public class Rectangle:BadShape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
    public override double Area(){
       return Width * Height;
    }  
    }
}