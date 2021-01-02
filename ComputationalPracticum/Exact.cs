using System;

namespace ComputationalPracticum
{
    class Exact : Grid
    {
        public Exact(int N, double x0, double X, double y0) : base(N, x0, X, y0)
        {
            double c = y0 / Math.Cos(x0) - Math.Tan(x0);

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                    y[i] = y0;
                else
                    y[i] = Math.Sin(x[i]) + c * Math.Cos(x[i]);
            }
        }
    }
}
