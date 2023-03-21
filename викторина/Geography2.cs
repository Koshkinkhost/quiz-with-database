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
    public partial class Geography2 : Form
    {
        static int attempts = 0;
        static int points = 0;
        Datebase db=new Datebase();
        static int key2 = 0;
        
        public Geography2()
        {
            InitializeComponent();
        }

        private void Geography2_Load(object sender, EventArgs e)
        {
            
            string q = $"Select points FROM reg  WHERE surname ='{textBox1.Text}'";
            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            attempts++;
           
            button20.BackColor = Color.Red;
            button20.ForeColor = Color.White;
            button20.Enabled = false;
            if (attempts > 2)
            {

                button17.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;

            }
            if (key2 == 3)
            {


                points++;

            }
        }
        DataTable dt = new DataTable();
        private void button18_Click(object sender, EventArgs e)
        {
            attempts++;
            key2 += 1;
            button18.BackColor = Color.Green;
            button18.ForeColor = Color.White;
            
            button18.Enabled = false;
            if(attempts>2)
            {
                
                button17.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
               
            }
            if (key2 > 2)
            {

                string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand s = new SqlCommand(q, db.getconnection());
                a.SelectCommand = s;
                a.Fill(dt);
                points++;
                string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
                SqlDataAdapter a2 = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(q2, db.getconnection());
                SqlDataReader reader;
                db.openonnection();
                reader = cmd.ExecuteReader();
                reader.Read();
                label8.Text = Convert.ToString(reader.GetInt32(0));
                db.closeonnection();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            attempts++;
            key2 += 1;
            button19.BackColor = Color.Green;
            button19.ForeColor = Color.White;
            button19.Enabled = false;
            if (attempts > 2)
            {

                button17.Enabled = false;
                button18.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;

            }
            if (key2 > 2)
            {


                points++;
                string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand s = new SqlCommand(q, db.getconnection());
                a.SelectCommand = s;
                a.Fill(dt);
                string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
                SqlDataAdapter a2 = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(q2, db.getconnection());
                SqlDataReader reader;
                db.openonnection();
                reader = cmd.ExecuteReader();
                reader.Read();
                label8.Text = Convert.ToString(reader.GetInt32(0));
                db.closeonnection();

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            attempts++;
            key2 += 1;
            button17.BackColor = Color.Green;
            button17.ForeColor = Color.White;
            
            button17.Enabled = false;
            if (attempts > 2)
            {

                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;

            }
            if (key2 > 2)
            {

                points++;
                string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand s = new SqlCommand(q, db.getconnection());
                a.SelectCommand = s;
                a.Fill(dt);
                string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
                SqlDataAdapter a2 = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(q2, db.getconnection());
                SqlDataReader reader;
                db.openonnection();
                reader = cmd.ExecuteReader();
                reader.Read();
                label8.Text = Convert.ToString(reader.GetInt32(0));
                db.closeonnection();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button5.BackColor = Color.Green;
            button5.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button5.BackColor = Color.Green;
            button5.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.White;
            button5.BackColor = Color.Green;
            button5.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            points++;
            button5.BackColor = Color.Green;
            button5.ForeColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.SelectCommand = s;
            a.Fill(dt);
            string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
            SqlDataAdapter a2 = new SqlDataAdapter();
            SqlCommand cmd=new SqlCommand(q2, db.getconnection());
            SqlDataReader reader;
            db.openonnection();
            reader = cmd.ExecuteReader();
            reader.Read();
            label8.Text = Convert.ToString(reader.GetInt32(0));
            db.closeonnection();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            points++;
            button6.BackColor = Color.Green;
            button6.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
            SqlDataAdapter a2 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(q2, db.getconnection());
            SqlDataReader reader;
            db.openonnection();
            reader = cmd.ExecuteReader();
            reader.Read();
            label8.Text = Convert.ToString(reader.GetInt32(0));
            db.closeonnection();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button7.ForeColor = Color.White;
            button6.BackColor = Color.Green;
            button6.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button8.ForeColor = Color.White;
            button6.BackColor = Color.Green;
            button6.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            button9.ForeColor = Color.White;
            button6.BackColor = Color.Green;
            button6.ForeColor = Color.White;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            points++;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;
            string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
            SqlDataAdapter a2 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(q2, db.getconnection());
            SqlDataReader reader;
            db.openonnection();
            reader = cmd.ExecuteReader();
            reader.Read();
            label8.Text = Convert.ToString(reader.GetInt32(0));
            db.closeonnection();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            button11.ForeColor = Color.White;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button1.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button10.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            button12.ForeColor = Color.White;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
            button13.ForeColor = Color.White;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            button14.ForeColor = Color.White;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            points++;
            button13.BackColor = Color.Green;
            button13.ForeColor = Color.White;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            string q2 = $"Select  points FROM reg  WHERE surname ='{textBox1.Text}'";
            SqlDataAdapter a2 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(q2, db.getconnection());
            SqlDataReader reader;
            db.openonnection();
            reader = cmd.ExecuteReader();
            reader.Read();
            label8.Text = Convert.ToString(reader.GetInt32(0));
            db.closeonnection();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            button13.ForeColor = Color.White;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            attempts++;
           
            button23.BackColor = Color.Red;
            button23.ForeColor = Color.White;
            button23.Enabled = false;
            if (attempts > 2)
            {

                button17.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button18.Enabled = false;
                button24.Enabled = false;

            }
            if (key2 == 3)
            {


                points++;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            attempts++;
            
            button24.BackColor = Color.Red;
            button24.ForeColor = Color.White;
            button24.Enabled = false;
            if (attempts > 2)
            {

                button17.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button18.Enabled = false;

            }
            if (key2 > 3)
            {

                points++;
                //string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

                //SqlDataAdapter a = new SqlDataAdapter();
                //SqlCommand s = new SqlCommand(q, db.getconnection());
                //a.SelectCommand = s;
                //a.Fill(dt);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            attempts++;
           
            button22.BackColor = Color.Red;
            button22.ForeColor = Color.White;
            button22.Enabled = false;
            if (attempts > 2)
            {

                button17.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button18.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;

            }
            if (key2 > 3)
            {


                //string q = $"UPDATE reg SET points=points+1 WHERE surname='{textBox1.Text}'";

                //SqlDataAdapter a = new SqlDataAdapter();
                //SqlCommand s = new SqlCommand(q, db.getconnection());
                //a.SelectCommand = s;
                //a.Fill(dt);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            attempts++;

            button21.BackColor = Color.Red;
            button21.ForeColor = Color.White;
            button21.Enabled = false;
            if (attempts > 2)
            {

                button17.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button18.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;

            }
            if (key2 == 3)
            {


                points++;
            }
        }
        
        private void button25_Click(object sender, EventArgs e)
        {
                
            
            string q = $"UPDATE reg SET points={label8.Text} WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);



        }
       
        private void button26_Click(object sender, EventArgs e)
        {
            string q = $"UPDATE reg SET points={label8.Text} WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            this.Hide();
            Result r=new Result();
           r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            
            if (key2>2)
            {
                string q = $"UPDATE reg SET points=points-1 WHERE surname='{textBox1.Text}'";

                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand s = new SqlCommand(q, db.getconnection());
                a.SelectCommand = s;
                a.Fill(dt);
            }
            MessageBoxButtons f = MessageBoxButtons.OKCancel;
            string caption = "Подтверждение";
            string message = "Вы уверены,что хотите выйти? Ваши результаты не сохранятся.";
            DialogResult result = MessageBox.Show(message, caption, f);
            if (result == DialogResult.OK)
            {
                Geography g = new Geography();
                g.Show();
            }
            
        }
    }
}
