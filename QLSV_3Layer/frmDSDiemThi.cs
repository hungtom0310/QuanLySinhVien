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
    public partial class frmDSDiemThi : Form
    {
        public frmDSDiemThi(string magvien)
        {
            this.magvien = magvien;
            InitializeComponent();
        }
        private string magvien;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {

        }

        private void frmDSDiemThi_Load(object sender, EventArgs e)
        {
            KQ();
            dgvDiemThi.Columns["mamonhoc"].HeaderText = "Mã môn học ";
            dgvDiemThi.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDiemThi.Columns["gvien"].HeaderText = "Giáo viên";
            dgvDiemThi.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvDiemThi.Columns["lanhoc"].HeaderText = "Lần học ";
            dgvDiemThi.Columns["diemlan1"].HeaderText = "Điểm lần 1 ";
            dgvDiemThi.Columns["diemlan2"].HeaderText = "Điểm lần 2";
        }
        private void KQ()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = magvien
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDiemThi.DataSource = new Database().SelectData("diemthi", lst);
        }
        private string tukhoa = "";
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            KQ();
        }
    }
}
