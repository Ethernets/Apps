namespace Apps
{
    public class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;

            this.side2 = side2;
        }

        public double Area
        {
            get { return this.AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }

        private double AreaCalculator()
        {
            return this.side1 * this.side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (this.side1 + this.side2);
        }
    }
}
