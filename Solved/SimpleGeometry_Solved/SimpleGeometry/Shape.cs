using System.Collections.Generic;

namespace SimpleGeometry
{
    abstract class Shape
    {
        private string _shapeName;
        public string ShapeName
        {
            get { return _shapeName; }
            set { _shapeName = value; }
        }

        protected Shape(string shapeName)
        {
            _shapeName = shapeName;
        }

        public abstract double Area { get; }

        public static double FindTotalArea(List<Shape> shapes)
        {
            double totalArea = 0;

            foreach (Shape s in shapes)
            {
                totalArea = totalArea + s.Area;
            }

            return totalArea;
        }
    }
}
