using MindBox.Geometry;

namespace MindBox.Tests
{
    public class FigureAreaTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleAreaTest()
        {
            FigureBase circle = new Circle(5);
            var area = FigureBase.CalculateArea(circle);

            var expectedResult = 78.539816339744831d;

            Assert.That(area, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TriangleAreaTest()
        {
            FigureBase circle = new Triangle(4, 7, 8);
            var area = FigureBase.CalculateArea(circle);

            var expectedResult = 13.997767679169419d;

            Assert.That(area, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void NegativeFigureSidesTest()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Triangle(-1, 3, 5));
            Assert.AreEqual("Something is wrong with the side parameters", ex.Message);
        }
        
        [Test]
        public void TriangleNotExistTest()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Triangle(1, 3, 5));
            Assert.AreEqual("Something is wrong with the side parameters", ex.Message);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(4, 7, 9, false)]
        public void TriangleIsRectangularTest(double a, double b, double c, bool result)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.That(triangle.IsRectangular(), Is.EqualTo(result));
        }
    }
}