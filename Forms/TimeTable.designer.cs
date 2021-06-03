
namespace TimeTableManagement.Forms
{
    partial class TimeTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Lecturer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelTImetable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTImetable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Lecturer
            // 
            this.btn_Lecturer.Location = new System.Drawing.Point(61, 27);
            this.btn_Lecturer.Name = "btn_Lecturer";
            this.btn_Lecturer.Size = new System.Drawing.Size(151, 46);
            this.btn_Lecturer.TabIndex = 0;
            this.btn_Lecturer.Text = "LECTURER";
            this.btn_Lecturer.UseVisualStyleBackColor = true;
            this.btn_Lecturer.Click += new System.EventHandler(this.btn_Lecturer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "LOCATION";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "STUDENT GROUP";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelTImetable
            // 
            this.panelTImetable.Controls.Add(this.button3);
            this.panelTImetable.Location = new System.Drawing.Point(0, 0);
            this.panelTImetable.Name = "panelTImetable";
            this.panelTImetable.Size = new System.Drawing.Size(1043, 689);
            this.panelTImetable.TabIndex = 3;
            this.panelTImetable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTImetable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 611);
            this.panel1.TabIndex = 4;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Lecturer);
            this.Controls.Add(this.panel1);
            this.Name = "TimeTable";
            this.Size = new System.Drawing.Size(1043, 637);
            this.panelTImetable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lecturer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelTImetable;
        private System.Windows.Forms.Panel panel1;
    }
}
