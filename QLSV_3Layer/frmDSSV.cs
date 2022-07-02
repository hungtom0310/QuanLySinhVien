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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();//neu them moi sv -> msv = null
            LoadDSSV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private string tukhoa = "";
        private void LoadDSSV(){
            //load toan bo danh sach sinh vien
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien",lstPara);
            //dat ten cot
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvSinhVien.Columns["email"].HeaderText = "Email";

        }
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi doubleclick se cap nhat thong tin sv
            if (e.RowIndex>=0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                //can truyen msv nay vao frmsv
                new frmSinhVien(msv).ShowDialog();

                //sau khi xong can load lai
                LoadDSSV();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSSV();
        }
         string masinhvien;
        string sql = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "xoaSV";
                var lst = new List<CustomParameter>()
                { new CustomParameter()
                    {
                       key = "@masv",
                        value =masinhvien
                    }
                };
                var rs = new Database().ExeCute("xoaSV", lst);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSSV();
                }
            }
        }
    }
}
