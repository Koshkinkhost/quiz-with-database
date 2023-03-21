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
    public partial class Form1 : Form
    {
        
        Datebase db=new Datebase();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //this.Hide();
            useradd us=new useradd();
            us.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string q = $"SELECT   name,surname,date_  FROM reg WHERE name='{textBox2.Text}'AND surname='{textBox1.Text}'AND date_='{textBox3.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT   name,surname,date_  FROM reg WHERE name='{textBox2.Text}'AND surname='{textBox1.Text}'AND date_='{textBox3.Text}'",db.getconnection());
            SqlCommand s = new SqlCommand(q, db.getconnection());
            adapter.SelectCommand = s;
            adapter.Fill(dt);
            db.openonnection();
           
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Вы успешно зашли");
                db.closeonnection();
                Test t = new Test();
                t.textBox1.Text = textBox1.Text;
                this.Hide();
                t.Show();

            }
            
            else
            {
                
                MessageBox.Show("Такого пользователя нет");
                db.closeonnection();
            }
            
        }
        public string str;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            str = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
