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
    public partial class Geography : Form
    {
        static int points = 0;
        
        Datebase db=new Datebase();
        public Geography()
        {
            InitializeComponent();
            
             
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons f = MessageBoxButtons.OKCancel;
            string caption = "Подтверждение";
            string message = "Вы уверены,что хотите выйти? Ваши результаты не сохранятся.";
            DialogResult result =MessageBox.Show( message, caption,f);
            if (result == DialogResult.OK)
            {


                this.Hide();
                Test t = new Test();
                t.Show();
            }
        }

        private void Geography_Load(object sender, EventArgs e)
        {
            label6.Text = points.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            button3.BackColor = Color.Green;
            button3.ForeColor=Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            //string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            //SqlDataAdapter a = new SqlDataAdapter();
            //SqlCommand s = new SqlCommand(q, db.getconnection());
            //a.SelectCommand = s;
            //a.Fill(dt);
            points ++;
            label6.Text = points.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Green;
            button3.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.White;
            button3.BackColor = Color.Green;
            button3.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.White;
            button3.BackColor = Color.Green;
            button3.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
        
       
        private void button7_Click(object sender, EventArgs e)
        {
            points++;
            button7.BackColor = Color.Green;
            button7.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            //string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            //SqlDataAdapter a = new SqlDataAdapter();
            //SqlCommand s = new SqlCommand(q, db.getconnection());
            //a.SelectCommand = s;
            //a.Fill(dt);
            label6.Text = points.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button8.ForeColor = Color.White;
            button7.BackColor = Color.Green;
            button7.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            button9.ForeColor = Color.White;
            button7.BackColor = Color.Green;
            button7.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button6.ForeColor = Color.White;
            button7.BackColor = Color.Green;
            button7.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            points++;
            button11.BackColor = Color.Green;
            button11.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;
            //string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            //SqlDataAdapter a = new SqlDataAdapter();
            //SqlCommand s = new SqlCommand(q, db.getconnection());
            //a.SelectCommand = s;
            //a.Fill(dt);
            label6.Text = points.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            button12.ForeColor = Color.White;
            button11.BackColor = Color.Green;
            button11.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            button10.ForeColor = Color.White;
            button11.BackColor = Color.Green;
            button11.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
            button13.ForeColor = Color.White;
            button11.BackColor = Color.Green;
            button11.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            button15.ForeColor = Color.White;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            button14.ForeColor = Color.White;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            points++;
            button17.BackColor = Color.Green;
            button17.ForeColor = Color.White;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            //string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            //SqlDataAdapter a = new SqlDataAdapter();
            //SqlCommand s = new SqlCommand(q, db.getconnection());
            //a.SelectCommand = s;
            //a.Fill(dt);
           
            label6.Text = points.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red;
            button16.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        
        private void button22_Click(object sender, EventArgs e)
        {
            Geography2 g = new Geography2();
            this.Hide();
            
            g.Show();
            
            g.textBox1.Text = textBox1.Text;
            g.label8.Text=label6.Text;
            string q = $"UPDATE reg SET points={label6.Text} WHERE surname='{textBox1.Text}'";
            
            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            
            
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Red;
            button19.ForeColor = Color.White;
            button20.Enabled = false;
            button21.Enabled = false;
            button19.Enabled = false;
            button18.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            points++;
            button20.BackColor = Color.Green;
            button20.ForeColor = Color.White;
            button20.Enabled = false;
            button21.Enabled = false;
            button19.Enabled = false;
            button18.Enabled = false;
            //string q = $"UPDATE reg SET points={points} WHERE surname='{textBox1.Text}'";

            //SqlDataAdapter a = new SqlDataAdapter();
            //SqlCommand s = new SqlCommand(q, db.getconnection());
            //a.SelectCommand = s;
            //a.Fill(dt);
            label6.Text = points.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Red;
            button18.ForeColor = Color.White;
            button20.Enabled = false;
            button21.Enabled = false;
            button19.Enabled = false;
            button18.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Red;
            button21.ForeColor = Color.White;
            button20.Enabled = false;
            button21.Enabled = false;
            button19.Enabled = false;
            button18.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
