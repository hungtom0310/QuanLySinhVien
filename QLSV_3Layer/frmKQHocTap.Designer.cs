
namespace QLSV_3Layer
{
    partial class frmKQHocTap
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
            this.dgvKQHT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQHT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKQHT
            // 
            this.dgvKQHT.AllowUserToAddRows = false;
            this.dgvKQHT.AllowUserToDeleteRows = false;
            this.dgvKQHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKQHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKQHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKQHT.Location = new System.Drawing.Point(0, 0);
            this.dgvKQHT.Name = "dgvKQHT";
            this.dgvKQHT.ReadOnly = true;
            this.dgvKQHT.Size = new System.Drawing.Size(800, 450);
            this.dgvKQHT.TabIndex = 0;
            // 
            // frmKQHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKQHT);
            this.Name = "frmKQHocTap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.frmKQHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKQHT;
    }
}