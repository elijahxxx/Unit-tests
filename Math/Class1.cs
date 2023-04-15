namespace Math;
using System;

public class QuadraticEquationSolver
{
    public static void Solve(double a, double b, double c, out double x1, out double x2)
    {
        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            x1 = double.NaN;
            x2 = double.NaN;
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            x2 = double.NaN;
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        }
    }
}