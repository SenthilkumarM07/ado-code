namespace ado_practice
{
    partial class update
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
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUpdateId = new System.Windows.Forms.ComboBox();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.cmbUpdateCity = new System.Windows.Forms.ComboBox();
            this.txtUpdateAge = new System.Windows.Forms.TextBox();
            this.txtUpdateDept = new System.Windows.Forms.TextBox();
            this.txtUpdateCollege = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblRegCity = new System.Windows.Forms.Label();
            this.lblRegCollege = new System.Windows.Forms.Label();
            this.lblRegDept = new System.Windows.Forms.Label();
            this.lblRegAge = new System.Windows.Forms.Label();
            this.lblRegName = new System.Windows.Forms.Label();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.cmbUpdateId);
            this.pnlRegister.Controls.Add(this.btnUpdateSubmit);
            this.pnlRegister.Controls.Add(this.cmbUpdateCity);
            this.pnlRegister.Controls.Add(this.txtUpdateAge);
            this.pnlRegister.Controls.Add(this.txtUpdateDept);
            this.pnlRegister.Controls.Add(this.txtUpdateCollege);
            this.pnlRegister.Controls.Add(this.txtUpdateName);
            this.pnlRegister.Controls.Add(this.lblRegCity);
            this.pnlRegister.Controls.Add(this.lblRegCollege);
            this.pnlRegister.Controls.Add(this.lblRegDept);
            this.pnlRegister.Controls.Add(this.lblRegAge);
            this.pnlRegister.Controls.Add(this.lblRegName);
            this.pnlRegister.Location = new System.Drawing.Point(323, 12);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(257, 351);
            this.pnlRegister.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // cmbUpdateId
            // 
            this.cmbUpdateId.FormattingEnabled = true;
            this.cmbUpdateId.Location = new System.Drawing.Point(113, 23);
            this.cmbUpdateId.Name = "cmbUpdateId";
            this.cmbUpdateId.Size = new System.Drawing.Size(100, 21);
            this.cmbUpdateId.TabIndex = 12;
            this.cmbUpdateId.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateID_SelectedIndexChanged);
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnUpdateSubmit.Location = new System.Drawing.Point(87, 307);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnUpdateSubmit.TabIndex = 11;
            this.btnUpdateSubmit.Text = "UPDATE";
            this.btnUpdateSubmit.UseVisualStyleBackColor = false;
            this.btnUpdateSubmit.Click += new System.EventHandler(this.btnUpdateSubmit_Click);
            // 
            // cmbUpdateCity
            // 
            this.cmbUpdateCity.FormattingEnabled = true;
            this.cmbUpdateCity.Items.AddRange(new object[] {
            "chennai",
            "madurai",
            "selam",
            "arakkonam",
            "vellore",
            "kanchipuram",
            "tanjavur",
            "kallakurachi",
            "tirivallur",
            "tiruttani"});
            this.cmbUpdateCity.Location = new System.Drawing.Point(113, 248);
            this.cmbUpdateCity.Name = "cmbUpdateCity";
            this.cmbUpdateCity.Size = new System.Drawing.Size(100, 21);
            this.cmbUpdateCity.TabIndex = 10;
            // 
            // txtUpdateAge
            // 
            this.txtUpdateAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateAge.Location = new System.Drawing.Point(113, 104);
            this.txtUpdateAge.Name = "txtUpdateAge";
            this.txtUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAge.TabIndex = 9;
            // 
            // txtUpdateDept
            // 
            this.txtUpdateDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateDept.Location = new System.Drawing.Point(113, 149);
            this.txtUpdateDept.Name = "txtUpdateDept";
            this.txtUpdateDept.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDept.TabIndex = 8;
            // 
            // txtUpdateCollege
            // 
            this.txtUpdateCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateCollege.Location = new System.Drawing.Point(113, 201);
            this.txtUpdateCollege.Name = "txtUpdateCollege";
            this.txtUpdateCollege.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCollege.TabIndex = 6;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateName.Location = new System.Drawing.Point(113, 62);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateName.TabIndex = 5;
            // 
            // lblRegCity
            // 
            this.lblRegCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegCity.AutoSize = true;
            this.lblRegCity.Location = new System.Drawing.Point(43, 256);
            this.lblRegCity.Name = "lblRegCity";
            this.lblRegCity.Size = new System.Drawing.Size(31, 13);
            this.lblRegCity.TabIndex = 4;
            this.lblRegCity.Text = "CITY";
            // 
            // lblRegCollege
            // 
            this.lblRegCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegCollege.AutoSize = true;
            this.lblRegCollege.Location = new System.Drawing.Point(38, 204);
            this.lblRegCollege.Name = "lblRegCollege";
            this.lblRegCollege.Size = new System.Drawing.Size(56, 13);
            this.lblRegCollege.TabIndex = 3;
            this.lblRegCollege.Text = "COLLEGE";
            // 
            // lblRegDept
            // 
            this.lblRegDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegDept.AutoSize = true;
            this.lblRegDept.Location = new System.Drawing.Point(38, 156);
            this.lblRegDept.Name = "lblRegDept";
            this.lblRegDept.Size = new System.Drawing.Size(36, 13);
            this.lblRegDept.TabIndex = 2;
            this.lblRegDept.Text = "DEPT";
            // 
            // lblRegAge
            // 
            this.lblRegAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegAge.AutoSize = true;
            this.lblRegAge.Location = new System.Drawing.Point(38, 111);
            this.lblRegAge.Name = "lblRegAge";
            this.lblRegAge.Size = new System.Drawing.Size(29, 13);
            this.lblRegAge.TabIndex = 1;
            this.lblRegAge.Text = "AGE";
            // 
            // lblRegName
            // 
            this.lblRegName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(36, 69);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(38, 13);
            this.lblRegName.TabIndex = 0;
            this.lblRegName.Text = "NAME";
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpdate.Location = new System.Drawing.Point(730, 35);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(88, 31);
            this.lnkUpdate.TabIndex = 2;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "BACK";
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 367);
            this.Controls.Add(this.lnkUpdate);
            this.Controls.Add(this.pnlRegister);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnUpdateSubmit;
        private System.Windows.Forms.ComboBox cmbUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateAge;
        private System.Windows.Forms.TextBox txtUpdateDept;
        private System.Windows.Forms.TextBox txtUpdateCollege;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblRegCity;
        private System.Windows.Forms.Label lblRegCollege;
        private System.Windows.Forms.Label lblRegDept;
        private System.Windows.Forms.Label lblRegAge;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUpdateId;
        private System.Windows.Forms.LinkLabel lnkUpdate;
    }
}