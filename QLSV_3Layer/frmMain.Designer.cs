
namespace QLSV_3Layer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LophocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diemThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucnangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKiMHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDiemThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíToolStripMenuItem,
            this.diemThiToolStripMenuItem,
            this.chucnangToolStripMenuItem,
            this.hệThốngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.giaoVienToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.LophocToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sinhVienToolStripMenuItem.Text = "Quản lí sinh viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // giaoVienToolStripMenuItem
            // 
            this.giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            this.giaoVienToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.giaoVienToolStripMenuItem.Text = "Quản lí giáo viên";
            this.giaoVienToolStripMenuItem.Click += new System.EventHandler(this.giaoVienToolStripMenuItem_Click);
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.monHocToolStripMenuItem.Text = "Quản lí môn học";
            this.monHocToolStripMenuItem.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click);
            // 
            // LophocToolStripMenuItem
            // 
            this.LophocToolStripMenuItem.Name = "LophocToolStripMenuItem";
            this.LophocToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.LophocToolStripMenuItem.Text = "Quản lí lớp học";
            this.LophocToolStripMenuItem.Click += new System.EventHandler(this.LophocToolStripMenuItem_Click);
            // 
            // diemThiToolStripMenuItem
            // 
            this.diemThiToolStripMenuItem.Name = "diemThiToolStripMenuItem";
            this.diemThiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.diemThiToolStripMenuItem.Text = "Điểm thi";
            this.diemThiToolStripMenuItem.Click += new System.EventHandler(this.diemThiToolStripMenuItem_Click_1);
            // 
            // chucnangToolStripMenuItem
            // 
            this.chucnangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangKiMHToolStripMenuItem,
            this.xemDiemThiToolStripMenuItem});
            this.chucnangToolStripMenuItem.Name = "chucnangToolStripMenuItem";
            this.chucnangToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chucnangToolStripMenuItem.Text = "Chức năng";
            // 
            // dangKiMHToolStripMenuItem
            // 
            this.dangKiMHToolStripMenuItem.Name = "dangKiMHToolStripMenuItem";
            this.dangKiMHToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dangKiMHToolStripMenuItem.Text = "Đăng kí môn học";
            this.dangKiMHToolStripMenuItem.Click += new System.EventHandler(this.dkyMhocToolStripMenuItem_Click);
            // 
            // xemDiemThiToolStripMenuItem
            // 
            this.xemDiemThiToolStripMenuItem.Name = "xemDiemThiToolStripMenuItem";
            this.xemDiemThiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.xemDiemThiToolStripMenuItem.Text = "Xem điểm thi";
            this.xemDiemThiToolStripMenuItem.Click += new System.EventHandler(this.diemThiToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LophocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem diemThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucnangToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dangKiMHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDiemThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

