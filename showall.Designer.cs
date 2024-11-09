namespace ado_practice
{
    partial class showall
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
            this.dgvShowAll = new System.Windows.Forms.DataGridView();
            this.btnShowBack = new System.Windows.Forms.LinkLabel();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtShowId = new System.Windows.Forms.TextBox();
            this.lblShowID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).BeginInit();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowAll
            // 
            this.dgvShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAll.Location = new System.Drawing.Point(361, 60);
            this.dgvShowAll.Name = "dgvShowAll";
            this.dgvShowAll.Size = new System.Drawing.Size(517, 422);
            this.dgvShowAll.TabIndex = 0;
            // 
            // btnShowBack
            // 
            this.btnShowBack.AutoSize = true;
            this.btnShowBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBack.Location = new System.Drawing.Point(433, 24);
            this.btnShowBack.Name = "btnShowBack";
            this.btnShowBack.Size = new System.Drawing.Size(52, 20);
            this.btnShowBack.TabIndex = 4;
            this.btnShowBack.TabStop = true;
            this.btnShowBack.Text = "BACK";
            this.btnShowBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowBack_LinkClicked);
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.btnShow);
            this.pnlShow.Controls.Add(this.txtShowId);
            this.pnlShow.Controls.Add(this.lblShowID);
            this.pnlShow.Location = new System.Drawing.Point(29, 93);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(279, 146);
            this.pnlShow.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnShow.Location = new System.Drawing.Point(77, 78);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(80, 25);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShowSubmit_Click);
            // 
            // txtShowId
            // 
            this.txtShowId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShowId.Location = new System.Drawing.Point(102, 27);
            this.txtShowId.Name = "txtShowId";
            this.txtShowId.Size = new System.Drawing.Size(160, 20);
            this.txtShowId.TabIndex = 12;
            // 
            // lblShowID
            // 
            this.lblShowID.AutoSize = true;
            this.lblShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowID.Location = new System.Drawing.Point(30, 29);
            this.lblShowID.Name = "lblShowID";
            this.lblShowID.Size = new System.Drawing.Size(24, 18);
            this.lblShowID.TabIndex = 12;
            this.lblShowID.Text = "ID";
            // 
            // showall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 484);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.btnShowBack);
            this.Controls.Add(this.dgvShowAll);
            this.Name = "showall";
            this.Text = "showall";
            this.Load += new System.EventHandler(this.showall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).EndInit();
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowAll;
        private System.Windows.Forms.LinkLabel btnShowBack;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtShowId;
        private System.Windows.Forms.Label lblShowID;
    }
}