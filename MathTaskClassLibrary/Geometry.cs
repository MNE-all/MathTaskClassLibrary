namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int x,  int y)
        {
            return x * y;
        }

        public double CylinderVolume(int r, int h)
        {
            var result = Math.PI * r * r * h;
            return result;
        }

        public double SquareRoot(int number)
        {
            return Math.Sqrt(number);
        }

        public List<double>? QuadraticEquation(double a = 0, double b = 0, double c = 0)
        {
            var result = new List<double>();
            var disc = b * b - 4 * a * c;
            if (disc < 0)
            {
                return null;
            }
            else if (disc == 0)
            {
                result.Add(-b / (2 * a));
            }
            else
            {
                result.Add((-b + Math.Sqrt(disc)) / (2 * a));
                result.Add((-b - Math.Sqrt(disc)) / (2 * a));
            }
            return result;
        }

        public int SquareSum(int threshold)
        {
            var sum = 0;
            var counter = 0;

            while (sum + counter * counter < threshold)
            {
                sum += counter * counter++;
            }
            return sum;
        }
    }
}