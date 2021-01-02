using System;
using System.Windows.Forms;

namespace ComputationalPracticum
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_rk = new System.Windows.Forms.CheckBox();
            this.checkBox_ie = new System.Windows.Forms.CheckBox();
            this.checkBox_euler = new System.Windows.Forms.CheckBox();
            this.button_plot = new System.Windows.Forms.Button();
            this.textBox_Y0 = new System.Windows.Forms.TextBox();
            this.label_Y0 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_X0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.textBox_N0 = new System.Windows.Forms.TextBox();
            this.label_N0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_rk);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_ie);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_euler);
            this.splitContainer1.Panel2.Controls.Add(this.button_plot);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Y0);
            this.splitContainer1.Panel2.Controls.Add(this.label_Y0);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X0);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N);
            this.splitContainer1.Panel2.Controls.Add(this.label_N);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N0);
            this.splitContainer1.Panel2.Controls.Add(this.label_N0);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Euler_GTE";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "ImprovedEuler_GTE";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "RungeKutta_GTE";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(540, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // checkBox_rk
            // 
            this.checkBox_rk.AutoSize = true;
            this.checkBox_rk.Checked = true;
            this.checkBox_rk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_rk.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_rk.Location = new System.Drawing.Point(0, 327);
            this.checkBox_rk.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_rk.Name = "checkBox_rk";
            this.checkBox_rk.Size = new System.Drawing.Size(256, 21);
            this.checkBox_rk.TabIndex = 20;
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
            this.checkBox_ie.Location = new System.Drawing.Point(0, 306);
            this.checkBox_ie.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ie.Name = "checkBox_ie";
            this.checkBox_ie.Size = new System.Drawing.Size(256, 21);
            this.checkBox_ie.TabIndex = 19;
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
            this.checkBox_euler.Location = new System.Drawing.Point(0, 285);
            this.checkBox_euler.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_euler.Name = "checkBox_euler";
            this.checkBox_euler.Size = new System.Drawing.Size(256, 21);
            this.checkBox_euler.TabIndex = 18;
            this.checkBox_euler.Text = "Euler";
            this.checkBox_euler.UseVisualStyleBackColor = true;
            this.checkBox_euler.CheckedChanged += new System.EventHandler(this.checkBox_euler_CheckedChanged);
            // 
            // button_plot
            // 
            this.button_plot.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_plot.Location = new System.Drawing.Point(0, 244);
            this.button_plot.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_plot.Name = "button_plot";
            this.button_plot.Padding = new System.Windows.Forms.Padding(4);
            this.button_plot.Size = new System.Drawing.Size(256, 41);
            this.button_plot.TabIndex = 17;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // textBox_Y0
            // 
            this.textBox_Y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Y0.Location = new System.Drawing.Point(0, 222);
            this.textBox_Y0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Y0.Name = "textBox_Y0";
            this.textBox_Y0.Size = new System.Drawing.Size(256, 22);
            this.textBox_Y0.TabIndex = 22;
            this.textBox_Y0.Text = "0";
            this.textBox_Y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Y0
            // 
            this.label_Y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Y0.Location = new System.Drawing.Point(0, 194);
            this.label_Y0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Y0.Name = "label_Y0";
            this.label_Y0.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label_Y0.Size = new System.Drawing.Size(256, 28);
            this.label_Y0.TabIndex = 21;
            this.label_Y0.Text = "Y_0";
            // 
            // textBox_X
            // 
            this.textBox_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X.Location = new System.Drawing.Point(0, 172);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(256, 22);
            this.textBox_X.TabIndex = 14;
            this.textBox_X.Text = "1,56";
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Size = new System.Drawing.Size(256, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            // 
            // textBox_X0
            // 
            this.textBox_X0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X0.Location = new System.Drawing.Point(0, 122);
            this.textBox_X0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X0.Name = "textBox_X0";
            this.textBox_X0.Size = new System.Drawing.Size(256, 22);
            this.textBox_X0.TabIndex = 12;
            this.textBox_X0.Text = "0";
            this.textBox_X0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label4.Size = new System.Drawing.Size(256, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "X_0";
            // 
            // textBox_N
            // 
            this.textBox_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N.Location = new System.Drawing.Point(0, 72);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(256, 22);
            this.textBox_N.TabIndex = 3;
            this.textBox_N.Text = "10";
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_N
            // 
            this.label_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_N.Location = new System.Drawing.Point(0, 47);
            this.label_N.Name = "label_N";
            this.label_N.Padding = new System.Windows.Forms.Padding(3);
            this.label_N.Size = new System.Drawing.Size(256, 25);
            this.label_N.TabIndex = 2;
            this.label_N.Text = "N";
            this.label_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_N0
            // 
            this.textBox_N0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N0.Location = new System.Drawing.Point(0, 25);
            this.textBox_N0.Name = "textBox_N0";
            this.textBox_N0.Size = new System.Drawing.Size(256, 22);
            this.textBox_N0.TabIndex = 1;
            this.textBox_N0.Text = "3";
            this.textBox_N0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_N0
            // 
            this.label_N0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_N0.Location = new System.Drawing.Point(0, 0);
            this.label_N0.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label_N0.Name = "label_N0";
            this.label_N0.Padding = new System.Windows.Forms.Padding(4);
            this.label_N0.Size = new System.Drawing.Size(256, 25);
            this.label_N0.TabIndex = 0;
            this.label_N0.Text = "n";
            this.label_N0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_N0.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "GTE";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_N0;
        private System.Windows.Forms.TextBox textBox_N0;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.CheckBox checkBox_rk;
        private System.Windows.Forms.CheckBox checkBox_ie;
        private System.Windows.Forms.CheckBox checkBox_euler;
        private System.Windows.Forms.Button button_plot;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_X0;
        private System.Windows.Forms.Label label4;
        private TextBox textBox_Y0;
        private Label label_Y0;
    }
}