namespace ado_practice
{
    partial class two_gridviewcs
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
            this.dgvTableRegister = new System.Windows.Forms.DataGridView();
            this.dgvTableRegister1 = new System.Windows.Forms.DataGridView();
            this.lnkHomePage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRegister1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableRegister
            // 
            this.dgvTableRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableRegister.Location = new System.Drawing.Point(12, 98);
            this.dgvTableRegister.Name = "dgvTableRegister";
            this.dgvTableRegister.Size = new System.Drawing.Size(375, 351);
            this.dgvTableRegister.TabIndex = 0;
            // 
            // dgvTableRegister1
            // 
            this.dgvTableRegister1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableRegister1.Location = new System.Drawing.Point(450, 98);
            this.dgvTableRegister1.Name = "dgvTableRegister1";
            this.dgvTableRegister1.Size = new System.Drawing.Size(383, 351);
            this.dgvTableRegister1.TabIndex = 1;
            // 
            // lnkHomePage
            // 
            this.lnkHomePage.AutoSize = true;
            this.lnkHomePage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnkHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHomePage.ForeColor = System.Drawing.SystemColors.Control;
            this.lnkHomePage.Location = new System.Drawing.Point(345, 31);
            this.lnkHomePage.Name = "lnkHomePage";
            this.lnkHomePage.Size = new System.Drawing.Size(177, 31);
            this.lnkHomePage.TabIndex = 2;
            this.lnkHomePage.TabStop = true;
            this.lnkHomePage.Text = "HOME PAGE";
            this.lnkHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHomePage_LinkClicked);
            // 
            // two_gridviewcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 463);
            this.Controls.Add(this.lnkHomePage);
            this.Controls.Add(this.dgvTableRegister1);
            this.Controls.Add(this.dgvTableRegister);
            this.Name = "two_gridviewcs";
            this.Text = "two_gridviewcs";
            this.Load += new System.EventHandler(this.two_gridviewcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRegister1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableRegister;
        private System.Windows.Forms.DataGridView dgvTableRegister1;
        private System.Windows.Forms.LinkLabel lnkHomePage;
    }
}