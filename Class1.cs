using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2._1
{
    internal interface ICalculator
    {
        double Digits { get; set; }
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }
    class Math : ICalculator
    {
        public double Digits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
