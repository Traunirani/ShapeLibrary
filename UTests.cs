using NUnit.Framework;

namespace ShapeLibrary
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            double radius = 5.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6.0;
            double actualArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void RightTriangleCheck()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.IsTrue(isRightTriangle);
        }
    }
}