using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationLib
{
    public class QuadraticEquation
    {
        public double a, b, c;
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        } 
        public double calculateDelta()
        {
            return b*b-4*a*c;
        }
        public double calculateX0()
        {
            return (-1 * b) / 2 * a;
        }
        public double calculateX1()
        {
            return (-1*b-Math.Sqrt(calculateDelta()))/2*a;
        }
        public double calculateX2()
        {
            return (-1 * b + Math.Sqrt(calculateDelta())) / 2 * a;
        }

    }
}
