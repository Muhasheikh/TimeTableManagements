
namespace StudentsAndTagsManagement.Forms
{
    partial class FormConsecutiveSessions
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
            this.labelConsecutiveManagement = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.labelSubjectCodeCSM = new System.Windows.Forms.Label();
            this.cmbSbCodeCSM = new System.Windows.Forms.ComboBox();
            this.labelGrpNumbrCSM = new System.Windows.Forms.Label();
            this.cmbGrpNoCSM = new System.Windows.Forms.ComboBox();
            this.labelSessionID1 = new System.Windows.Forms.Label();
            this.labelSessionID2 = new System.Windows.Forms.Label();
            this.cmbSID1 = new System.Windows.Forms.ComboBox();
            this.cmbSID2 = new System.Windows.Forms.ComboBox();
            this.btnSubmitCSM = new System.Windows.Forms.Button();
            this.BtnEditCSM = new System.Windows.Forms.Button();
            this.btnDeleteCSM = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelCSMData = new System.Windows.Forms.Panel();
            this.dataGridViewCSMData = new System.Windows.Forms.DataGridView();
            this.labelSubGrCSM = new System.Windows.Forms.Label();
            this.cmbSubGrpNoCSM = new System.Windows.Forms.ComboBox();
            this.BtnClearCSM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.panelCSMData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSMData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsecutiveManagement
            // 
            this.labelConsecutiveManagement.AutoSize = true;
            this.labelConsecutiveManagement.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConsecutiveManagement.ForeColor = System.Drawing.Color.White;
            this.labelConsecutiveManagement.Location = new System.Drawing.Point(234, 19);
            this.labelConsecutiveManagement.Name = "labelConsecutiveManagement";
            this.labelConsecutiveManagement.Size = new System.Drawing.Size(503, 28);
            this.labelConsecutiveManagement.TabIndex = 2;
            this.labelConsecutiveManagement.Text = "Consecutive Sessions Management";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(173, 483);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 29;
            this.dataGridViewSearch.Size = new System.Drawing.Size(758, 173);
            this.dataGridViewSearch.TabIndex = 3;
            // 
            // labelSubjectCodeCSM
            // 
            this.labelSubjectCodeCSM.AutoSize = true;
            this.labelSubjectCodeCSM.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubjectCodeCSM.ForeColor = System.Drawing.Color.White;
            this.labelSubjectCodeCSM.Location = new System.Drawing.Point(92, 74);
            this.labelSubjectCodeCSM.Name = "labelSubjectCodeCSM";
            this.labelSubjectCodeCSM.Size = new System.Drawing.Size(133, 24);
            this.labelSubjectCodeCSM.TabIndex = 5;
            this.labelSubjectCodeCSM.Text = "Subject Code :";
            // 
            // cmbSbCodeCSM
            // 
            this.cmbSbCodeCSM.FormattingEnabled = true;
            this.cmbSbCodeCSM.Location = new System.Drawing.Point(290, 70);
            this.cmbSbCodeCSM.Name = "cmbSbCodeCSM";
            this.cmbSbCodeCSM.Size = new System.Drawing.Size(189, 28);
            this.cmbSbCodeCSM.TabIndex = 22;
            // 
            // labelGrpNumbrCSM
            // 
            this.labelGrpNumbrCSM.AutoSize = true;
            this.labelGrpNumbrCSM.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGrpNumbrCSM.ForeColor = System.Drawing.Color.White;
            this.labelGrpNumbrCSM.Location = new System.Drawing.Point(92, 124);
            this.labelGrpNumbrCSM.Name = "labelGrpNumbrCSM";
            this.labelGrpNumbrCSM.Size = new System.Drawing.Size(148, 24);
            this.labelGrpNumbrCSM.TabIndex = 23;
            this.labelGrpNumbrCSM.Text = "Group Number :";
            // 
            // cmbGrpNoCSM
            // 
            this.cmbGrpNoCSM.FormattingEnabled = true;
            this.cmbGrpNoCSM.Location = new System.Drawing.Point(290, 120);
            this.cmbGrpNoCSM.Name = "cmbGrpNoCSM";
            this.cmbGrpNoCSM.Size = new System.Drawing.Size(189, 28);
            this.cmbGrpNoCSM.TabIndex = 24;
            // 
            // labelSessionID1
            // 
            this.labelSessionID1.AutoSize = true;
            this.labelSessionID1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSessionID1.ForeColor = System.Drawing.Color.White;
            this.labelSessionID1.Location = new System.Drawing.Point(559, 92);
            this.labelSessionID1.Name = "labelSessionID1";
            this.labelSessionID1.Size = new System.Drawing.Size(135, 24);
            this.labelSessionID1.TabIndex = 25;
            this.labelSessionID1.Text = "Session ID (1) :";
            // 
            // labelSessionID2
            // 
            this.labelSessionID2.AutoSize = true;
            this.labelSessionID2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSessionID2.ForeColor = System.Drawing.Color.White;
            this.labelSessionID2.Location = new System.Drawing.Point(559, 155);
            this.labelSessionID2.Name = "labelSessionID2";
            this.labelSessionID2.Size = new System.Drawing.Size(135, 24);
            this.labelSessionID2.TabIndex = 26;
            this.labelSessionID2.Text = "Session ID (2) :";
            // 
            // cmbSID1
            // 
            this.cmbSID1.FormattingEnabled = true;
            this.cmbSID1.Location = new System.Drawing.Point(710, 92);
            this.cmbSID1.Name = "cmbSID1";
            this.cmbSID1.Size = new System.Drawing.Size(189, 28);
            this.cmbSID1.TabIndex = 27;
            // 
            // cmbSID2
            // 
            this.cmbSID2.FormattingEnabled = true;
            this.cmbSID2.Location = new System.Drawing.Point(710, 155);
            this.cmbSID2.Name = "cmbSID2";
            this.cmbSID2.Size = new System.Drawing.Size(189, 28);
            this.cmbSID2.TabIndex = 28;
            // 
            // btnSubmitCSM
            // 
            this.btnSubmitCSM.BackColor = System.Drawing.Color.Navy;
            this.btnSubmitCSM.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCSM.Location = new System.Drawing.Point(103, 234);
            this.btnSubmitCSM.Name = "btnSubmitCSM";
            this.btnSubmitCSM.Size = new System.Drawing.Size(122, 42);
            this.btnSubmitCSM.TabIndex = 29;
            this.btnSubmitCSM.Text = "Submit Data";
            this.btnSubmitCSM.UseVisualStyleBackColor = false;
            this.btnSubmitCSM.Click += new System.EventHandler(this.btnSubmitCSM_Click);
            // 
            // BtnEditCSM
            // 
            this.BtnEditCSM.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnEditCSM.ForeColor = System.Drawing.Color.White;
            this.BtnEditCSM.Location = new System.Drawing.Point(320, 234);
            this.BtnEditCSM.Name = "BtnEditCSM";
            this.BtnEditCSM.Size = new System.Drawing.Size(122, 45);
            this.BtnEditCSM.TabIndex = 31;
            this.BtnEditCSM.Text = "Edit Data";
            this.BtnEditCSM.UseVisualStyleBackColor = false;
            this.BtnEditCSM.Click += new System.EventHandler(this.BtnEditCSM_Click);
            // 
            // btnDeleteCSM
            // 
            this.btnDeleteCSM.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCSM.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCSM.Location = new System.Drawing.Point(550, 234);
            this.btnDeleteCSM.Name = "btnDeleteCSM";
            this.btnDeleteCSM.Size = new System.Drawing.Size(116, 47);
            this.btnDeleteCSM.TabIndex = 32;
            this.btnDeleteCSM.Text = "Delete Data";
            this.btnDeleteCSM.UseVisualStyleBackColor = false;
            this.btnDeleteCSM.Click += new System.EventHandler(this.btnDeleteCSM_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(29, 527);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 59);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "Show Session Details";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelCSMData
            // 
            this.panelCSMData.Controls.Add(this.dataGridViewCSMData);
            this.panelCSMData.Location = new System.Drawing.Point(194, 303);
            this.panelCSMData.Name = "panelCSMData";
            this.panelCSMData.Size = new System.Drawing.Size(737, 164);
            this.panelCSMData.TabIndex = 34;
            // 
            // dataGridViewCSMData
            // 
            this.dataGridViewCSMData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSMData.Location = new System.Drawing.Point(22, 8);
            this.dataGridViewCSMData.Name = "dataGridViewCSMData";
            this.dataGridViewCSMData.RowHeadersWidth = 51;
            this.dataGridViewCSMData.RowTemplate.Height = 29;
            this.dataGridViewCSMData.Size = new System.Drawing.Size(715, 145);
            this.dataGridViewCSMData.TabIndex = 4;
            this.dataGridViewCSMData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCSMData_CellContentClick);
            // 
            // labelSubGrCSM
            // 
            this.labelSubGrCSM.AutoSize = true;
            this.labelSubGrCSM.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubGrCSM.ForeColor = System.Drawing.Color.White;
            this.labelSubGrCSM.Location = new System.Drawing.Point(92, 173);
            this.labelSubGrCSM.Name = "labelSubGrCSM";
            this.labelSubGrCSM.Size = new System.Drawing.Size(182, 24);
            this.labelSubGrCSM.TabIndex = 35;
            this.labelSubGrCSM.Text = "SubGroup Number :";
            // 
            // cmbSubGrpNoCSM
            // 
            this.cmbSubGrpNoCSM.FormattingEnabled = true;
            this.cmbSubGrpNoCSM.Location = new System.Drawing.Point(290, 173);
            this.cmbSubGrpNoCSM.Name = "cmbSubGrpNoCSM";
            this.cmbSubGrpNoCSM.Size = new System.Drawing.Size(189, 28);
            this.cmbSubGrpNoCSM.TabIndex = 36;
            // 
            // BtnClearCSM
            // 
            this.BtnClearCSM.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnClearCSM.ForeColor = System.Drawing.Color.White;
            this.BtnClearCSM.Location = new System.Drawing.Point(774, 232);
            this.BtnClearCSM.Name = "BtnClearCSM";
            this.BtnClearCSM.Size = new System.Drawing.Size(116, 47);
            this.BtnClearCSM.TabIndex = 37;
            this.BtnClearCSM.Text = "Clear";
            this.BtnClearCSM.UseVisualStyleBackColor = false;
            this.BtnClearCSM.Click += new System.EventHandler(this.BtnClearCSM_Click_1);
            // 
            // FormConsecutiveSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1005, 686);
            this.Controls.Add(this.BtnClearCSM);
            this.Controls.Add(this.cmbSubGrpNoCSM);
            this.Controls.Add(this.labelSubGrCSM);
            this.Controls.Add(this.panelCSMData);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.btnDeleteCSM);
            this.Controls.Add(this.BtnEditCSM);
            this.Controls.Add(this.btnSubmitCSM);
            this.Controls.Add(this.cmbSID2);
            this.Controls.Add(this.cmbSID1);
            this.Controls.Add(this.labelSessionID2);
            this.Controls.Add(this.labelSessionID1);
            this.Controls.Add(this.cmbGrpNoCSM);
            this.Controls.Add(this.labelGrpNumbrCSM);
            this.Controls.Add(this.cmbSbCodeCSM);
            this.Controls.Add(this.labelSubjectCodeCSM);
            this.Controls.Add(this.labelConsecutiveManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormConsecutiveSessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsecutiveSessions";
            this.Load += new System.EventHandler(this.FormConsecutiveSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.panelCSMData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSMData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsecutiveManagement;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label labelSubjectCodeCSM;
        private System.Windows.Forms.ComboBox cmbSbCodeCSM;
        private System.Windows.Forms.Label labelGrpNumbrCSM;
        private System.Windows.Forms.ComboBox cmbGrpNoCSM;
        private System.Windows.Forms.Label labelSessionID1;
        private System.Windows.Forms.Label labelSessionID2;
        private System.Windows.Forms.ComboBox cmbSID1;
        private System.Windows.Forms.ComboBox cmbSID2;
        private System.Windows.Forms.Button btnSubmitCSM;
        private System.Windows.Forms.Button BtnEditCSM;
        private System.Windows.Forms.Button btnDeleteCSM;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelCSMData;
        private System.Windows.Forms.DataGridView dataGridViewCSMData;
        private System.Windows.Forms.Label labelSubGrCSM;
        private System.Windows.Forms.ComboBox cmbSubGrpNoCSM;
        private System.Windows.Forms.Button BtnClearCSM;
    }
}