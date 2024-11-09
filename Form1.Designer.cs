namespace ado_practice
{
    partial class Form1
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
            this.btnRegSubmit = new System.Windows.Forms.Button();
            this.cmbRegCity = new System.Windows.Forms.ComboBox();
            this.txtRegAge = new System.Windows.Forms.TextBox();
            this.txtRegDept = new System.Windows.Forms.TextBox();
            this.txtRegCollege = new System.Windows.Forms.TextBox();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.lblRegCity = new System.Windows.Forms.Label();
            this.lblRegCollege = new System.Windows.Forms.Label();
            this.lblRegDept = new System.Windows.Forms.Label();
            this.lblRegAge = new System.Windows.Forms.Label();
            this.lblRegName = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelName = new System.Windows.Forms.TextBox();
            this.lblDelName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.pnlProcedure = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProInsert = new System.Windows.Forms.Button();
            this.btnProDelete = new System.Windows.Forms.Button();
            this.btnProSelect = new System.Windows.Forms.Button();
            this.btnProUpdate = new System.Windows.Forms.Button();
            this.lnlProcedure = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnTwoTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRegister.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlProcedure.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegister.Controls.Add(this.btnRegSubmit);
            this.pnlRegister.Controls.Add(this.cmbRegCity);
            this.pnlRegister.Controls.Add(this.txtRegAge);
            this.pnlRegister.Controls.Add(this.txtRegDept);
            this.pnlRegister.Controls.Add(this.txtRegCollege);
            this.pnlRegister.Controls.Add(this.txtRegName);
            this.pnlRegister.Controls.Add(this.lblRegCity);
            this.pnlRegister.Controls.Add(this.lblRegCollege);
            this.pnlRegister.Controls.Add(this.lblRegDept);
            this.pnlRegister.Controls.Add(this.lblRegAge);
            this.pnlRegister.Controls.Add(this.lblRegName);
            this.pnlRegister.Location = new System.Drawing.Point(12, 56);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(257, 336);
            this.pnlRegister.TabIndex = 0;
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // btnRegSubmit
            // 
            this.btnRegSubmit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRegSubmit.Location = new System.Drawing.Point(87, 276);
            this.btnRegSubmit.Name = "btnRegSubmit";
            this.btnRegSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnRegSubmit.TabIndex = 11;
            this.btnRegSubmit.Text = "SUBMIT";
            this.btnRegSubmit.UseVisualStyleBackColor = false;
            this.btnRegSubmit.Click += new System.EventHandler(this.btnRegSubmit_Click);
            // 
            // cmbRegCity
            // 
            this.cmbRegCity.FormattingEnabled = true;
            this.cmbRegCity.Items.AddRange(new object[] {
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
            this.cmbRegCity.Location = new System.Drawing.Point(113, 215);
            this.cmbRegCity.Name = "cmbRegCity";
            this.cmbRegCity.Size = new System.Drawing.Size(100, 21);
            this.cmbRegCity.TabIndex = 10;
            this.cmbRegCity.SelectedIndexChanged += new System.EventHandler(this.cmbRegCity_SelectedIndexChanged);
            // 
            // txtRegAge
            // 
            this.txtRegAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegAge.Location = new System.Drawing.Point(113, 71);
            this.txtRegAge.Name = "txtRegAge";
            this.txtRegAge.Size = new System.Drawing.Size(100, 20);
            this.txtRegAge.TabIndex = 9;
            // 
            // txtRegDept
            // 
            this.txtRegDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegDept.Location = new System.Drawing.Point(113, 119);
            this.txtRegDept.Name = "txtRegDept";
            this.txtRegDept.Size = new System.Drawing.Size(100, 20);
            this.txtRegDept.TabIndex = 8;
            // 
            // txtRegCollege
            // 
            this.txtRegCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegCollege.Location = new System.Drawing.Point(113, 161);
            this.txtRegCollege.Name = "txtRegCollege";
            this.txtRegCollege.Size = new System.Drawing.Size(100, 20);
            this.txtRegCollege.TabIndex = 6;
            // 
            // txtRegName
            // 
            this.txtRegName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegName.Location = new System.Drawing.Point(113, 34);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(100, 20);
            this.txtRegName.TabIndex = 5;
            this.txtRegName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRegCity
            // 
            this.lblRegCity.AutoSize = true;
            this.lblRegCity.Location = new System.Drawing.Point(38, 218);
            this.lblRegCity.Name = "lblRegCity";
            this.lblRegCity.Size = new System.Drawing.Size(31, 13);
            this.lblRegCity.TabIndex = 4;
            this.lblRegCity.Text = "CITY";
            // 
            // lblRegCollege
            // 
            this.lblRegCollege.AutoSize = true;
            this.lblRegCollege.Location = new System.Drawing.Point(38, 168);
            this.lblRegCollege.Name = "lblRegCollege";
            this.lblRegCollege.Size = new System.Drawing.Size(56, 13);
            this.lblRegCollege.TabIndex = 3;
            this.lblRegCollege.Text = "COLLEGE";
            // 
            // lblRegDept
            // 
            this.lblRegDept.AutoSize = true;
            this.lblRegDept.Location = new System.Drawing.Point(38, 119);
            this.lblRegDept.Name = "lblRegDept";
            this.lblRegDept.Size = new System.Drawing.Size(36, 13);
            this.lblRegDept.TabIndex = 2;
            this.lblRegDept.Text = "DEPT";
            // 
            // lblRegAge
            // 
            this.lblRegAge.AutoSize = true;
            this.lblRegAge.Location = new System.Drawing.Point(38, 78);
            this.lblRegAge.Name = "lblRegAge";
            this.lblRegAge.Size = new System.Drawing.Size(29, 13);
            this.lblRegAge.TabIndex = 1;
            this.lblRegAge.Text = "AGE";
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(38, 34);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(38, 13);
            this.lblRegName.TabIndex = 0;
            this.lblRegName.Text = "NAME";
            this.lblRegName.Click += new System.EventHandler(this.lblRegName_Click);
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegister.Location = new System.Drawing.Point(86, 19);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(93, 20);
            this.lnkRegister.TabIndex = 1;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "REGISTER";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Controls.Add(this.txtDelName);
            this.pnlDelete.Controls.Add(this.lblDelName);
            this.pnlDelete.Location = new System.Drawing.Point(294, 56);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(219, 121);
            this.pnlDelete.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDelete.Location = new System.Drawing.Point(77, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelName
            // 
            this.txtDelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDelName.Location = new System.Drawing.Point(102, 27);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(100, 20);
            this.txtDelName.TabIndex = 12;
            this.txtDelName.TextChanged += new System.EventHandler(this.txtDelName_TextChanged);
            // 
            // lblDelName
            // 
            this.lblDelName.AutoSize = true;
            this.lblDelName.Location = new System.Drawing.Point(29, 34);
            this.lblDelName.Name = "lblDelName";
            this.lblDelName.Size = new System.Drawing.Size(38, 13);
            this.lblDelName.TabIndex = 12;
            this.lblDelName.Text = "NAME";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(331, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DELETE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnShowAll.Location = new System.Drawing.Point(12, 412);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 25);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "SHOWALL";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // pnlProcedure
            // 
            this.pnlProcedure.Controls.Add(this.button2);
            this.pnlProcedure.Controls.Add(this.btnProInsert);
            this.pnlProcedure.Controls.Add(this.btnProDelete);
            this.pnlProcedure.Controls.Add(this.btnProSelect);
            this.pnlProcedure.Controls.Add(this.btnProUpdate);
            this.pnlProcedure.Location = new System.Drawing.Point(294, 224);
            this.pnlProcedure.Name = "pnlProcedure";
            this.pnlProcedure.Size = new System.Drawing.Size(234, 166);
            this.pnlProcedure.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(77, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "SP_SELECT_COL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProInsert
            // 
            this.btnProInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnProInsert.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnProInsert.Location = new System.Drawing.Point(77, 15);
            this.btnProInsert.Name = "btnProInsert";
            this.btnProInsert.Size = new System.Drawing.Size(80, 25);
            this.btnProInsert.TabIndex = 15;
            this.btnProInsert.Text = "SP_INSERT";
            this.btnProInsert.UseVisualStyleBackColor = false;
            this.btnProInsert.Click += new System.EventHandler(this.btnProInsert_Click);
            // 
            // btnProDelete
            // 
            this.btnProDelete.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnProDelete.Location = new System.Drawing.Point(77, 47);
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(80, 25);
            this.btnProDelete.TabIndex = 14;
            this.btnProDelete.Text = "SP_DELETE";
            this.btnProDelete.UseVisualStyleBackColor = false;
            this.btnProDelete.Click += new System.EventHandler(this.btnProDelete_Click);
            // 
            // btnProSelect
            // 
            this.btnProSelect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProSelect.Location = new System.Drawing.Point(77, 109);
            this.btnProSelect.Name = "btnProSelect";
            this.btnProSelect.Size = new System.Drawing.Size(80, 25);
            this.btnProSelect.TabIndex = 13;
            this.btnProSelect.Text = "SP_SELECT";
            this.btnProSelect.UseVisualStyleBackColor = false;
            this.btnProSelect.Click += new System.EventHandler(this.btnProSelect_Click);
            // 
            // btnProUpdate
            // 
            this.btnProUpdate.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnProUpdate.Location = new System.Drawing.Point(77, 78);
            this.btnProUpdate.Name = "btnProUpdate";
            this.btnProUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnProUpdate.TabIndex = 12;
            this.btnProUpdate.Text = "SP_UPDATE";
            this.btnProUpdate.UseVisualStyleBackColor = false;
            this.btnProUpdate.Click += new System.EventHandler(this.btnProUpdate_Click);
            // 
            // lnlProcedure
            // 
            this.lnlProcedure.AutoSize = true;
            this.lnlProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlProcedure.Location = new System.Drawing.Point(331, 201);
            this.lnlProcedure.Name = "lnlProcedure";
            this.lnlProcedure.Size = new System.Drawing.Size(112, 20);
            this.lnlProcedure.TabIndex = 14;
            this.lnlProcedure.TabStop = true;
            this.lnlProcedure.Text = "PROCEDURE";
            this.lnlProcedure.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlProcedure_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(609, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 20);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "UPDATE";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnTwoTable
            // 
            this.btnTwoTable.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnTwoTable.Location = new System.Drawing.Point(125, 412);
            this.btnTwoTable.Name = "btnTwoTable";
            this.btnTwoTable.Size = new System.Drawing.Size(85, 25);
            this.btnTwoTable.TabIndex = 17;
            this.btnTwoTable.Text = "TWO_TABLE";
            this.btnTwoTable.UseVisualStyleBackColor = false;
            this.btnTwoTable.Click += new System.EventHandler(this.btnTwoTable_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(242, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "TIRE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTwoTable);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lnlProcedure);
            this.Controls.Add(this.pnlProcedure);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.pnlRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.pnlProcedure.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.ComboBox cmbRegCity;
        private System.Windows.Forms.TextBox txtRegAge;
        private System.Windows.Forms.TextBox txtRegDept;
        private System.Windows.Forms.TextBox txtRegCollege;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Label lblRegCity;
        private System.Windows.Forms.Label lblRegCollege;
        private System.Windows.Forms.Label lblRegDept;
        private System.Windows.Forms.Label lblRegAge;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Button btnRegSubmit;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Label lblDelName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel pnlProcedure;
        private System.Windows.Forms.Button btnProInsert;
        private System.Windows.Forms.Button btnProDelete;
        private System.Windows.Forms.Button btnProSelect;
        private System.Windows.Forms.Button btnProUpdate;
        private System.Windows.Forms.LinkLabel lnlProcedure;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTwoTable;
        private System.Windows.Forms.Button button1;
    }
}

