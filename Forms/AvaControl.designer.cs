
namespace StudentsAndTagsManagement
{
    partial class AvaControl
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
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLecturer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLecturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLecturer
            // 
            this.btnLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnLecturer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLecturer.FlatAppearance.BorderSize = 0;
            this.btnLecturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturer.Location = new System.Drawing.Point(71, 27);
            this.btnLecturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(136, 37);
            this.btnLecturer.TabIndex = 0;
            this.btnLecturer.Text = "Lecturer";
            this.btnLecturer.UseVisualStyleBackColor = false;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Location = new System.Drawing.Point(231, 27);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(136, 37);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Location = new System.Drawing.Point(392, 27);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(136, 37);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnLecturer);
            this.panel1.Controls.Add(this.panelLecturer);
            this.panel1.Location = new System.Drawing.Point(9, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 433);
            this.panel1.TabIndex = 3;
            // 
            // panelLecturer
            // 
            this.panelLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.panelLecturer.Controls.Add(this.label6);
            this.panelLecturer.Location = new System.Drawing.Point(0, 0);
            this.panelLecturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLecturer.Name = "panelLecturer";
            this.panelLecturer.Size = new System.Drawing.Size(932, 433);
            this.panelLecturer.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 192);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.label6.Size = new System.Drawing.Size(796, 83);
            this.label6.TabIndex = 80;
            this.label6.Text = "AVAILABILITY MANAGEMENT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AvaControl";
            this.Size = new System.Drawing.Size(941, 539);
            this.Load += new System.EventHandler(this.AvaControl_Load);
            this.panel1.ResumeLayout(false);
            this.panelLecturer.ResumeLayout(false);
            this.panelLecturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLecturer;
        private System.Windows.Forms.Label label6;
    }
}
