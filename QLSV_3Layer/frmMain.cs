using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string taikhoan;
        private string loaitk;

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            var fn = new frmDangNhap();
            fn.ShowDialog();
            
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                diemThiToolStripMenuItem.Visible = false;
                chucnangToolStripMenuItem.Visible = false;
            }
            if (loaitk.Equals("gv"))
            {
                quảnLíToolStripMenuItem.Visible = false;
                chucnangToolStripMenuItem.Visible = false;
            }
            if (loaitk.Equals("sv"))
            {
                quảnLíToolStripMenuItem.Visible = false;
                diemThiToolStripMenuItem.Visible = false;
            }
            /*
            else
            {
                quảnLíToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    chucnangToolStripMenuItem.Visible = false;
                }
                else
                {
                    diemThiToolStripMenuItem.Visible = false;
                }
            }
            
            */
            //MessageBox.Show("Đăng nhập thành công!",tk);

            frmWelcom f = new frmWelcom();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panel1.Controls.Add(f);
            
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            AddForm(f);
        }

        private void diemThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmKQHocTap(taikhoan);
            AddForm(f);
        }

        private void dkyMhocToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var f = new frmDSMHDaDKy(taikhoan);
            AddForm(f);
        }

        private void diemThiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDSDiemThi f = new frmDSDiemThi(taikhoan);
            AddForm(f);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroGiup f = new frmTroGiup();
            AddForm(f);
        }

        private void LophocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLopHoc f = new frmDSLopHoc();
            AddForm(f);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var f = new frmDangNhap();
            f.Visible = false;
            taikhoan = f.tendangnhap;
            loaitk = f.loaitk;
            if (loaitk.Equals("admin"))
            {
                diemThiToolStripMenuItem.Visible = false;
                chucnangToolStripMenuItem.Visible = false;
            }
            if (loaitk.Equals("gv"))
            {
                quảnLíToolStripMenuItem.Visible = false;
                chucnangToolStripMenuItem.Visible = false;
            }
            if (loaitk.Equals("sv"))
            {
                quảnLíToolStripMenuItem.Visible = false;
                diemThiToolStripMenuItem.Visible = false;
            }
            frmWelcom fn = new frmWelcom();
            AddForm(fn);
        }
    }
}
