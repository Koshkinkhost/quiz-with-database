using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace викторина
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        Datebase db=new Datebase();
        DataTable dt=new DataTable();
        private void Result_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseDataSet.reg". При необходимости она может быть перемещена или удалена.
            this.regTableAdapter.Fill(this.courseDataSet.reg);
            string q = $"SELECT name,surname,date_,points FROM reg ORDER BY points DESC";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            db.openonnection();
            s.ExecuteNonQuery();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closeonnection();

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }
    }
}
