using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSThangLongGroup
{
    public partial class frm_DangKy : Form
    {
        LopDungChung ldc = new LopDungChung();
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\My Space\UNI\CS464\QLNSThangLongGroup (1)\QLNSThangLongGroup\QLNSThangLongGroup-master\QLNSThangLongGroup\QLNhanSu.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);

            conn.Open();

            
            
            string queryCheck = "SELECT Count(*) from TAIKHOAN where Username = '"+txt_taikhoan.Text+"'";

            SqlCommand cmd = new SqlCommand(queryCheck, conn);

            int kq = (int)cmd.ExecuteScalar();
            conn.Close();

            string query = "INSERT INTO TAIKHOAN values('" + txt_taikhoan.Text + "','" + txt_matkhau.Text + "', '') ";
            
            if (txt_matkhau.Text != txt_RePass.Text)
            {
                lb_Message.Text = "Mật khẩu không khớp, Vui lòng nhập lại!";
            } else if(kq>=1)
            {
                MessageBox.Show("Tên người dùng đã tồn tại!!");
            } else 
            {
                int check = ldc.AddDeleEdit(query);
                if (check >= 1)
                {
                    MessageBox.Show("Đăng Ký Tài Khoản Thành Công, Mời bạn sử dụng chương trình");
                    frm_Main frmMain = new frm_Main();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dang Ky Tai Khoan That Bai");
                }
            }
            
        }
    }
}
