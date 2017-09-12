namespace SimpleGeometry
{
    class Rectangle : Shape
    {
        #region Instance fields
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        #endregion

        #region Constructor
        public Rectangle(double x1, double y1, double x2, double y2)
            : base("Rectangle")
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }
        #endregion

        /// <summary>
        /// Override of base class (abstract) property
        /// </summary>
        public override double Area
        {
            get { return (_x2 - _x1) * (_y2 - _y1); }
        }
    }
}
