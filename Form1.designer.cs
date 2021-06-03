
namespace StudentsAndTagsManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btn_TimeTable = new System.Windows.Forms.Button();
            this.BtnStatM = new System.Windows.Forms.Button();
            this.BtnRoomM = new System.Windows.Forms.Button();
            this.BtnAvailabilityM = new System.Windows.Forms.Button();
            this.btnSessions = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.buttonWorkingDays = new System.Windows.Forms.Button();
            this.DashBoard = new System.Windows.Forms.Button();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lableSub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lableSt = new System.Windows.Forms.Label();
            this.labelLec = new System.Windows.Forms.Label();
            this.labelStudentsGroups = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLecs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSide.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.panelSide.Controls.Add(this.btn_TimeTable);
            this.panelSide.Controls.Add(this.BtnStatM);
            this.panelSide.Controls.Add(this.BtnRoomM);
            this.panelSide.Controls.Add(this.BtnAvailabilityM);
            this.panelSide.Controls.Add(this.btnSessions);
            this.panelSide.Controls.Add(this.btnLocations);
            this.panelSide.Controls.Add(this.btnTags);
            this.panelSide.Controls.Add(this.btnSubjects);
            this.panelSide.Controls.Add(this.btnStudents);
            this.panelSide.Controls.Add(this.btnLecturers);
            this.panelSide.Controls.Add(this.buttonWorkingDays);
            this.panelSide.Controls.Add(this.DashBoard);
            this.panelSide.Controls.Add(this.buttonLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(355, 510);
            this.panelSide.TabIndex = 0;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // btn_TimeTable
            // 
            this.btn_TimeTable.BackColor = System.Drawing.Color.White;
            this.btn_TimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TimeTable.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TimeTable.ForeColor = System.Drawing.Color.Black;
            this.btn_TimeTable.Location = new System.Drawing.Point(0, 473);
            this.btn_TimeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimeTable.Name = "btn_TimeTable";
            this.btn_TimeTable.Size = new System.Drawing.Size(355, 39);
            this.btn_TimeTable.TabIndex = 13;
            this.btn_TimeTable.Text = "Filter TImeTable";
            this.btn_TimeTable.UseVisualStyleBackColor = false;
            this.btn_TimeTable.Click += new System.EventHandler(this.btn_TimeTable_Click);
            // 
            // BtnStatM
            // 
            this.BtnStatM.BackColor = System.Drawing.Color.White;
            this.BtnStatM.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStatM.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStatM.ForeColor = System.Drawing.Color.Black;
            this.BtnStatM.Location = new System.Drawing.Point(0, 434);
            this.BtnStatM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStatM.Name = "BtnStatM";
            this.BtnStatM.Size = new System.Drawing.Size(355, 39);
            this.BtnStatM.TabIndex = 12;
            this.BtnStatM.Text = "Statistics";
            this.BtnStatM.UseVisualStyleBackColor = false;
            this.BtnStatM.Click += new System.EventHandler(this.BtnStatM_Click);
            // 
            // BtnRoomM
            // 
            this.BtnRoomM.BackColor = System.Drawing.Color.White;
            this.BtnRoomM.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRoomM.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRoomM.ForeColor = System.Drawing.Color.Black;
            this.BtnRoomM.Location = new System.Drawing.Point(0, 396);
            this.BtnRoomM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRoomM.Name = "BtnRoomM";
            this.BtnRoomM.Size = new System.Drawing.Size(355, 38);
            this.BtnRoomM.TabIndex = 11;
            this.BtnRoomM.Text = "Rooms Management";
            this.BtnRoomM.UseVisualStyleBackColor = false;
            this.BtnRoomM.Click += new System.EventHandler(this.BtnRoomM_Click);
            // 
            // BtnAvailabilityM
            // 
            this.BtnAvailabilityM.BackColor = System.Drawing.Color.White;
            this.BtnAvailabilityM.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAvailabilityM.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAvailabilityM.ForeColor = System.Drawing.Color.Black;
            this.BtnAvailabilityM.Location = new System.Drawing.Point(0, 358);
            this.BtnAvailabilityM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAvailabilityM.Name = "BtnAvailabilityM";
            this.BtnAvailabilityM.Size = new System.Drawing.Size(355, 38);
            this.BtnAvailabilityM.TabIndex = 10;
            this.BtnAvailabilityM.Text = "Availability Management";
            this.BtnAvailabilityM.UseVisualStyleBackColor = false;
            this.BtnAvailabilityM.Click += new System.EventHandler(this.BtnAvailabilityM_Click);
            // 
            // btnSessions
            // 
            this.btnSessions.BackColor = System.Drawing.Color.White;
            this.btnSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessions.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnSessions.ForeColor = System.Drawing.Color.Black;
            this.btnSessions.Location = new System.Drawing.Point(0, 320);
            this.btnSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSessions.Name = "btnSessions";
            this.btnSessions.Size = new System.Drawing.Size(355, 38);
            this.btnSessions.TabIndex = 8;
            this.btnSessions.Text = "Sessions Management";
            this.btnSessions.UseVisualStyleBackColor = false;
            this.btnSessions.Click += new System.EventHandler(this.btnSessions_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.BackColor = System.Drawing.Color.White;
            this.btnLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocations.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocations.ForeColor = System.Drawing.Color.Black;
            this.btnLocations.Location = new System.Drawing.Point(0, 282);
            this.btnLocations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(355, 38);
            this.btnLocations.TabIndex = 7;
            this.btnLocations.Text = "Locations Management";
            this.btnLocations.UseVisualStyleBackColor = false;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnTags
            // 
            this.btnTags.BackColor = System.Drawing.Color.White;
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnTags.ForeColor = System.Drawing.Color.Black;
            this.btnTags.Location = new System.Drawing.Point(0, 244);
            this.btnTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(355, 38);
            this.btnTags.TabIndex = 6;
            this.btnTags.Text = "Tags Management";
            this.btnTags.UseVisualStyleBackColor = false;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackColor = System.Drawing.Color.White;
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjects.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubjects.ForeColor = System.Drawing.Color.Black;
            this.btnSubjects.Location = new System.Drawing.Point(0, 206);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(355, 38);
            this.btnSubjects.TabIndex = 5;
            this.btnSubjects.Text = "Subjects Management";
            this.btnSubjects.UseVisualStyleBackColor = false;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.White;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.Black;
            this.btnStudents.Location = new System.Drawing.Point(0, 168);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(355, 38);
            this.btnStudents.TabIndex = 4;
            this.btnStudents.Text = "Students Management";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.BackColor = System.Drawing.Color.White;
            this.btnLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLecturers.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnLecturers.ForeColor = System.Drawing.Color.Black;
            this.btnLecturers.Location = new System.Drawing.Point(0, 130);
            this.btnLecturers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(355, 38);
            this.btnLecturers.TabIndex = 3;
            this.btnLecturers.Text = "Lecturers Management";
            this.btnLecturers.UseVisualStyleBackColor = false;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // buttonWorkingDays
            // 
            this.buttonWorkingDays.BackColor = System.Drawing.Color.White;
            this.buttonWorkingDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorkingDays.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.buttonWorkingDays.ForeColor = System.Drawing.Color.Black;
            this.buttonWorkingDays.Location = new System.Drawing.Point(0, 92);
            this.buttonWorkingDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWorkingDays.Name = "buttonWorkingDays";
            this.buttonWorkingDays.Size = new System.Drawing.Size(355, 38);
            this.buttonWorkingDays.TabIndex = 2;
            this.buttonWorkingDays.Text = "Working Days Management";
            this.buttonWorkingDays.UseVisualStyleBackColor = false;
            this.buttonWorkingDays.Click += new System.EventHandler(this.buttonWorkingDays_Click);
            // 
            // DashBoard
            // 
            this.DashBoard.BackColor = System.Drawing.Color.White;
            this.DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoard.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold);
            this.DashBoard.ForeColor = System.Drawing.Color.Black;
            this.DashBoard.Location = new System.Drawing.Point(0, 54);
            this.DashBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(355, 38);
            this.DashBoard.TabIndex = 1;
            this.DashBoard.Text = "DashBoard";
            this.DashBoard.UseVisualStyleBackColor = false;
            this.DashBoard.Click += new System.EventHandler(this.DashBoard_Click);
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.buttonLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Font = new System.Drawing.Font("Copperplate Gothic Light", 15F);
            this.buttonLogo.ForeColor = System.Drawing.Color.White;
            this.buttonLogo.Location = new System.Drawing.Point(0, 0);
            this.buttonLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(355, 54);
            this.buttonLogo.TabIndex = 0;
            this.buttonLogo.Text = "Time Table Generator";
            this.buttonLogo.UseVisualStyleBackColor = false;
            this.buttonLogo.Click += new System.EventHandler(this.buttonLogo_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.panelForm.Controls.Add(this.chart1);
            this.panelForm.Controls.Add(this.panel2);
            this.panelForm.Controls.Add(this.panel1);
            this.panelForm.Controls.Add(this.panel3);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(355, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(992, 510);
            this.panelForm.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lableSub);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(660, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 91);
            this.panel2.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lableSt);
            this.panel1.Controls.Add(this.labelLec);
            this.panel1.Controls.Add(this.labelStudentsGroups);
            this.panel1.Location = new System.Drawing.Point(82, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 91);
            this.panel1.TabIndex = 5;
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
            this.panel3.Location = new System.Drawing.Point(374, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 91);
            this.panel3.TabIndex = 4;
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
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(317, 168);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(398, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1347, 510);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSide);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSide.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Button DashBoard;
        private System.Windows.Forms.Button buttonWorkingDays;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnSessions;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button BtnStatM;
        private System.Windows.Forms.Button BtnRoomM;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnAvailabilityM;
        private System.Windows.Forms.Button btn_TimeTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLecs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lableSt;
        private System.Windows.Forms.Label labelLec;
        private System.Windows.Forms.Label labelStudentsGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lableSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

