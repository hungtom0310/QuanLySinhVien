
namespace QLSV_3Layer
{
    partial class frmDSMHDaDKy
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
            this.dgvDSMHDDK = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSMHDDK
            // 
            this.dgvDSMHDDK.AllowUserToAddRows = false;
            this.dgvDSMHDDK.AllowUserToDeleteRows = false;
            this.dgvDSMHDDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMHDDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMHDDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHDDK.Location = new System.Drawing.Point(3, 92);
            this.dgvDSMHDDK.MultiSelect = false;
            this.dgvDSMHDDK.Name = "dgvDSMHDDK";
            this.dgvDSMHDDK.ReadOnly = true;
            this.dgvDSMHDDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHDDK.Size = new System.Drawing.Size(795, 362);
            this.dgvDSMHDDK.TabIndex = 0;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.Location = new System.Drawing.Point(590, 14);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(166, 48);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký môn học mới";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách các môn đã đăng ký";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmDSMHDaDKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSMHDDK);
            this.Name = "frmDSMHDaDKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học đã đăng ký";
            this.Load += new System.EventHandler(this.frmDSMHDaDKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSMHDDK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label2;
    }
}