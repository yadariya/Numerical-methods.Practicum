using System;

namespace ComputationalPracticum
{
    public class Euler : Grid
    {
        public Euler(int N, double x0, double X, double y0) : base(N, x0, X, y0)
        {
            y[0] = y0;
            double h = (X - x0) / N;
            for (int i = 1; i < N; i++)
            {
                y[i] = y[i - 1] + h * (1 / Math.Cos(x[i - 1]) - y[i - 1] * Math.Tan(x[i - 1]));
            }
        }
    }
}
