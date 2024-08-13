using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratikPolymorphism
{
    public class BaseGeometrikSekil
    {
        public int width { get; set; }
        public int height { get; set; }

        public virtual int AreaCalculate(int width, int height)
        {
            return width * height;
            Console.WriteLine("Area is : " + (width * height));
        }
        public virtual double AreaCalculate(double width, double height)
        {
            return (width * height) / 2;
        }
    }
    public class Square : BaseGeometrikSekil
    {
        public override int AreaCalculate(int width, int height)
        {
            return width * height;
        }
    }
    public class Rectangle : BaseGeometrikSekil
    {
        public override int AreaCalculate(int width, int height)
        {
            return width * height;  
        }

    }
    public class RightTriangle : BaseGeometrikSekil
    {
        public override int AreaCalculate(int width, int height)
        {
            return (width * height) / 2;
        }
    }

}
