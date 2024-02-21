

namespace SquareLib
{
    public class CircleCalculation: ISquare
    {
        private double square;

        public Circle Circl {  get; private set; }

        public CircleCalculation(double rad)
        {
            Circl = new Circle() { radius = rad };
        }

        public double FindSquare()
        {
            square = Math.Round((Math.PI * Circl.radius * Circl.radius), 4);
            return square;
        }

        public bool IfRectangular()
        {
            return false;
        }
    }
}
