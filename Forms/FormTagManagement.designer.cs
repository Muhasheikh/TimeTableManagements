
namespace StudentsAndTagsManagement.Forms
{
    partial class FormTagManagement
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
            this.labelTagManagement = new System.Windows.Forms.Label();
            this.labelTagName = new System.Windows.Forms.Label();
            this.labelTagCode = new System.Windows.Forms.Label();
            this.labelRelatedTag = new System.Windows.Forms.Label();
            this.tgNametxt = new System.Windows.Forms.TextBox();
            this.rltedtagtxt = new System.Windows.Forms.TextBox();
            this.tagcodebx = new System.Windows.Forms.ComboBox();
            this.btnSubmitData = new System.Windows.Forms.Button();
            this.BTNEditData = new System.Windows.Forms.Button();
            this.BTNclearData = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTagManagement
            // 
            this.labelTagManagement.AutoSize = true;
            this.labelTagManagement.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTagManagement.ForeColor = System.Drawing.Color.White;
            this.labelTagManagement.Location = new System.Drawing.Point(357, 27);
            this.labelTagManagement.Name = "labelTagManagement";
            this.labelTagManagement.Size = new System.Drawing.Size(265, 28);
            this.labelTagManagement.TabIndex = 1;
            this.labelTagManagement.Text = "Tags Management";
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTagName.ForeColor = System.Drawing.Color.White;
            this.labelTagName.Location = new System.Drawing.Point(291, 95);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(111, 24);
            this.labelTagName.TabIndex = 2;
            this.labelTagName.Text = "Tag Name  :";
            // 
            // labelTagCode
            // 
            this.labelTagCode.AutoSize = true;
            this.labelTagCode.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTagCode.ForeColor = System.Drawing.Color.White;
            this.labelTagCode.Location = new System.Drawing.Point(291, 151);
            this.labelTagCode.Name = "labelTagCode";
            this.labelTagCode.Size = new System.Drawing.Size(102, 24);
            this.labelTagCode.TabIndex = 3;
            this.labelTagCode.Text = "Tag Code  :";
            // 
            // labelRelatedTag
            // 
            this.labelRelatedTag.AutoSize = true;
            this.labelRelatedTag.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRelatedTag.ForeColor = System.Drawing.Color.White;
            this.labelRelatedTag.Location = new System.Drawing.Point(291, 203);
            this.labelRelatedTag.Name = "labelRelatedTag";
            this.labelRelatedTag.Size = new System.Drawing.Size(125, 24);
            this.labelRelatedTag.TabIndex = 4;
            this.labelRelatedTag.Text = "Related Tag  :";
            // 
            // tgNametxt
            // 
            this.tgNametxt.ForeColor = System.Drawing.Color.Black;
            this.tgNametxt.Location = new System.Drawing.Point(500, 92);
            this.tgNametxt.Name = "tgNametxt";
            this.tgNametxt.Size = new System.Drawing.Size(189, 27);
            this.tgNametxt.TabIndex = 10;
            this.tgNametxt.Text = "Lec";
            // 
            // rltedtagtxt
            // 
            this.rltedtagtxt.ForeColor = System.Drawing.Color.Black;
            this.rltedtagtxt.Location = new System.Drawing.Point(500, 203);
            this.rltedtagtxt.Name = "rltedtagtxt";
            this.rltedtagtxt.Size = new System.Drawing.Size(189, 27);
            this.rltedtagtxt.TabIndex = 12;
            this.rltedtagtxt.Text = "Lecture";
            // 
            // tagcodebx
            // 
            this.tagcodebx.FormattingEnabled = true;
            this.tagcodebx.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 "});
            this.tagcodebx.Location = new System.Drawing.Point(500, 147);
            this.tagcodebx.Name = "tagcodebx";
            this.tagcodebx.Size = new System.Drawing.Size(189, 28);
            this.tagcodebx.TabIndex = 13;
            // 
            // btnSubmitData
            // 
            this.btnSubmitData.BackColor = System.Drawing.Color.Navy;
            this.btnSubmitData.ForeColor = System.Drawing.Color.White;
            this.btnSubmitData.Location = new System.Drawing.Point(182, 269);
            this.btnSubmitData.Name = "btnSubmitData";
            this.btnSubmitData.Size = new System.Drawing.Size(122, 42);
            this.btnSubmitData.TabIndex = 14;
            this.btnSubmitData.Text = "Submit Data";
            this.btnSubmitData.UseVisualStyleBackColor = false;
            this.btnSubmitData.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BTNEditData
            // 
            this.BTNEditData.BackColor = System.Drawing.Color.DarkGreen;
            this.BTNEditData.ForeColor = System.Drawing.Color.White;
            this.BTNEditData.Location = new System.Drawing.Point(533, 269);
            this.BTNEditData.Name = "BTNEditData";
            this.BTNEditData.Size = new System.Drawing.Size(122, 42);
            this.BTNEditData.TabIndex = 15;
            this.BTNEditData.Text = "Edit Data";
            this.BTNEditData.UseVisualStyleBackColor = false;
            this.BTNEditData.Click += new System.EventHandler(this.BTNEditData_Click);
            // 
            // BTNclearData
            // 
            this.BTNclearData.BackColor = System.Drawing.Color.Indigo;
            this.BTNclearData.ForeColor = System.Drawing.Color.White;
            this.BTNclearData.Location = new System.Drawing.Point(357, 269);
            this.BTNclearData.Name = "BTNclearData";
            this.BTNclearData.Size = new System.Drawing.Size(122, 42);
            this.BTNclearData.TabIndex = 16;
            this.BTNclearData.Text = "Clear Data";
            this.BTNclearData.UseVisualStyleBackColor = false;
            this.BTNclearData.Click += new System.EventHandler(this.BTNclearData_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.BackColor = System.Drawing.Color.DarkRed;
            this.BTNdelete.ForeColor = System.Drawing.Color.White;
            this.BTNdelete.Location = new System.Drawing.Point(719, 269);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(122, 42);
            this.BTNdelete.TabIndex = 17;
            this.BTNdelete.Text = "Delete Data";
            this.BTNdelete.UseVisualStyleBackColor = false;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(182, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(599, 147);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // FormTagManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1013, 623);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNclearData);
            this.Controls.Add(this.BTNEditData);
            this.Controls.Add(this.btnSubmitData);
            this.Controls.Add(this.tagcodebx);
            this.Controls.Add(this.rltedtagtxt);
            this.Controls.Add(this.tgNametxt);
            this.Controls.Add(this.labelRelatedTag);
            this.Controls.Add(this.labelTagCode);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.labelTagManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormTagManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTagManagement";
            this.Load += new System.EventHandler(this.FormTagManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTagManagement;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.Label labelTagCode;
        private System.Windows.Forms.Label labelRelatedTag;
        private System.Windows.Forms.TextBox tgNametxt;
        private System.Windows.Forms.TextBox rltedtagtxt;
        private System.Windows.Forms.ComboBox tagcodebx;
        private System.Windows.Forms.Button btnSubmitData;
        private System.Windows.Forms.Button BTNEditData;
        private System.Windows.Forms.Button BTNclearData;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}