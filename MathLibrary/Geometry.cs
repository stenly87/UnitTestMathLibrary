namespace MathLibrary
{
    public class Geometry
    {
        public double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1, 2));
        }

        public (double, double) KvadratnoyeUravneniye(int a, int b, int c)
        {
            double d = b * b - 4 * a * c;
            if (a == 0)
                return (double.NaN, double.NaN);
            if (d > 0)
            {
                return ((-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a));
            }
            else if (d == 0)
            {
                return (-b / (2 * a), -b / (2 * a));
            }
            else
            {
                return (double.NaN, double.NaN);
            }
        }
    }
}