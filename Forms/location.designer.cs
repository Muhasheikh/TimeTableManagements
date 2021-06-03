namespace dhara
{
    partial class location
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tcap = new System.Windows.Forms.NumericUpDown();
            this.txtroom = new System.Windows.Forms.ComboBox();
            this.txtfloor = new System.Windows.Forms.ComboBox();
            this.txtbuild = new System.Windows.Forms.ComboBox();
            this.txttype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tcap)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(613, 532);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(387, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location Management";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Orange;
            this.btnView.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(801, 532);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(180, 75);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(383, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(404, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(383, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(385, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Floor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(383, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Room Type:";
            // 
            // tcap
            // 
            this.tcap.Location = new System.Drawing.Point(581, 345);
            this.tcap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcap.Name = "tcap";
            this.tcap.Size = new System.Drawing.Size(160, 27);
            this.tcap.TabIndex = 13;
            this.tcap.ValueChanged += new System.EventHandler(this.txtcapacity_ValueChanged);
            // 
            // txtroom
            // 
            this.txtroom.FormattingEnabled = true;
            this.txtroom.Items.AddRange(new object[] {
            "402",
            "401",
            "403",
            "303",
            "301",
            "G1 ",
            "G2"});
            this.txtroom.Location = new System.Drawing.Point(581, 283);
            this.txtroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(160, 28);
            this.txtroom.TabIndex = 19;
            // 
            // txtfloor
            // 
            this.txtfloor.FormattingEnabled = true;
            this.txtfloor.Items.AddRange(new object[] {
            "Basement",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtfloor.Location = new System.Drawing.Point(581, 223);
            this.txtfloor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfloor.Name = "txtfloor";
            this.txtfloor.Size = new System.Drawing.Size(160, 28);
            this.txtfloor.TabIndex = 20;
            this.txtfloor.SelectedIndexChanged += new System.EventHandler(this.txtfloor_SelectedIndexChanged);
            // 
            // txtbuild
            // 
            this.txtbuild.FormattingEnabled = true;
            this.txtbuild.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Management",
            "Engineering"});
            this.txtbuild.Location = new System.Drawing.Point(580, 172);
            this.txtbuild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuild.Name = "txtbuild";
            this.txtbuild.Size = new System.Drawing.Size(160, 28);
            this.txtbuild.TabIndex = 24;
            // 
            // txttype
            // 
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "Lecture Room",
            "Laboratory"});
            this.txttype.Location = new System.Drawing.Point(581, 402);
            this.txttype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(160, 28);
            this.txttype.TabIndex = 25;
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 754);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtbuild);
            this.Controls.Add(this.txtfloor);
            this.Controls.Add(this.txtroom);
            this.Controls.Add(this.tcap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tcap;
        private System.Windows.Forms.ComboBox txtroom;
        private System.Windows.Forms.ComboBox txtfloor;
        private System.Windows.Forms.ComboBox txtbuild;
        private System.Windows.Forms.ComboBox txttype;
    }
}

