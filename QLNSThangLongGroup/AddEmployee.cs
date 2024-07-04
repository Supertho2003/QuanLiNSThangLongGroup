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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNSThangLongGroup
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-73VPP1F7\\SQLEXPRESS;Initial Catalog=DataEmployee;Persist Security Info=True;User ID=anhtho;Password=anhtho1006;Encrypt=False");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeSystem VALUES ('" + int.Parse(txtID.Text) + "', '" + txtName.Text + "', '"+txtGender.Text+"' , '" + int.Parse(txtNumber.Text) +"', '"+txtPosition.Text+"','"+DateTime.Parse(txtDate.Text) +"','"+txtStatus.Text+"')",conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //MessageBox.Show("Thêm Thành Công");
            //txtID.Text = "";
            //txtName.Text = "";
            //txtGender.Text = "";
            //txtNumber.Text = "";
            //txtPosition.Text = "";
            //txtDate.Text = "";
            //txtStatus.Text = "";
            //BindData();
        }

        void BindData()
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM  EmployeeSystem", conn);
            //SqlDataAdapter sd = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //sd.Fill(dt);
            //dataGridView2.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand command = new SqlCommand("UPDATE EmployeeSystem SET Name = '" + txtName.Text + "',Gender ='"+txtGender.Text+"',Number = '"+int.Parse(txtNumber.Text)+"',Position = '"+txtPosition.Text+"',DateCreat = getdate(),Status = '"+txtStatus.Text+"' WHERE ID = '"+txtID.Text+"'", conn);
            //command.ExecuteNonQuery();
            //conn.Close();
            //MessageBox.Show("Chỉnh Sửa Thành Công");
            //BindData();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        //    if (txtID.Text != "")
        //    {
        //        if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            conn.Open();
        //            SqlCommand command = new SqlCommand("DELETE EmployeeSystem WHERE ID = '" + int.Parse(txtID.Text) + "'", conn);
        //            command.ExecuteNonQuery();
        //            conn.Close();
        //            MessageBox.Show("Xóa Thành Công");
        //            BindData();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng nhập id để xóa");
        //    }
        }

       
    }
}
