using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunDevC_
{
    
    public interface Shape
    {
        double CalculateArea();
    }

   
    public class Circle : Shape
    {
        public double Radius { get; private set; } 

       
        public Circle(double radius)
        {
            Radius = radius;
        }

        
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius; 
        }
    }

    
    public class Rectangle : Shape
    {
        public double Length { get;set; } 
        public double Width { get;set; }  

       
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

       
        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    
    
}
