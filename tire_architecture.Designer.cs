namespace ado_practice
{
    partial class tire_architecture
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
            this.dgvTire = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlTire = new System.Windows.Forms.Panel();
            this.btnTireInsert = new System.Windows.Forms.Button();
            this.txtTirePassword = new System.Windows.Forms.TextBox();
            this.txtTireMailId = new System.Windows.Forms.TextBox();
            this.txtTireUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTireUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTireDelUserName = new System.Windows.Forms.TextBox();
            this.lblTiredelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTireSearch = new System.Windows.Forms.Button();
            this.txtTireID = new System.Windows.Forms.TextBox();
            this.lblTireId = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.cmbTireUpdateId = new System.Windows.Forms.ComboBox();
            this.lblTireUpdateID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTireUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtTireUpdateMailId = new System.Windows.Forms.TextBox();
            this.txtTireUpdateName = new System.Windows.Forms.TextBox();
            this.lblTireUpdatePassword = new System.Windows.Forms.Label();
            this.lblTireUpdateMailId = new System.Windows.Forms.Label();
            this.lblTireUpdateName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTire)).BeginInit();
            this.pnlTire.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTire
            // 
            this.dgvTire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTire.Location = new System.Drawing.Point(557, 120);
            this.dgvTire.Name = "dgvTire";
            this.dgvTire.Size = new System.Drawing.Size(309, 315);
            this.dgvTire.TabIndex = 0;
            this.dgvTire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTire_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(562, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BACK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlTire
            // 
            this.pnlTire.Controls.Add(this.btnTireInsert);
            this.pnlTire.Controls.Add(this.txtTirePassword);
            this.pnlTire.Controls.Add(this.txtTireMailId);
            this.pnlTire.Controls.Add(this.txtTireUserName);
            this.pnlTire.Controls.Add(this.label3);
            this.pnlTire.Controls.Add(this.label2);
            this.pnlTire.Controls.Add(this.label1);
            this.pnlTire.Location = new System.Drawing.Point(12, 12);
            this.pnlTire.Name = "pnlTire";
            this.pnlTire.Size = new System.Drawing.Size(263, 269);
            this.pnlTire.TabIndex = 2;
            this.pnlTire.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTire_Paint);
            // 
            // btnTireInsert
            // 
            this.btnTireInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTireInsert.Location = new System.Drawing.Point(94, 224);
            this.btnTireInsert.Name = "btnTireInsert";
            this.btnTireInsert.Size = new System.Drawing.Size(75, 23);
            this.btnTireInsert.TabIndex = 6;
            this.btnTireInsert.Text = "INSERT";
            this.btnTireInsert.UseVisualStyleBackColor = false;
            this.btnTireInsert.Click += new System.EventHandler(this.btnTireSubmit_Click);
            // 
            // txtTirePassword
            // 
            this.txtTirePassword.Location = new System.Drawing.Point(134, 168);
            this.txtTirePassword.Name = "txtTirePassword";
            this.txtTirePassword.Size = new System.Drawing.Size(100, 20);
            this.txtTirePassword.TabIndex = 5;
            this.txtTirePassword.TextChanged += new System.EventHandler(this.txtTirePassword_TextChanged);
            // 
            // txtTireMailId
            // 
            this.txtTireMailId.Location = new System.Drawing.Point(134, 101);
            this.txtTireMailId.Name = "txtTireMailId";
            this.txtTireMailId.Size = new System.Drawing.Size(100, 20);
            this.txtTireMailId.TabIndex = 4;
            this.txtTireMailId.TextChanged += new System.EventHandler(this.txtTireMailId_TextChanged);
            // 
            // txtTireUserName
            // 
            this.txtTireUserName.Location = new System.Drawing.Point(134, 37);
            this.txtTireUserName.Name = "txtTireUserName";
            this.txtTireUserName.Size = new System.Drawing.Size(100, 20);
            this.txtTireUserName.TabIndex = 3;
            this.txtTireUserName.TextChanged += new System.EventHandler(this.txtTireUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAIL_ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER_NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTireUpdate
            // 
            this.btnTireUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTireUpdate.Location = new System.Drawing.Point(94, 76);
            this.btnTireUpdate.Name = "btnTireUpdate";
            this.btnTireUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTireUpdate.TabIndex = 7;
            this.btnTireUpdate.Text = "DELETE";
            this.btnTireUpdate.UseVisualStyleBackColor = false;
            this.btnTireUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTireDelUserName);
            this.panel1.Controls.Add(this.btnTireUpdate);
            this.panel1.Controls.Add(this.lblTiredelUsername);
            this.panel1.Location = new System.Drawing.Point(12, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 112);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTireDelUserName
            // 
            this.txtTireDelUserName.Location = new System.Drawing.Point(148, 23);
            this.txtTireDelUserName.Name = "txtTireDelUserName";
            this.txtTireDelUserName.Size = new System.Drawing.Size(100, 20);
            this.txtTireDelUserName.TabIndex = 7;
            this.txtTireDelUserName.TextChanged += new System.EventHandler(this.txtTireDelUserName_TextChanged);
            // 
            // lblTiredelUsername
            // 
            this.lblTiredelUsername.AutoSize = true;
            this.lblTiredelUsername.Location = new System.Drawing.Point(28, 30);
            this.lblTiredelUsername.Name = "lblTiredelUsername";
            this.lblTiredelUsername.Size = new System.Drawing.Size(68, 13);
            this.lblTiredelUsername.TabIndex = 1;
            this.lblTiredelUsername.Text = "USERNAME";
            this.lblTiredelUsername.Click += new System.EventHandler(this.lblTiredelUsername_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTireSearch);
            this.panel2.Controls.Add(this.txtTireID);
            this.panel2.Controls.Add(this.lblTireId);
            this.panel2.Location = new System.Drawing.Point(294, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 121);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTireSearch
            // 
            this.btnTireSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTireSearch.Location = new System.Drawing.Point(65, 76);
            this.btnTireSearch.Name = "btnTireSearch";
            this.btnTireSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTireSearch.TabIndex = 8;
            this.btnTireSearch.Text = "SEARCH";
            this.btnTireSearch.UseVisualStyleBackColor = false;
            this.btnTireSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTireID
            // 
            this.txtTireID.Location = new System.Drawing.Point(106, 17);
            this.txtTireID.Name = "txtTireID";
            this.txtTireID.Size = new System.Drawing.Size(87, 20);
            this.txtTireID.TabIndex = 7;
            this.txtTireID.TextChanged += new System.EventHandler(this.txtTireID_TextChanged);
            // 
            // lblTireId
            // 
            this.lblTireId.AutoSize = true;
            this.lblTireId.Location = new System.Drawing.Point(22, 24);
            this.lblTireId.Name = "lblTireId";
            this.lblTireId.Size = new System.Drawing.Size(18, 13);
            this.lblTireId.TabIndex = 1;
            this.lblTireId.Text = "ID";
            this.lblTireId.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.cmbTireUpdateId);
            this.pnlUpdate.Controls.Add(this.lblTireUpdateID);
            this.pnlUpdate.Controls.Add(this.button1);
            this.pnlUpdate.Controls.Add(this.txtTireUpdatePassword);
            this.pnlUpdate.Controls.Add(this.txtTireUpdateMailId);
            this.pnlUpdate.Controls.Add(this.txtTireUpdateName);
            this.pnlUpdate.Controls.Add(this.lblTireUpdatePassword);
            this.pnlUpdate.Controls.Add(this.lblTireUpdateMailId);
            this.pnlUpdate.Controls.Add(this.lblTireUpdateName);
            this.pnlUpdate.Location = new System.Drawing.Point(281, 157);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(258, 278);
            this.pnlUpdate.TabIndex = 7;
            this.pnlUpdate.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cmbTireUpdateId
            // 
            this.cmbTireUpdateId.FormattingEnabled = true;
            this.cmbTireUpdateId.Location = new System.Drawing.Point(130, 35);
            this.cmbTireUpdateId.Name = "cmbTireUpdateId";
            this.cmbTireUpdateId.Size = new System.Drawing.Size(100, 21);
            this.cmbTireUpdateId.TabIndex = 8;
            this.cmbTireUpdateId.SelectedIndexChanged += new System.EventHandler(this.cmbTireUpdateId_SelectedIndexChanged);
            // 
            // lblTireUpdateID
            // 
            this.lblTireUpdateID.AutoSize = true;
            this.lblTireUpdateID.Location = new System.Drawing.Point(35, 43);
            this.lblTireUpdateID.Name = "lblTireUpdateID";
            this.lblTireUpdateID.Size = new System.Drawing.Size(18, 13);
            this.lblTireUpdateID.TabIndex = 7;
            this.lblTireUpdateID.Text = "ID";
            this.lblTireUpdateID.Click += new System.EventHandler(this.ID_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(96, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtTireUpdatePassword
            // 
            this.txtTireUpdatePassword.Location = new System.Drawing.Point(134, 182);
            this.txtTireUpdatePassword.Name = "txtTireUpdatePassword";
            this.txtTireUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.txtTireUpdatePassword.TabIndex = 5;
            this.txtTireUpdatePassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTireUpdateMailId
            // 
            this.txtTireUpdateMailId.Location = new System.Drawing.Point(134, 128);
            this.txtTireUpdateMailId.Name = "txtTireUpdateMailId";
            this.txtTireUpdateMailId.Size = new System.Drawing.Size(100, 20);
            this.txtTireUpdateMailId.TabIndex = 4;
            this.txtTireUpdateMailId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTireUpdateName
            // 
            this.txtTireUpdateName.Location = new System.Drawing.Point(134, 82);
            this.txtTireUpdateName.Name = "txtTireUpdateName";
            this.txtTireUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtTireUpdateName.TabIndex = 3;
            this.txtTireUpdateName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblTireUpdatePassword
            // 
            this.lblTireUpdatePassword.AutoSize = true;
            this.lblTireUpdatePassword.Location = new System.Drawing.Point(35, 189);
            this.lblTireUpdatePassword.Name = "lblTireUpdatePassword";
            this.lblTireUpdatePassword.Size = new System.Drawing.Size(70, 13);
            this.lblTireUpdatePassword.TabIndex = 2;
            this.lblTireUpdatePassword.Text = "PASSWORD";
            this.lblTireUpdatePassword.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblTireUpdateMailId
            // 
            this.lblTireUpdateMailId.AutoSize = true;
            this.lblTireUpdateMailId.Location = new System.Drawing.Point(35, 135);
            this.lblTireUpdateMailId.Name = "lblTireUpdateMailId";
            this.lblTireUpdateMailId.Size = new System.Drawing.Size(49, 13);
            this.lblTireUpdateMailId.TabIndex = 1;
            this.lblTireUpdateMailId.Text = "MAIL_ID";
            this.lblTireUpdateMailId.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTireUpdateName
            // 
            this.lblTireUpdateName.AutoSize = true;
            this.lblTireUpdateName.Location = new System.Drawing.Point(35, 89);
            this.lblTireUpdateName.Name = "lblTireUpdateName";
            this.lblTireUpdateName.Size = new System.Drawing.Size(74, 13);
            this.lblTireUpdateName.TabIndex = 0;
            this.lblTireUpdateName.Text = "USER_NAME";
            this.lblTireUpdateName.Click += new System.EventHandler(this.label6_Click);
            // 
            // tire_architecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 459);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTire);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dgvTire);
            this.Name = "tire_architecture";
            this.Text = "tire_architecture";
            this.Load += new System.EventHandler(this.tire_architecture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTire)).EndInit();
            this.pnlTire.ResumeLayout(false);
            this.pnlTire.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTire;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlTire;
        private System.Windows.Forms.Button btnTireInsert;
        private System.Windows.Forms.TextBox txtTirePassword;
        private System.Windows.Forms.TextBox txtTireMailId;
        private System.Windows.Forms.TextBox txtTireUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTireUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTireDelUserName;
        private System.Windows.Forms.Label lblTiredelUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTireID;
        private System.Windows.Forms.Label lblTireId;
        private System.Windows.Forms.Button btnTireSearch;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.ComboBox cmbTireUpdateId;
        private System.Windows.Forms.Label lblTireUpdateID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTireUpdatePassword;
        private System.Windows.Forms.TextBox txtTireUpdateMailId;
        private System.Windows.Forms.TextBox txtTireUpdateName;
        private System.Windows.Forms.Label lblTireUpdatePassword;
        private System.Windows.Forms.Label lblTireUpdateMailId;
        private System.Windows.Forms.Label lblTireUpdateName;
    }
}