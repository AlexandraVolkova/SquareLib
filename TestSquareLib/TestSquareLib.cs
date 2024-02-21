using SquareLib;

namespace TestSquareLib
{
    public class TestSquareLib
    {
        [Fact]

        public void FindCircleSquare1()
        {
            ISquare circle;
            circle = new CircleCalculation(5);
            double actual = circle.FindSquare();
            double expected = 78.5398;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindCircleSquare2()
        {
            ISquare circle;
            circle = new CircleCalculation(2);
            double actual = circle.FindSquare();
            double expected = 12.5664;
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void FindTriangleSquare1()
        {
            ISquare triangle;
            triangle = new TriangleCalculation(3, 4, 5);
            double actual = triangle.FindSquare();
            double expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void FindTriangleSquare2()
        {
            ISquare triangle;
            triangle = new TriangleCalculation(10, 5, 7);
            double actual = triangle.FindSquare();
            double expected = 16.2481;
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void CheckIfRectangularTriangle1()
        {
            ISquare triangle;
            triangle = new TriangleCalculation(3, 4, 5);
            bool actual = triangle.IfRectangular();
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void CheckIfRectangularTriangle2()
        {
            ISquare triangle;
            triangle = new TriangleCalculation(5, 12, 13);
            bool actual = triangle.IfRectangular();
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void CheckIfRectangularTriangle3()
        {
            ISquare triangle;
            triangle = new TriangleCalculation(10, 5, 7);
            bool actual = triangle.IfRectangular();
            bool expected = false;
            Assert.Equal(expected, actual);
        }

    }
}