using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab

{
    internal class Circle
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateDiameter(double radius)
        {
            return radius * 2;
        }

        public double CalculateCircumference(double radius)
        {
            return CalculateDiameter(radius) * double.Pi;
        }

        public double CalculateArea(double radius)
        {
            return radius * radius * double.Pi;
        }
        public void Grow() 
        {
            Radius = Radius * 2;
        }

        public double GetRadius()
        {
            return Radius;
        }

    }
}
