using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace викторина
{
    public partial class Music : Form
    {
        static int points = 0;
        Datebase db=new Datebase();
        public Music()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show("Вы уверены,что хотите выйти? Ваши изменения не сохранятся", "Подверждение", buttons);
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                Test t = new Test();
                
                t.Show();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = $"UPDATE reg SET points={label2.Text} WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            Music2 m = new Music2();
            m.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            button11.ForeColor = Color.White;
            button13.BackColor = Color.Green;
            button13.ForeColor = Color.White;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            button12.ForeColor = Color.White;
            button13.BackColor = Color.Green;
            button13.ForeColor = Color.White;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Green;
            button13.ForeColor = Color.White;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            string q = $"UPDATE reg2 SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            points += 1;
            label2.Text = points.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            button14.ForeColor = Color.White;
            button13.BackColor = Color.Green;
            button13.ForeColor = Color.White;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }
        DataTable dt = new DataTable();
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            string q = $"UPDATE reg2 SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            points += 1;
            label2.Text = points.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.White;
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button6.ForeColor = Color.White;
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            string q = $"UPDATE reg2 SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            points += 1;
            label2.Text = points.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button7.ForeColor = Color.White;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            button9.ForeColor = Color.White;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button8.ForeColor = Color.White;
            button10.BackColor = Color.Green;
            button10.ForeColor = Color.White;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
            button16.ForeColor = Color.White;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            string q = $"UPDATE reg2 SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            points += 1;
            label2.Text = points.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
            button16.ForeColor = Color.White;
            button15.BackColor = Color.Red;
            button15.ForeColor = Color.White;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
            button16.ForeColor = Color.White;
            button17.BackColor = Color.Red;
            button17.ForeColor = Color.White;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
            button16.ForeColor = Color.White;
            button18.BackColor = Color.Red;
            button18.ForeColor = Color.White;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Green;
            button19.ForeColor = Color.White;
            button20.BackColor = Color.Red;
            button20.ForeColor = Color.White;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Green;
            button19.ForeColor = Color.White;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            string q = $"UPDATE reg2 SET points=points+1 WHERE surname='{textBox1.Text}'";

            SqlDataAdapter a = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(q, db.getconnection());
            a.SelectCommand = s;
            a.Fill(dt);
            points += 1;
            label2.Text = points.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Green;
            button19.ForeColor = Color.White;
            button22.BackColor = Color.Red;
            button22.ForeColor = Color.White;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Green;
            button19.ForeColor = Color.White;
            button21.BackColor = Color.Red;
            button21.ForeColor = Color.White;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
        }
    }
}
