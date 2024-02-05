using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal class Circle
    {
         //Properties
        private double Radius {  get; set; }
        //Constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        //methods
        public double CalculateDiameter()
        {
            return Radius * 2;
        }
        public double CalculateCircumfrence()
        {
            return Radius * Math.PI * 2;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
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
