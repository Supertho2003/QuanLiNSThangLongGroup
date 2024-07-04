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
    public partial class frm_QLNhanVien : Form
    {
        LopDungChung ldc = new LopDungChung();
        public frm_QLNhanVien()
        {
            InitializeComponent();
            dgv_Danhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void clearTextbox()
        {
            txt_MaNV.Text = "";
            txt_Hoten.Text = "";
            txt_Diachi.Text = "";
            txt_Chucvu.Text = "";
            txt_Email.Text = "";
            txt_Phone.Text = "";

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NHANVIEN values('" + txt_MaNV.Text + "','" + txt_Hoten.Text + "',Convert(date, '" + dt_Ngaysinh.Text + "',103),'" + txt_Diachi.Text + "','" + cb_GioiTinh.Text + "','" + txt_Email.Text + "', '" + txt_Chucvu.Text + "', '" + txt_Phone.Text + "', '" + cb_MaDA.SelectedValue + "', '" + cb_MaPB.SelectedValue + "'  )";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Thêm Nhân Viên Thất Bại");

            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE  NHANVIEN SET HoTen='" + txt_Hoten.Text + "', NgaySinh=Convert(date, '" + dt_Ngaysinh.Text + "',103), DiaChi='" + txt_Diachi.Text + "',GioiTinh='" + cb_GioiTinh.Text + "', Email='" + txt_Email.Text + "', ChucVu='" + txt_Chucvu.Text + "',SoDT='" + txt_Phone.Text + "', MaDA='" + cb_MaDA.SelectedValue + "', MaPB='" + cb_MaPB.SelectedValue + "' where MaNV ='"+txt_MaNV.Text+"' ";

            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Sửa Nhân Viên Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Sửa Nhân Viên Thất Bại");

            }
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM NHANVIEN where MaNV ='" + txt_MaNV.Text + "'";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Xóa Nhân Viên Thất Bại");

            }

        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void Load_DuAn()
        {
            string sql = "select * from DUAN";
            cb_MaDA.DataSource = ldc.loadMembers(sql);
            cb_MaDA.ValueMember = "MaDA";
            cb_MaDA.DisplayMember = "TenDA";

        }
        public void Load_PhongBan()
        {
            string sql = "select * from PHONGBAN";
            cb_MaPB.DataSource = ldc.loadMembers(sql);
            cb_MaPB.ValueMember = "MaPB";
            cb_MaPB.DisplayMember = "TenPB";

        }
       
        private void loadData()
        {
            string query = "SELECT * from NHANVIEN";
            dgv_Danhsach.DataSource = ldc.loadMembers(query);
            Load_DuAn();
            Load_PhongBan();
            
        }

        private void loadDataSearch()
        {
            string query = "SELECT * from NHANVIEN Where HoTen like '%" + txt_search.Text + "'";
            dgv_Danhsach.DataSource = ldc.loadMembers(query);
        }



        private void dgv_Danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_Danhsach.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_Hoten.Text = dgv_Danhsach.CurrentRow.Cells["HoTen"].Value.ToString();
            dt_Ngaysinh.Text = dgv_Danhsach.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_Diachi.Text = dgv_Danhsach.CurrentRow.Cells["DiaChi"].Value.ToString();
            cb_GioiTinh.Text = dgv_Danhsach.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txt_Email.Text = dgv_Danhsach.CurrentRow.Cells["Email"].Value.ToString();
            txt_Chucvu.Text = dgv_Danhsach.CurrentRow.Cells["ChucVu"].Value.ToString();
            txt_Phone.Text = dgv_Danhsach.CurrentRow.Cells["SoDT"].Value.ToString();
            cb_MaDA.SelectedValue = dgv_Danhsach.CurrentRow.Cells["MaDA"].Value.ToString();
            cb_MaPB.SelectedValue = dgv_Danhsach.CurrentRow.Cells["MaPB"].Value.ToString();

        }

        private void cb_Timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ptb_Timkiem_Click(object sender, EventArgs e)
        {
            loadDataSearch();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
