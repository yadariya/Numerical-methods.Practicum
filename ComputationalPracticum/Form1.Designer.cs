using System;
using System.Windows.Forms;

namespace ComputationalPracticum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_exact = new System.Windows.Forms.CheckBox();
            this.checkBox_rk = new System.Windows.Forms.CheckBox();
            this.checkBox_ie = new System.Windows.Forms.CheckBox();
            this.checkBox_euler = new System.Windows.Forms.CheckBox();
            this.button_plot = new System.Windows.Forms.Button();
            this.textBox_Y0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_X0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart2);
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_exact);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_rk);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_ie);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_euler);
            this.splitContainer1.Panel2.Controls.Add(this.button_plot);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Y0);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X0);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 679;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 270);
            this.chart2.Name = "chart2";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Euler_LTE";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "ImprovedEuler_LTE";
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "RungeKutta_LTE";
            series3.Name = "Series3";
            series3.YValuesPerPoint = 2;
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(679, 284);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Euler";
            series4.Name = "Series_Euler";
            series4.YValuesPerPoint = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "Improved Euler";
            series5.Name = "Series_Improved";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "Runge-Kutta";
            series6.Name = "Series_RK";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.LegendText = "Exact";
            series7.Name = "Series_Exact";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(679, 275);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Methods";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // checkBox_exact
            // 
            this.checkBox_exact.AutoSize = true;
            this.checkBox_exact.Checked = true;
            this.checkBox_exact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_exact.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_exact.Location = new System.Drawing.Point(0, 304);
            this.checkBox_exact.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_exact.Name = "checkBox_exact";
            this.checkBox_exact.Size = new System.Drawing.Size(383, 21);
            this.checkBox_exact.TabIndex = 10;
            this.checkBox_exact.Text = "Exact";
            this.checkBox_exact.UseVisualStyleBackColor = true;
            this.checkBox_exact.CheckedChanged += new System.EventHandler(this.checkBox_exact_CheckedChanged);
            // 
            // checkBox_rk
            // 
            this.checkBox_rk.AutoSize = true;
            this.checkBox_rk.Checked = true;
            this.checkBox_rk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_rk.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_rk.Location = new System.Drawing.Point(0, 283);
            this.checkBox_rk.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_rk.Name = "checkBox_rk";
            this.checkBox_rk.Size = new System.Drawing.Size(383, 21);
            this.checkBox_rk.TabIndex = 9;
            this.checkBox_rk.Text = "Runge-Kutta";
            this.checkBox_rk.UseVisualStyleBackColor = true;
            this.checkBox_rk.CheckedChanged += new System.EventHandler(this.checkBox_rk_CheckedChanged);
            // 
            // checkBox_ie
            // 
            this.checkBox_ie.AutoSize = true;
            this.checkBox_ie.Checked = true;
            this.checkBox_ie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ie.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_ie.Location = new System.Drawing.Point(0, 262);
            this.checkBox_ie.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ie.Name = "checkBox_ie";
            this.checkBox_ie.Size = new System.Drawing.Size(383, 21);
            this.checkBox_ie.TabIndex = 8;
            this.checkBox_ie.Text = "Improved Euler";
            this.checkBox_ie.UseVisualStyleBackColor = true;
            this.checkBox_ie.CheckedChanged += new System.EventHandler(this.checkBox_ie_CheckedChanged);
            // 
            // checkBox_euler
            // 
            this.checkBox_euler.AutoSize = true;
            this.checkBox_euler.Checked = true;
            this.checkBox_euler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_euler.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_euler.Location = new System.Drawing.Point(0, 241);
            this.checkBox_euler.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_euler.Name = "checkBox_euler";
            this.checkBox_euler.Size = new System.Drawing.Size(383, 21);
            this.checkBox_euler.TabIndex = 7;
            this.checkBox_euler.Text = "Euler";
            this.checkBox_euler.UseVisualStyleBackColor = true;
            this.checkBox_euler.CheckedChanged += new System.EventHandler(this.checkBox_euler_CheckedChanged);
            // 
            // button_plot
            // 
            this.button_plot.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_plot.Location = new System.Drawing.Point(0, 200);
            this.button_plot.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_plot.Name = "button_plot";
            this.button_plot.Padding = new System.Windows.Forms.Padding(4);
            this.button_plot.Size = new System.Drawing.Size(383, 41);
            this.button_plot.TabIndex = 6;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // textBox_Y0
            // 
            this.textBox_Y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Y0.Location = new System.Drawing.Point(0, 178);
            this.textBox_Y0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Y0.Name = "textBox_Y0";
            this.textBox_Y0.Size = new System.Drawing.Size(383, 22);
            this.textBox_Y0.TabIndex = 12;
            this.textBox_Y0.Text = "1";
            this.textBox_Y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label4.Size = new System.Drawing.Size(383, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y_0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_N
            // 
            this.textBox_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N.Location = new System.Drawing.Point(0, 128);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(383, 22);
            this.textBox_N.TabIndex = 5;
            this.textBox_N.Text = "10";
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_N.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label3.Size = new System.Drawing.Size(383, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "N";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox_X
            // 
            this.textBox_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X.Location = new System.Drawing.Point(0, 78);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(383, 22);
            this.textBox_X.TabIndex = 3;
            this.textBox_X.Text = "1,56";
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_X.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Size = new System.Drawing.Size(383, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // textBox_X0
            // 
            this.textBox_X0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X0.Location = new System.Drawing.Point(0, 28);
            this.textBox_X0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X0.Name = "textBox_X0";
            this.textBox_X0.Size = new System.Drawing.Size(383, 22);
            this.textBox_X0.TabIndex = 1;
            this.textBox_X0.Text = "0";
            this.textBox_X0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label1.Size = new System.Drawing.Size(383, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "X_0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Methods";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           /// throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ///throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ///throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           /// throw new NotImplementedException();
        }

        private void textBox_X0_Click(object sender, EventArgs e)
        {
            ///throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ///throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           /// throw new NotImplementedException();
        }

        private void checkBox_euler_Click(object sender, EventArgs e)
        {
            ///throw new NotImplementedException();
        }

        private void checkBox_ie_Click(object sender, EventArgs e)
        {
           /// throw new NotImplementedException();
        }

        private void checkBox_rk_Click(object sender, EventArgs e)
        {
           /// throw new NotImplementedException();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            ///throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_X0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_rk;
        private System.Windows.Forms.CheckBox checkBox_ie;
        private System.Windows.Forms.CheckBox checkBox_euler;
        private System.Windows.Forms.Button button_plot;
        private CheckBox checkBox_exact;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private TextBox textBox_Y0;
        private Label label4;
    }
}

