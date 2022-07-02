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
    public partial class frmDSMHDaDKy : Form
    {
        public frmDSMHDaDKy(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void frmDSMHDaDKy_Load(object sender, EventArgs e)
        {
            LoadMonDky();
            dgvDSMHDDK.Columns["malophoc"].HeaderText = "Mã lớp học ";
            dgvDSMHDDK.Columns["tenmonhoc"].HeaderText = "Tên học phần ";
            dgvDSMHDDK.Columns["sotinchi"].HeaderText = "Số tín chỉ ";
            dgvDSMHDDK.Columns["gvien"].HeaderText = "Giáo viên ";
        }
        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                { 
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDDK.DataSource = new Database().SelectData("monDaDKy", lst);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new frmDangKyMonhoc(masv).ShowDialog();
            LoadMonDky();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
