using System;
using System.Windows.Forms;

namespace ComputationalPracticum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_plot_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Int32.Parse(textBox_N0.Text);
                int N = Int32.Parse(textBox_N.Text);
                double x0 = Double.Parse(textBox_X0.Text);
                double X = Double.Parse(textBox_X.Text);
                double y0 = Double.Parse(textBox_Y0.Text);

                double[] y_euler = new double[N - n + 1];
                double[] y_ImprovedEuler = new double[N - n + 1];
                double[] y_RungeKutta = new double[N - n + 1];

                double[] step = new double[N - n + 1];
                for (int i = 0; i < N - n + 1; i++)
                {

                    step[i] = n + i;
                }

                for (int nint = n; nint < N; nint++)
                {

                    Euler euler = new Euler(nint, x0, X, y0);
                    ImprovedEuler improvedEuler = new ImprovedEuler(nint, x0, X, y0);
                    RungeKutta rungeKutta = new RungeKutta(nint, x0, X, y0);
                    Exact exact = new Exact(nint, x0, X, y0);

                    Euler_GTE euler_gte = new Euler_GTE(nint, x0, X);
                    ImprovedEuler_GTE improvedEuler_gte = new ImprovedEuler_GTE(nint, x0, X);
                    RungeKutta_GTE rungeKutta_gte = new RungeKutta_GTE(nint, x0, X);
                    
                    for (int i = 0; i < nint; i++)
                    {
                        euler_gte.y[i] = Math.Abs(euler.y[i] - exact.y[i]);
                        improvedEuler_gte.y[i] = Math.Abs(improvedEuler.y[i] - exact.y[i]);
                        rungeKutta_gte.y[i] = Math.Abs(rungeKutta.y[i] - exact.y[i]);
                        
                        if (euler_gte.y[i] > y_euler[nint - n])
                        {
                            y_euler[nint - n] = euler_gte.y[i];
                        }
                        if (improvedEuler_gte.y[i] > y_ImprovedEuler[nint - n])
                        {
                            y_ImprovedEuler[nint - n] = improvedEuler_gte.y[i];
                        }
                        if (rungeKutta_gte.y[i] > y_RungeKutta[nint - n])
                        {
                            y_RungeKutta[nint - n] = rungeKutta_gte.y[i];
                        }
                    }
                }

                chart1.Series[0].Points.DataBindXY(step, y_euler);
                chart1.Series[1].Points.DataBindXY(step, y_ImprovedEuler);
                chart1.Series[2].Points.DataBindXY(step, y_RungeKutta);

            }
            catch
            {
                MessageBox.Show("Wrong Data!");
            }
        }


        private void Form2_Shown(object sender, EventArgs e)
        {
            button_plot_Click(sender, e);
        }

        private void checkBox_ie_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Enabled = checkBox_euler.Checked;
        }

        private void checkBox_rk_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[2].Enabled = checkBox_euler.Checked;
        }

        private void checkBox_euler_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Enabled = checkBox_euler.Checked;
        }

    }
}
