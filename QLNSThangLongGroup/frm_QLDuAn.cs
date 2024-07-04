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
    public partial class frm_QLDuAn : Form
    {
        LopDungChung ldc = new LopDungChung();
        public frm_QLDuAn()
        {
            InitializeComponent();
            dgv_DA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void clearTextbox()
        {
            txt_MaDA.Text = "";
            txt_TenDA.Text = "";
            txt_Mota.Text = "";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DUAN values('"+txt_MaDA.Text+"','"+txt_TenDA.Text+"','"+txt_Mota.Text+"')";
            int kq = ldc.AddDeleEdit(query);

            if(kq >= 1)
            {
                MessageBox.Show("Thêm Dự Án Thành Công !!");
                loadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Thêm Dự Án Thất Bại");

            }
        }

        private void loadData()
        {
            string query = "SELECT * from DUAN";
            dgv_DA.DataSource = ldc.loadMembers(query);
        }

        private void loadDataSearch()
        {
            string query = "SELECT * from DUAN Where TenDA like '%" + txtSearch.Text + "'";
            dgv_DA.DataSource = ldc.loadMembers(query);
        }

        private void frm_QLDuAn_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TABLE DUAN where MaDA = '"+txt_MaDA.Text+"' SET TenDA = '"+txt_TenDA.Text+"', Mota = '"+txt_Mota.Text+"'";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Sửa Dự Án Thành Công !!");
                loadData();
                clearTextbox() ;
            }
            else
            {
                MessageBox.Show("Sửa Dự Án Thất Bại");

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM DUAN where MaDA ='" + txt_MaDA.Text + "'";
            int kq = ldc.AddDeleEdit(query);

            if (kq >= 1)
            {
                MessageBox.Show("Xóa Dự Án Thành Công !!");
                loadData();
                clearTextbox() ;
            }
            else
            {
                MessageBox.Show("Xóa Dự Án Thất Bại");

            }
        }

        private void dgv_DA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDA.Text = dgv_DA.CurrentRow.Cells["MaDA"].Value.ToString();
            txt_TenDA.Text = dgv_DA.CurrentRow.Cells["TenDA"].Value.ToString();
            txt_Mota.Text = dgv_DA.CurrentRow.Cells["Mota"].Value.ToString();

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
    }
}
