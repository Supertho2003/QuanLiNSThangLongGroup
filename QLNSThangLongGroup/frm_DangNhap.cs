using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSThangLongGroup
{
    public partial class frm_DangNhap : Form
    {
        LopDungChung ldc = new LopDungChung();
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void frmdangky_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            frm_DangKy dangKy = new frm_DangKy();
            dangKy.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
            dangKy.Show();
            this.Hide();

        }
        int dem = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from TAIKHOAN where username = '" + txt_taikhoan.Text.ToUpper() + "' and password = '" + txt_matkhau.Text.ToUpper() + "'";
            var kq = ldc.countMembers(sql);

            if ((int)kq > 0)
            {
                frm_Main frmMain = new frm_Main();
                frmMain.Show();
                this.Hide();
            } else 
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }




        }
    }
}
