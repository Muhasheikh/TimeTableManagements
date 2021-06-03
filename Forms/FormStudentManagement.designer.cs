
namespace StudentsAndTagsManagement.Forms
{
    partial class FormStudentManagement
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
            this.labelStManagement = new System.Windows.Forms.Label();
            this.labelAcYr = new System.Windows.Forms.Label();
            this.LabelGroupNo = new System.Windows.Forms.Label();
            this.labelProgramme = new System.Windows.Forms.Label();
            this.labelSubGrNo = new System.Windows.Forms.Label();
            this.academicyrcmbx = new System.Windows.Forms.ComboBox();
            this.programmecmbox = new System.Windows.Forms.ComboBox();
            this.gpNumbertxbx = new System.Windows.Forms.TextBox();
            this.SbgpNumbertxbx = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStManagement
            // 
            this.labelStManagement.AutoSize = true;
            this.labelStManagement.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStManagement.ForeColor = System.Drawing.Color.White;
            this.labelStManagement.Location = new System.Drawing.Point(272, 33);
            this.labelStManagement.Name = "labelStManagement";
            this.labelStManagement.Size = new System.Drawing.Size(329, 28);
            this.labelStManagement.TabIndex = 0;
            this.labelStManagement.Text = "Students Management";
            // 
            // labelAcYr
            // 
            this.labelAcYr.AutoSize = true;
            this.labelAcYr.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAcYr.ForeColor = System.Drawing.Color.White;
            this.labelAcYr.Location = new System.Drawing.Point(197, 97);
            this.labelAcYr.Name = "labelAcYr";
            this.labelAcYr.Size = new System.Drawing.Size(230, 24);
            this.labelAcYr.TabIndex = 1;
            this.labelAcYr.Text = "Academic Year Semester :";
            // 
            // LabelGroupNo
            // 
            this.LabelGroupNo.AutoSize = true;
            this.LabelGroupNo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelGroupNo.ForeColor = System.Drawing.Color.White;
            this.LabelGroupNo.Location = new System.Drawing.Point(197, 202);
            this.LabelGroupNo.Name = "LabelGroupNo";
            this.LabelGroupNo.Size = new System.Drawing.Size(148, 24);
            this.LabelGroupNo.TabIndex = 2;
            this.LabelGroupNo.Text = "Group Number :";
            this.LabelGroupNo.Click += new System.EventHandler(this.LabelGroupNo_Click);
            // 
            // labelProgramme
            // 
            this.labelProgramme.AutoSize = true;
            this.labelProgramme.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProgramme.ForeColor = System.Drawing.Color.White;
            this.labelProgramme.Location = new System.Drawing.Point(197, 147);
            this.labelProgramme.Name = "labelProgramme";
            this.labelProgramme.Size = new System.Drawing.Size(122, 24);
            this.labelProgramme.TabIndex = 3;
            this.labelProgramme.Text = "Programme :";
            // 
            // labelSubGrNo
            // 
            this.labelSubGrNo.AutoSize = true;
            this.labelSubGrNo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubGrNo.ForeColor = System.Drawing.Color.White;
            this.labelSubGrNo.Location = new System.Drawing.Point(197, 258);
            this.labelSubGrNo.Name = "labelSubGrNo";
            this.labelSubGrNo.Size = new System.Drawing.Size(185, 24);
            this.labelSubGrNo.TabIndex = 5;
            this.labelSubGrNo.Text = "Sub Group Number :";
            // 
            // academicyrcmbx
            // 
            this.academicyrcmbx.FormattingEnabled = true;
            this.academicyrcmbx.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.academicyrcmbx.Location = new System.Drawing.Point(546, 97);
            this.academicyrcmbx.Name = "academicyrcmbx";
            this.academicyrcmbx.Size = new System.Drawing.Size(189, 28);
            this.academicyrcmbx.TabIndex = 7;
            // 
            // programmecmbox
            // 
            this.programmecmbox.FormattingEnabled = true;
            this.programmecmbox.Items.AddRange(new object[] {
            "IT",
            "SE",
            "CS",
            "CSNE",
            "IM",
            "ISE",
            "DS"});
            this.programmecmbox.Location = new System.Drawing.Point(546, 147);
            this.programmecmbox.Name = "programmecmbox";
            this.programmecmbox.Size = new System.Drawing.Size(189, 28);
            this.programmecmbox.TabIndex = 8;
            // 
            // gpNumbertxbx
            // 
            this.gpNumbertxbx.Location = new System.Drawing.Point(546, 202);
            this.gpNumbertxbx.Name = "gpNumbertxbx";
            this.gpNumbertxbx.Size = new System.Drawing.Size(189, 27);
            this.gpNumbertxbx.TabIndex = 9;
            this.gpNumbertxbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SbgpNumbertxbx
            // 
            this.SbgpNumbertxbx.Location = new System.Drawing.Point(546, 258);
            this.SbgpNumbertxbx.Name = "SbgpNumbertxbx";
            this.SbgpNumbertxbx.Size = new System.Drawing.Size(189, 27);
            this.SbgpNumbertxbx.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Navy;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(158, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 42);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit Data";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.DarkRed;
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(725, 312);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(116, 47);
            this.btnManage.TabIndex = 14;
            this.btnManage.Text = "Delete Data";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Indigo;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(347, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 45);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(908, 185);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(536, 313);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(122, 45);
            this.BtnEdit.TabIndex = 17;
            this.BtnEdit.Text = "Edit Data";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FormStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(992, 637);
            this.ControlBox = false;
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SbgpNumbertxbx);
            this.Controls.Add(this.gpNumbertxbx);
            this.Controls.Add(this.programmecmbox);
            this.Controls.Add(this.academicyrcmbx);
            this.Controls.Add(this.labelSubGrNo);
            this.Controls.Add(this.labelProgramme);
            this.Controls.Add(this.LabelGroupNo);
            this.Controls.Add(this.labelAcYr);
            this.Controls.Add(this.labelStManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudentManagement";
            this.Load += new System.EventHandler(this.FormStudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStManagement;
        private System.Windows.Forms.Label labelAcYr;
        private System.Windows.Forms.Label LabelGroupNo;
        private System.Windows.Forms.Label labelProgramme;
        private System.Windows.Forms.Label labelSubGrNo;
        private System.Windows.Forms.ComboBox academicyrcmbx;
        private System.Windows.Forms.ComboBox programmecmbox;
        private System.Windows.Forms.TextBox gpNumbertxbx;
        private System.Windows.Forms.TextBox SbgpNumbertxbx;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEdit;
    }
}