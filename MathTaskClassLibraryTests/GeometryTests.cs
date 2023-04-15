
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    public class GeometryTests
    {
        [Fact]
        public void RectangleArea_3and5_15returned()
        {
            Geometry geometry = new Geometry();
            var x = 3;
            var y = 5;
            var result = 15;

            Assert.Equal(result, geometry.RectangleArea(x, y));
        }

        [Fact]
        public void CylinderVolume_3and4_150overReturned()
        {
            Geometry geometry = new Geometry();
            var h = 3;
            var r = 4;
            var result = Math.PI * r * r * h;

            Assert.Equal(result, geometry.CylinderVolume(r, h));
        }

        [Fact]
        public void SquareRoot_9_3returned()
        {
            Geometry geometry = new Geometry();
            var number = 9;
            var result = 3;
            Assert.Equal(result, geometry.SquareRoot(number));
        }

        [Fact]
        public void QuadraticEquation_minus6_0_minus54_minus3And3Returned()
        {
            Geometry geometry = new Geometry();
            var a = -6;
            var b = 0;
            var c = 54;
            List<double> result = new List<double>
            {
                -3,
                3
            };

            Assert.Equal(result, geometry.QuadraticEquation(a, b, c));
        }

        [Fact]
        public void QuadraticEquation_minus4_28_minus49_3plusHalfReturned()
        {
            Geometry geometry = new Geometry();
            var a = -4;
            var b = 28;
            var c = -49;
            List<double> result = new List<double>
            {
                3.5
            };

            Assert.Equal(result, geometry.QuadraticEquation(a, b, c));
        }

        [Fact]
        public void QuadraticEquation_nullReturned()
        {
            Geometry geometry = new Geometry();
            var a = 3;
            var b = -4;
            var c = 94;


            Assert.Null(geometry.QuadraticEquation(a, b, c));
        }


        [Fact]
        public void SquareSum_6_5returned()
        {
            Geometry geometry = new Geometry();
            var threshold = 6;
            var result = geometry.SquareSum(threshold); 
            Assert.Equal(5, result);
        }
    }
}