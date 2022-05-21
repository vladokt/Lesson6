using Perimeter;

namespace PerimeterTests
{
    public class PerimeterTests
    {
        [Fact]
        public void PolygonPerimeterTest()
        {
            Point[] points = new Point[3];
            points[0] = new Point(1, 2, "A");
            points[1] = new Point(3, 4, "B");
            points[2] = new Point(5, 6, "C");

            double result = Math.Sqrt(8) + Math.Sqrt(8) + Math.Sqrt(32);
            Polygon polygon = new(points);

            Assert.Equal(result, polygon.Perimeter(), 8);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void PolygonNameTest(int pointsCount)
        {
            Point[] points = new Point[pointsCount];
            string[] polygonName =
            {
                "triangle",
                "quadrangle",
                "pentagon"
            };

            for (int i = 0; i < pointsCount; i++)
            {
                points[i] = new Point(1 + 2 * i, 2 + 2 * i, char.ToString(Convert.ToChar(65 + i)));
            }

            Polygon polygon = new(points);

            Assert.Equal(polygonName[pointsCount - 3], polygon.Name());

        }
    }
}