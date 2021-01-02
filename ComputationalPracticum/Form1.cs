using System;
using System.Windows.Forms;

namespace ComputationalPracticum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_plot_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = Double.Parse(textBox_X0.Text);
                double X = Double.Parse(textBox_X.Text);
                int N = Int32.Parse(textBox_N.Text);
                double y0 = Double.Parse(textBox_Y0.Text);

                Euler euler = new Euler(N, x0, X, y0);
                ImprovedEuler improvedEuler = new ImprovedEuler(N, x0, X, y0);
                RungeKutta rungeKutta = new RungeKutta(N, x0, X, y0);
                Exact exact = new Exact(N, x0, X, y0);
                double [] eroor1  = new double[N];
                for (int i = 0; i < N; i++) {
                    eroor1[i] = Math.Abs(euler.y[i] - exact.y[i]);
                }



                chart1.Series[0].Points.DataBindXY(euler.x, euler.y);
                chart1.Series[1].Points.DataBindXY(improvedEuler.x, improvedEuler.y);
                chart1.Series[2].Points.DataBindXY(rungeKutta.x, rungeKutta.y);
                chart1.Series[3].Points.DataBindXY(exact.x, exact.y);

                chart1.ChartAreas[0].AxisX.Minimum = x0;
                chart1.ChartAreas[0].AxisX.Maximum = X;
                chart1.ChartAreas[0].AxisY.Minimum = y0;

                Euler_LTE euler_lte = new Euler_LTE(N, x0, X, y0);
                ImprovedEuler_LTE improveEuler_lte = new ImprovedEuler_LTE(N, x0, X, y0);
                RungeKutta_LTE rungeKutta_lte = new RungeKutta_LTE(N, x0, X, y0);
             
                chart2.Series[0].Points.DataBindXY(euler_lte.x, eroor1);
                chart2.Series[1].Points.DataBindXY(improveEuler_lte.x, improveEuler_lte.y);
                chart2.Series[2].Points.DataBindXY(rungeKutta_lte.x, rungeKutta_lte.y);
                chart2.ChartAreas[0].AxisX.Minimum = x0;
                chart2.ChartAreas[0].AxisX.Maximum = X;
            }
            catch
            {
                MessageBox.Show("Wrong Data!");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            button_plot_Click(sender, e);
        }

        private void checkBox_euler_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Enabled = checkBox_euler.Checked;
            chart2.Series[0].Enabled = checkBox_euler.Checked;
        }

        private void checkBox_ie_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Enabled = checkBox_ie.Checked;
            chart2.Series[1].Enabled = checkBox_ie.Checked;
        }

        private void checkBox_rk_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[2].Enabled = checkBox_rk.Checked;
            chart2.Series[2].Enabled = checkBox_rk.Checked;
        }

        private void checkBox_exact_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[3].Enabled = checkBox_exact.Checked;
        }

    }
}

