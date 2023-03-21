using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace викторина
{
    public class Datebase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");

        public void openonnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                MessageBox.Show("Вы уже вошли");
            }
        }
        public void closeonnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                MessageBox.Show("База данных закрыта");
            }
        }
        public SqlConnection getconnection()
        {
            return con;
        }
    }
}
