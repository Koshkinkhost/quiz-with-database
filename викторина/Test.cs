using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace викторина
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Geography g = new Geography();
            g.Show();
            
            g.textBox1.Text = textBox1.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sport s = new Sport();
            s.Show();
            s.textBox1.Text = textBox1.Text;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Music m = new Music();
            m.Show();
            m.textBox1.Text = textBox1.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
