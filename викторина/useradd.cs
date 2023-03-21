using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace викторина
{
    
    public partial class useradd : Form
    {
        Datebase db = new Datebase();
        public useradd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string q = $"INSERT into reg (name,surname,date_) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')";
            SqlDataAdapter adapter = new SqlDataAdapter($"INSERT into reg (name,surname,date_) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')",db.getconnection());
            SqlCommand s=new SqlCommand(q,db.getconnection());
            adapter.SelectCommand = s;
            adapter.Fill(dt);
            adapter.Update(dt);
            DataTable dt2 = new DataTable();    
            string q2 = $"INSERT into reg2 (name,surname,date_) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')";
            SqlCommand s2 = new SqlCommand(q2, db.getconnection());
            SqlDataAdapter adapter2 = new SqlDataAdapter($"INSERT into reg2 (name,surname,date_) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')", db.getconnection());
            adapter2.SelectCommand = s2;
            adapter2.Fill(dt2);
            adapter2.Update(dt2);
            MessageBox.Show("Вы зарегистрировались!");
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void useradd_Load(object sender, EventArgs e)
        {

        }
    }
}
