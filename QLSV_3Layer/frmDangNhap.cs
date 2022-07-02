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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            #region ktra_rangbuoc
            if (cbbLoaitaikhoan.SelectedIndex <0)
            {
                MessageBox.Show("Vui lòng nhập loại tài khoản");
            }
            if (string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập loại tài khoản");
                txtTendangnhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                
            }
            #endregion
            tendangnhap = txtTendangnhap.Text;
            loaitk = "";
            #region swtk
            switch (cbbLoaitaikhoan.Text)
            {
                case "Quản trị viên":
                    //MessageBox.Show("admin");
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    //MessageBox.Show("gv");
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    //MessageBox.Show("sv");
                    loaitk = "sv";
                    break;
            }
            #endregion
            
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value =loaitk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = txtTendangnhap.Text
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value =txtMatkhau.Text
                }
            };

            var rs = new Database().SelectData("dangnhap",lst);
            if (rs.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công "+tendangnhap);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
            }
            
        }

        private void cbbLoaitaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
