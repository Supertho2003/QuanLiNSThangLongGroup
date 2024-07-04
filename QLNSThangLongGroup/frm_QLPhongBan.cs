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
    public partial class frm_QLPhongBan : Form
    {
        LopDungChung ldc = new LopDungChung();
        public frm_QLPhongBan()
        {
            InitializeComponent();
            dgv_PB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO PHONGBAN values('" + txt_MaPB.Text + "','" + txt_TenPB.Text + "','" + txt_Mota.Text + "')";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Thêm Phòng Ban Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Thêm Phòng Ban Thất Bại");

            }
        }

        private void clearTextbox()
        {
            txt_MaPB.Text = "";
            txt_TenPB.Text = "";
            txt_Mota.Text = "";
        }

        private void loadData()
        {
            string query = "SELECT * from PHONGBAN";
            dgv_PB.DataSource = ldc.loadMembers(query);
        }

        private void loadDataSearch()
        {
            string query = "SELECT * from PHONGBAN Where TenPB like '%"+txtSearch.Text+"'";
            dgv_PB.DataSource = ldc.loadMembers(query);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TABLE PHONGBAN where MaPB = '" + txt_MaPB.Text + "' SET TenPB = '" + txt_TenPB.Text + "', Mota = '" + txt_Mota.Text + "'";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Sửa Phòng Ban Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Sửa Phòng Ban Thất Bại");

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM PB where MaPB ='" + txt_TenPB.Text + "'";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Xóa Phòng Ban Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Xóa Phòng Ban Thất Bại");

            }
        }

        private void dgv_PB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaPB.Text = dgv_PB.CurrentRow.Cells["MaPB"].Value.ToString();
            txt_TenPB.Text = dgv_PB.CurrentRow.Cells["TenDA"].Value.ToString();
            txt_Mota.Text = dgv_PB.CurrentRow.Cells["Mota"].Value.ToString();
        }

        private void frm_QLPhongBan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void ptb_Timkiem_Click(object sender, EventArgs e)
        {
            loadDataSearch();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            loadData();
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
