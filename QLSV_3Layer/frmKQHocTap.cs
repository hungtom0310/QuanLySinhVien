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
    public partial class frmKQHocTap : Form
    {
        public frmKQHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void frmKQHocTap_Load(object sender, EventArgs e)
        {
            KQ();
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học ";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["gvien"].HeaderText = "Giáo viên";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần học ";
            dgvKQHT.Columns["diemlan1"].HeaderText = "Điểm lần 1 ";
            dgvKQHT.Columns["diemlan2"].HeaderText = "Điểm lần 2";
        }

        private void KQ()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", lst);
        }
    }
}
