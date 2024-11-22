using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_on_Inheritance
{
     public class Triangle : Shape
    {
        private double tbase, theight;
        private double a,b,c;
        private double area;
        private double perimeter;
        public Triangle(double tbase, double theight, double a, double b, double c)
        {
            this.tbase = tbase;
            this.theight = theight;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void CalculateArea()
        {
            area = 0.5 * tbase * theight;
        }
        public override void CalculatePerimeter()
        {
            perimeter = a + b + c;
        }

        public override string ToString()
        {
            return $"\nArea of Rectangle:{area},\nPerimeter of Rectangle:{perimeter}";
        }
    }
}
