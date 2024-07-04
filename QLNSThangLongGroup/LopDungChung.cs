using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSThangLongGroup
{
    internal class LopDungChung
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\QLNSThangLongGroup (1)\QLNSThangLongGroup\QLNSThangLongGroup-master\QLNSThangLongGroup\QLNhanSu.mdf"";Integrated Security=True";
        SqlConnection con;

        public LopDungChung()
        {
            con = new SqlConnection(conString);
        }

        public int AddDeleEdit(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            con.Open();
            int kq = sqlCommand.ExecuteNonQuery();
            con.Close();
            return kq;
        }

        public object countMembers(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            con.Open();
            object kq = sqlCommand.ExecuteScalar();
            con.Close();
            return kq;
        }

        public DataTable loadMembers(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }

       
    }
}

