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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLPhongBan"] == null)
            {
                frm_QLPhongBan formPB = new frm_QLPhongBan();
                formPB.MdiParent = this;
                formPB.Show();
            }
            else
            {
                Application.OpenForms["frm_QLPhongBan"].Activate();
            }
        }

        private void quảnLýDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLDuAn"] == null)
            {
                frm_QLDuAn formDA = new frm_QLDuAn();
                formDA.MdiParent = this;
                formDA.Show();
            }
            else
            {
                Application.OpenForms["frm_QLDuAn"].Activate();
            }
        }

        private void quảnLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Luong"] == null)
            {
                frm_Luong formL=new frm_Luong();
                formL.MdiParent = this;
                formL.Show();
               
            }
            else
            {
                Application.OpenForms["frm_Luong"].Activate();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLNhanVien"] == null)
            {
                frm_QLNhanVien formNV=new frm_QLNhanVien();
                formNV.MdiParent = this;
                formNV.Show();
            }
            else
            {
                Application.OpenForms["frm_QLNhanVien"].Activate();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
