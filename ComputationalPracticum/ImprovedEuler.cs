using System;

namespace ComputationalPracticum
{
    class ImprovedEuler : Grid
    {
        public ImprovedEuler(int N, double x0, double X, double y0) : base(N, x0, X, y0)
        {
            double h = (X - x0) / N;
            y[0] = y0;
            for (int i = 1; i < N; i++)
            {
                double f1 = (1 / Math.Cos(x[i - 1])) - (y[i - 1] * Math.Tan(x[i - 1]));
                double euler = y[i - 1] + h * ((1 / Math.Cos(x[i - 1])) - y[i - 1] * Math.Tan(x[i - 1]));
                double f2 = (1 / Math.Cos(x[i])) - (euler * Math.Tan(x[i]));
                y[i] = y[i - 1] + (h / 2 * (f1 + f2));
            }
        }
    }
}
