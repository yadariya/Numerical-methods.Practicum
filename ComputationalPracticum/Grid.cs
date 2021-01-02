namespace ComputationalPracticum
{
    public class Grid
    {
        public double[] x;
        public double[] y;
        public int N;

        public Grid(int N, double x0, double X, double y0)
        {
            double h = (X - x0) / N;
            x = new double[N];
            y = new double[N];

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                    x[i] = x0;
                else
                    x[i] = x[i - 1] + h;
            }
        }
    }
}
