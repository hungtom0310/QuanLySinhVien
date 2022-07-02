using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv; //truyen lai msv khi frm chay
            InitializeComponent();
        }
        private string msv;
       // private int ExeCute(string sql,List<CustomParameter> lst = null)
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                //lay thong tin cua 1 sinh vien theo msv\
                //msv dc truyen vao tu form dssv
                var r = new Database().Select("selectSV '"+msv+"'");
                //MessageBox.Show(r[0].ToString());//load thanh cong
                //set cac gia tri vao form
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaysinh.Text = r["ngaysinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rdtNam.Checked = true;
                }
                else 
                {
                    rdtNu.Checked = true;
                }

                txtQuequan.Text = r["quequan"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //button btnLuu se xu ly 1 trong 2 tinh huong
            //th1: neu msv trong-> them moi sv
            //th2: neu msv co gia tri -> update
            /*
             ý tưởng
                cho du them moi hay cap nhat
                deu co gtri: họ,tên đệm,tên ngay sinh, giới tính, .... : đều dùng cho 2th
                -update: cần quan tâm tới mã sinh viên
            */
            //string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();//trỏ chuột về mtb ngày sinh
                return;//không thực hiện các câu phía dưới
            }
            //ngay sinh ơ dang masketbox nên set theo dang dd/mm/yyyy

            string gioitinh = rdtNam.Checked ? "1" : "0";//toan tu 2 ngoi
            // neu nam dc chon thi gia tri 1 va nguoc lai

            string quequan = txtQuequan.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;

            //khai bao 1 danh sach tham so = class  Customparameter 
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(msv))//neu them moi
            {
                sql = "ThemMoiSV";//goj tới procudure themmoisv
               
            }
            else//neu cap nhat
            {
                sql = "updateSV";//goj tới procudure updateSV 
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }

            lstPara.Add(new CustomParameter() { 
                key = "@ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });

            var rs = new Database().ExeCute(sql, lstPara);
            //truyen 2 tham so la cau lenh sql va dsach cac tham so
            if (rs == 1)//neu thuc thi thanh cong
            {
                if (string.IsNullOrEmpty(msv))//neu them moi
                {
                    MessageBox.Show("Thêm mới thông tin sinh viên thành công!!");
                }
                else//neu cap nhat
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!!");
                }
                this.Dispose();//đóng form sau khi thêm mới/ hoàn thành
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        string sql = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {

                sql = "xoaSV";//goj tới procudure updateSV 
                lst.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });


            }
            var rs = new Database().ExeCute(sql, lst);
            //truyen 2 tham so la cau lenh sql va dsach cac tham so
            if (rs == 1)//neu thuc thi thanh cong
            {
                if (string.IsNullOrEmpty(msv))//neu them moi
                {
                    MessageBox.Show("Xóa thông tin sinh viên thành công!!");
                }
                this.Dispose();//đóng form sau khi thêm mới/ hoàn thành
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }
    }
}
