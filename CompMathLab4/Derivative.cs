using System;

namespace Testing
{
    public class Derivative
    {
        public double CalculateFirstDerivative(double x, double step) =>
                 (Math.Pow(x + step, 2) - Math.Pow(x, 2)) / step;
        public double CalculateFirstDerivativeTwoSteps(double x, double step) =>
                 (Math.Pow(x + step, 2) - Math.Pow(x-step, 2)) / (2*step);

        public double CalculateSecondDerivative(double x, double step) =>
                 (Math.Pow(x + 2*step, 2) - 2*Math.Pow(x, 2) + Math.Pow(x - 2*step, 2)) / (4*step*step);
    }
}
