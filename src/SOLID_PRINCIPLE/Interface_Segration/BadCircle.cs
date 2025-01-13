
namespace Design.src.SOLID_PRINCIPLE.Interface_Segration
{
    public class BadCircle:IBadShape
    {
        public double Radius { get; set; }
       public double Area(){
        return Math.PI * Math.Pow(Radius,2);
       }
       public double Volume(){
        throw new InvalidOperationException("volume not applicable to 2d");
       }   
    }
}