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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text; 
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter() 
            { 
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql,lstPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDSGV.Columns["gt"].HeaderText = "Giới tính";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa chỉ";
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGV(mgv).ShowDialog();
                loadDSGV();
            }
        }
    }
}
