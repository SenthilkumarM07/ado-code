namespace ado_practice
{
    partial class sp_update
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
            this.lblSpUpdateID = new System.Windows.Forms.Label();
            this.cmbSpUpdateId = new System.Windows.Forms.ComboBox();
            this.btnSpUpdateSubmit = new System.Windows.Forms.Button();
            this.cmbSpUpdateCity = new System.Windows.Forms.ComboBox();
            this.txtSpUpdateAge = new System.Windows.Forms.TextBox();
            this.txtSpUpdateDept = new System.Windows.Forms.TextBox();
            this.txtSpUpdateCollege = new System.Windows.Forms.TextBox();
            this.txtSpUpdateName = new System.Windows.Forms.TextBox();
            this.lblSpUpdateCity = new System.Windows.Forms.Label();
            this.lblSpUpdateCollege = new System.Windows.Forms.Label();
            this.lblSpUpdateDept = new System.Windows.Forms.Label();
            this.lblSpUpdateAge = new System.Windows.Forms.Label();
            this.lblSpUpdateName = new System.Windows.Forms.Label();
            this.lnkSpUpdateBack = new System.Windows.Forms.LinkLabel();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRegister.Controls.Add(this.lblSpUpdateID);
            this.pnlRegister.Controls.Add(this.cmbSpUpdateId);
            this.pnlRegister.Controls.Add(this.btnSpUpdateSubmit);
            this.pnlRegister.Controls.Add(this.cmbSpUpdateCity);
            this.pnlRegister.Controls.Add(this.txtSpUpdateAge);
            this.pnlRegister.Controls.Add(this.txtSpUpdateDept);
            this.pnlRegister.Controls.Add(this.txtSpUpdateCollege);
            this.pnlRegister.Controls.Add(this.txtSpUpdateName);
            this.pnlRegister.Controls.Add(this.lblSpUpdateCity);
            this.pnlRegister.Controls.Add(this.lblSpUpdateCollege);
            this.pnlRegister.Controls.Add(this.lblSpUpdateDept);
            this.pnlRegister.Controls.Add(this.lblSpUpdateAge);
            this.pnlRegister.Controls.Add(this.lblSpUpdateName);
            this.pnlRegister.Location = new System.Drawing.Point(318, 2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(257, 351);
            this.pnlRegister.TabIndex = 2;
            // 
            // lblSpUpdateID
            // 
            this.lblSpUpdateID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpUpdateID.AutoSize = true;
            this.lblSpUpdateID.Location = new System.Drawing.Point(38, 31);
            this.lblSpUpdateID.Name = "lblSpUpdateID";
            this.lblSpUpdateID.Size = new System.Drawing.Size(18, 13);
            this.lblSpUpdateID.TabIndex = 13;
            this.lblSpUpdateID.Text = "ID";
            // 
            // cmbSpUpdateId
            // 
            this.cmbSpUpdateId.FormattingEnabled = true;
            this.cmbSpUpdateId.Location = new System.Drawing.Point(113, 23);
            this.cmbSpUpdateId.Name = "cmbSpUpdateId";
            this.cmbSpUpdateId.Size = new System.Drawing.Size(100, 21);
            this.cmbSpUpdateId.TabIndex = 12;
            this.cmbSpUpdateId.SelectedIndexChanged += new System.EventHandler(this.cmbSpUpdateId_SelectedIndexChanged);
            // 
            // btnSpUpdateSubmit
            // 
            this.btnSpUpdateSubmit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSpUpdateSubmit.Location = new System.Drawing.Point(87, 307);
            this.btnSpUpdateSubmit.Name = "btnSpUpdateSubmit";
            this.btnSpUpdateSubmit.Size = new System.Drawing.Size(102, 25);
            this.btnSpUpdateSubmit.TabIndex = 11;
            this.btnSpUpdateSubmit.Text = "SP__UPDATE";
            this.btnSpUpdateSubmit.UseVisualStyleBackColor = false;
            this.btnSpUpdateSubmit.Click += new System.EventHandler(this.btnSpUpdateSubmit_Click);
            // 
            // cmbSpUpdateCity
            // 
            this.cmbSpUpdateCity.FormattingEnabled = true;
            this.cmbSpUpdateCity.Items.AddRange(new object[] {
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
            this.cmbSpUpdateCity.Location = new System.Drawing.Point(113, 248);
            this.cmbSpUpdateCity.Name = "cmbSpUpdateCity";
            this.cmbSpUpdateCity.Size = new System.Drawing.Size(100, 21);
            this.cmbSpUpdateCity.TabIndex = 10;
            // 
            // txtSpUpdateAge
            // 
            this.txtSpUpdateAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpUpdateAge.Location = new System.Drawing.Point(113, 104);
            this.txtSpUpdateAge.Name = "txtSpUpdateAge";
            this.txtSpUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.txtSpUpdateAge.TabIndex = 9;
            // 
            // txtSpUpdateDept
            // 
            this.txtSpUpdateDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpUpdateDept.Location = new System.Drawing.Point(113, 149);
            this.txtSpUpdateDept.Name = "txtSpUpdateDept";
            this.txtSpUpdateDept.Size = new System.Drawing.Size(100, 20);
            this.txtSpUpdateDept.TabIndex = 8;
            // 
            // txtSpUpdateCollege
            // 
            this.txtSpUpdateCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpUpdateCollege.Location = new System.Drawing.Point(113, 201);
            this.txtSpUpdateCollege.Name = "txtSpUpdateCollege";
            this.txtSpUpdateCollege.Size = new System.Drawing.Size(100, 20);
            this.txtSpUpdateCollege.TabIndex = 6;
            // 
            // txtSpUpdateName
            // 
            this.txtSpUpdateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpUpdateName.Location = new System.Drawing.Point(113, 62);
            this.txtSpUpdateName.Name = "txtSpUpdateName";
            this.txtSpUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtSpUpdateName.TabIndex = 5;
            // 
            // lblSpUpdateCity
            // 
            this.lblSpUpdateCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpUpdateCity.AutoSize = true;
            this.lblSpUpdateCity.Location = new System.Drawing.Point(43, 256);
            this.lblSpUpdateCity.Name = "lblSpUpdateCity";
            this.lblSpUpdateCity.Size = new System.Drawing.Size(31, 13);
            this.lblSpUpdateCity.TabIndex = 4;
            this.lblSpUpdateCity.Text = "CITY";
            // 
            // lblSpUpdateCollege
            // 
            this.lblSpUpdateCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpUpdateCollege.AutoSize = true;
            this.lblSpUpdateCollege.Location = new System.Drawing.Point(38, 204);
            this.lblSpUpdateCollege.Name = "lblSpUpdateCollege";
            this.lblSpUpdateCollege.Size = new System.Drawing.Size(56, 13);
            this.lblSpUpdateCollege.TabIndex = 3;
            this.lblSpUpdateCollege.Text = "COLLEGE";
            // 
            // lblSpUpdateDept
            // 
            this.lblSpUpdateDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpUpdateDept.AutoSize = true;
            this.lblSpUpdateDept.Location = new System.Drawing.Point(38, 156);
            this.lblSpUpdateDept.Name = "lblSpUpdateDept";
            this.lblSpUpdateDept.Size = new System.Drawing.Size(36, 13);
            this.lblSpUpdateDept.TabIndex = 2;
            this.lblSpUpdateDept.Text = "DEPT";
            // 
            // lblSpUpdateAge
            // 
            this.lblSpUpdateAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpUpdateAge.AutoSize = true;
            this.lblSpUpdateAge.Location = new System.Drawing.Point(38, 111);
            this.lblSpUpdateAge.Name = "lblSpUpdateAge";
            this.lblSpUpdateAge.Size = new System.Drawing.Size(29, 13);
            this.lblSpUpdateAge.TabIndex = 1;
            this.lblSpUpdateAge.Text = "AGE";
            // 
            // lblSpUpdateName
            // 
            this.lblSpUpdateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpUpdateName.AutoSize = true;
            this.lblSpUpdateName.Location = new System.Drawing.Point(36, 69);
            this.lblSpUpdateName.Name = "lblSpUpdateName";
            this.lblSpUpdateName.Size = new System.Drawing.Size(38, 13);
            this.lblSpUpdateName.TabIndex = 0;
            this.lblSpUpdateName.Text = "NAME";
            // 
            // lnkSpUpdateBack
            // 
            this.lnkSpUpdateBack.AutoSize = true;
            this.lnkSpUpdateBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSpUpdateBack.Location = new System.Drawing.Point(715, 25);
            this.lnkSpUpdateBack.Name = "lnkSpUpdateBack";
            this.lnkSpUpdateBack.Size = new System.Drawing.Size(88, 31);
            this.lnkSpUpdateBack.TabIndex = 3;
            this.lnkSpUpdateBack.TabStop = true;
            this.lnkSpUpdateBack.Text = "BACK";
            this.lnkSpUpdateBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSpUpdateBack_LinkClicked);
            // 
            // sp_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 354);
            this.Controls.Add(this.lnkSpUpdateBack);
            this.Controls.Add(this.pnlRegister);
            this.Name = "sp_update";
            this.Text = "sp_update";
            this.Load += new System.EventHandler(this.sp_update_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblSpUpdateID;
        private System.Windows.Forms.ComboBox cmbSpUpdateId;
        private System.Windows.Forms.Button btnSpUpdateSubmit;
        private System.Windows.Forms.ComboBox cmbSpUpdateCity;
        private System.Windows.Forms.TextBox txtSpUpdateAge;
        private System.Windows.Forms.TextBox txtSpUpdateDept;
        private System.Windows.Forms.TextBox txtSpUpdateCollege;
        private System.Windows.Forms.TextBox txtSpUpdateName;
        private System.Windows.Forms.Label lblSpUpdateCity;
        private System.Windows.Forms.Label lblSpUpdateCollege;
        private System.Windows.Forms.Label lblSpUpdateDept;
        private System.Windows.Forms.Label lblSpUpdateAge;
        private System.Windows.Forms.Label lblSpUpdateName;
        private System.Windows.Forms.LinkLabel lnkSpUpdateBack;

    }
}