namespace ado_practice
{
    partial class procedure
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
            this.lnkProcedureback = new System.Windows.Forms.LinkLabel();
            this.dgvSpShow = new System.Windows.Forms.DataGridView();
            this.dgvSpShowCol = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpShowCol)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkProcedureback
            // 
            this.lnkProcedureback.AutoSize = true;
            this.lnkProcedureback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkProcedureback.Location = new System.Drawing.Point(798, 9);
            this.lnkProcedureback.Name = "lnkProcedureback";
            this.lnkProcedureback.Size = new System.Drawing.Size(69, 25);
            this.lnkProcedureback.TabIndex = 15;
            this.lnkProcedureback.TabStop = true;
            this.lnkProcedureback.Text = "BACK";
            this.lnkProcedureback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProcedureback_LinkClicked);
            // 
            // dgvSpShow
            // 
            this.dgvSpShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpShow.Location = new System.Drawing.Point(411, 88);
            this.dgvSpShow.Name = "dgvSpShow";
            this.dgvSpShow.Size = new System.Drawing.Size(466, 371);
            this.dgvSpShow.TabIndex = 16;
            // 
            // dgvSpShowCol
            // 
            this.dgvSpShowCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpShowCol.Location = new System.Drawing.Point(12, 99);
            this.dgvSpShowCol.Name = "dgvSpShowCol";
            this.dgvSpShowCol.Size = new System.Drawing.Size(368, 347);
            this.dgvSpShowCol.TabIndex = 17;
            this.dgvSpShowCol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "SP_SELECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(134, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "SP_SELECT_COL";
            // 
            // procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSpShowCol);
            this.Controls.Add(this.dgvSpShow);
            this.Controls.Add(this.lnkProcedureback);
            this.Name = "procedure";
            this.Text = "procedure";
            this.Load += new System.EventHandler(this.procedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpShowCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkProcedureback;
        private System.Windows.Forms.DataGridView dgvSpShow;
        private System.Windows.Forms.DataGridView dgvSpShowCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}