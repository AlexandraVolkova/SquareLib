

namespace SquareLib
{
    public class TriangleCalculation: ISquare
    {
        private double poluperimetr;
        private double square;

        public Triangle Triangl;

        public TriangleCalculation(double a, double b, double c)
        {
            Triangl = new Triangle() { SideA = a, SideB = b, SideC = c };
        }

        public double FindSquare()
        {
            findPoluperimetr();
            square = Math.Round((Math.Sqrt(poluperimetr * (poluperimetr - Triangl.SideA) *
                (poluperimetr - Triangl.SideB) * (poluperimetr - Triangl.SideC))), 4);
            return square;
        }


        public bool IfRectangular()
        {
            double a2 = Triangl.SideA * Triangl.SideA;
            double b2 = Triangl.SideB * Triangl.SideB;
            double c2 = Triangl.SideC * Triangl.SideC;
            if (a2 + b2 == c2)
            {
                Triangl.IsRectangular = true;
                return true;
            }
            else if (a2 + c2 == b2)
            {
                Triangl.IsRectangular = true;
                return true;
            }
            else if (b2 + c2 == a2)
            {
                Triangl.IsRectangular = true;
                return true;
            }
            else
            {
                Triangl.IsRectangular = false;
                return false;
            }

        }

        private double findPoluperimetr()
        {
            poluperimetr = (Triangl.SideA + Triangl.SideB + Triangl.SideC) / 2.0;
            return poluperimetr;
        }
    }
}
