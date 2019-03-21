using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DesignPattern
{
    class FactoryDesign
    {
        public void main()
        {
            IShap circle = ShapeFactory.GetShap("Circle");
            IShap rectangle = ShapeFactory.GetShap("Rectangle");
        }
    }

    public class ShapeFactory
    {
        public static IShap GetShap(string shape)
        {
            if(shape== "Square")
            {
                return new Square();
            }
            else if(shape == "Rectangle")
            {
                return new Rectangle();
            }
            else if (shape == "Circle")
            {
                return new Rectangle();
            }
            return null;
        }
    }

     public interface IShap
    {
        void Draw();
    }

    public class Square : IShap
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Rectangle : IShap
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

    public class Circle : IShap
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }


}
