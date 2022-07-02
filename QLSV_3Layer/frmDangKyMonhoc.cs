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
    public partial class frmDangKyMonhoc : Form
    {
        public frmDangKyMonhoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void frmDangKyMonhoc_Load(object sender, EventArgs e)
        {
            loadDSLH();
            dgvDSLH.Columns["mamonhoc"].HeaderText = "Mã học phần ";
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học ";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học ";
            dgvDSLH.Columns["malophoc"].HeaderText = "Tên học phần ";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số tín chỉ ";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo viên";
        }

        private void loadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
                { 
                    key = "@masinhvien",
                    value = masv
                });
            dgvDSLH.DataSource = new Database().SelectData("dslopChuaDky",lst);
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn đăng ký môn: " + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString()+"?",
                    "Xác nhận đăng ký",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter() 
                    {
                        key = "@masinhvien",
                        value = masv
                    });
                    lst.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString()
                    });

                    var rs = new Database().ExeCute("dkyhoc", lst);
                    if (rs == -1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng ký!");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        loadDSLH();
                    }
                }
            }

        }
    }
}
