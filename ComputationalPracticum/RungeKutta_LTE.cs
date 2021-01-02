using System;

namespace ComputationalPracticum
{
    class RungeKutta_LTE : Grid
    {
        public RungeKutta_LTE(int N, double x0, double X, double y0) : base(N, x0, X, y0)
        {
            y[0] = 0;
            Console.WriteLine(y0);
            double h = (X - x0) / N;
            for (int i = 1; i < N; i++)
            {
                if (i != N - 1)
                {
                    double y_exact_1 = Math.Sin(x[i + 1]) + Math.Cos(x[i + 1]);
                    double y_exact = Math.Sin(x[i]) + Math.Cos(x[i]);
                    double k1 = 1 / Math.Cos(x[i]) - y_exact * Math.Tan(x[i]);
                    double k2 = 1 / Math.Cos(x[i] + h / 2) - (y_exact + (h / 2) * k1) * Math.Tan(x[i] + h / 2);
                    double k3 = 1 / Math.Cos(x[i] + h / 2) - (y_exact + (h / 2) * k2) * Math.Tan(x[i] + h / 2);
                    double k4 = 1 / Math.Cos(x[i + 1]) - (y_exact + h * k3) * Math.Tan(x[i + 1]);
                    y[i] = Math.Abs(y_exact_1 - y_exact - h / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
                }
                else
                {
                    double y_exact_1 = Math.Sin(x[i] + h) + Math.Cos(x[i] + h);
                    double y_exact = Math.Sin(x[i]) + Math.Cos(x[i]);
                    double k1 = 1 / Math.Cos(x[i]) - y_exact * Math.Tan(x[i]);
                    double k2 = 1 / Math.Cos(x[i] + h / 2) - (y_exact + (h / 2) * k1) * Math.Tan(x[i] + h / 2);
                    double k3 = 1 / Math.Cos(x[i] + h / 2) - (y_exact + (h / 2) * k2) * Math.Tan(x[i] + h / 2);
                    double k4 = 1 / Math.Cos(x[i] + h) - (y_exact + h * k3) * Math.Tan(x[i] + h);
                    //y[i] = (y_exact_1 - y_exact - h / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
                }
            }
        }
    }
}
