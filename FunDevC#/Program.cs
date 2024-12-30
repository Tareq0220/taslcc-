namespace FunDevC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(7); 
            Shape rectangle = new Rectangle(5, 2); 

           Console.WriteLine("Area of Circle: " + circle.CalculateArea());
           Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());

        }
    }
}
