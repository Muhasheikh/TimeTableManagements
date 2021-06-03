
namespace StudentsAndTagsManagement.Forms
{
    partial class FormDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lableSt = new System.Windows.Forms.Label();
            this.labelLec = new System.Windows.Forms.Label();
            this.labelStudentsGroups = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLecs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lableSub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lableSt);
            this.panel1.Controls.Add(this.labelLec);
            this.panel1.Controls.Add(this.labelStudentsGroups);
            this.panel1.Location = new System.Drawing.Point(98, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 91);
            this.panel1.TabIndex = 6;
            // 
            // lableSt
            // 
            this.lableSt.AutoSize = true;
            this.lableSt.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold);
            this.lableSt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lableSt.Location = new System.Drawing.Point(105, 45);
            this.lableSt.Name = "lableSt";
            this.lableSt.Size = new System.Drawing.Size(33, 34);
            this.lableSt.TabIndex = 4;
            this.lableSt.Text = "S";
            this.lableSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLec
            // 
            this.labelLec.AutoSize = true;
            this.labelLec.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelLec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLec.Location = new System.Drawing.Point(43, 46);
            this.labelLec.Name = "labelLec";
            this.labelLec.Size = new System.Drawing.Size(0, 24);
            this.labelLec.TabIndex = 3;
            // 
            // labelStudentsGroups
            // 
            this.labelStudentsGroups.AutoSize = true;
            this.labelStudentsGroups.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelStudentsGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStudentsGroups.Location = new System.Drawing.Point(15, 15);
            this.labelStudentsGroups.Name = "labelStudentsGroups";
            this.labelStudentsGroups.Size = new System.Drawing.Size(205, 24);
            this.labelStudentsGroups.TabIndex = 2;
            this.labelStudentsGroups.Text = "Students Groups";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelLecs);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(376, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 91);
            this.panel3.TabIndex = 5;
            // 
            // labelLecs
            // 
            this.labelLecs.AutoSize = true;
            this.labelLecs.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold);
            this.labelLecs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLecs.Location = new System.Drawing.Point(104, 45);
            this.labelLecs.Name = "labelLecs";
            this.labelLecs.Size = new System.Drawing.Size(33, 34);
            this.labelLecs.TabIndex = 5;
            this.labelLecs.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(43, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(58, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lecturers";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lableSub);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(652, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 91);
            this.panel2.TabIndex = 7;
            // 
            // lableSub
            // 
            this.lableSub.AutoSize = true;
            this.lableSub.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold);
            this.lableSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lableSub.Location = new System.Drawing.Point(97, 45);
            this.lableSub.Name = "lableSub";
            this.lableSub.Size = new System.Drawing.Size(33, 34);
            this.lableSub.TabIndex = 6;
            this.lableSub.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subjects";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(318, 165);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(398, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(992, 510);
            this.ControlBox = false;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDashboard";
            this.ShowIcon = false;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lableSt;
        private System.Windows.Forms.Label labelLec;
        private System.Windows.Forms.Label labelStudentsGroups;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLecs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lableSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}