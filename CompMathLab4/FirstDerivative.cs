using System;

namespace Testing
{
    public class FirstDerivative
    {
        public double CalculateFirstDerivative(double x, double step) =>
                 (Math.Pow(x + step, 2) - Math.Pow(x, 2)) / step;
    }
}
