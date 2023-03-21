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

namespace викторина
{
    public partial class Music2 : Form
    {
        public Music2()
        {
            InitializeComponent();
        }

        private void Music2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseDataSet2.reg". При необходимости она может быть перемещена или удалена.
            this.regTableAdapter.Fill(this.courseDataSet2.reg);
            Datebase db =new Datebase();
            DataTable dt=new DataTable();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseDataSet1.reg2". При необходимости она может быть перемещена или удалена.
            this.reg2TableAdapter.Fill(this.courseDataSet1.reg2);
            string q = $"SELECT name,surname,date_,points FROM reg2 ORDER BY points DESC";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            db.openonnection();
            s.ExecuteNonQuery();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closeonnection();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
