using System;

namespace SimpleGeometry
{
    class Circle : Shape
    {
        private double _x;
        private double _y;
        private double _radius;

        public Circle(double x, double y, double radius) 
            : base("Circle")
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override double Area
        {
            get { return (Math.PI * _radius * _radius); }
        }
    }
}
