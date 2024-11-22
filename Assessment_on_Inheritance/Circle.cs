using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_on_Inheritance
{
    public class Circle:Shape
    {
        private int radius;
        private double area;
        private double perimeter;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            area = 3.14 * radius * radius;
        }

        public override void CalculatePerimeter()
        {
            perimeter = 2 * 3.14 * radius;
        }

        public override string ToString()
        {
            return $"\nArea of circle is: {area}\n Perimeter of Circle is:{perimeter}";
        }
    }
}
