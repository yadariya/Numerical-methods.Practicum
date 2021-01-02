using System;

namespace ComputationalPracticum
{
    class RungeKutta : Grid
    {
        public RungeKutta(int N, double x0, double X, double y0) : base(N, x0, X, y0)
        {
            double h = (X - x0) / N;
            y[0] = y0;
            for (int i = 1; i < N; i++)
            {
                double k1 = 1 / Math.Cos(x[i - 1]) - y[i - 1] * Math.Tan(x[i - 1]);
                double k2 = 1 / Math.Cos(x[i - 1] + h / 2) - (y[i - 1] + h / 2 * k1) * Math.Tan(x[i - 1] + h / 2);
                double k3 = 1 / Math.Cos(x[i - 1] + h / 2) - (y[i - 1] + h / 2 * k2) * Math.Tan(x[i - 1] + h / 2);
                double k4 = 1 / Math.Cos(x[i - 1] + h) - (y[i - 1] + h * k3) * Math.Tan(x[i - 1] + h);
                y[i] = y[i - 1] + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
            }
        }
    }
}
