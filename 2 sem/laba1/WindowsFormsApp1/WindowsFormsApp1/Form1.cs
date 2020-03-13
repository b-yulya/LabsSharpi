using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        int l, q;
        dynamic c;
        string butt;

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int k = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(k, 2);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int k = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(k, 8);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int k = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(k, 10);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int k = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(k, 16);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                l = Int32.Parse(textBox1.Text);
                butt = (sender as Button).Text;
                textBox1.Clear();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                q = Int32.Parse(textBox1.Text);
                switch (butt)
                {
                    case "И":
                        c = l & q;
                        break;
                    case "ИЛИ":
                        c = l | q;
                        break;
                    case "ИЛИ'":
                        c = l ^ q;
                        break;
                    case "НЕ":
                        bool a = Convert.ToBoolean(l);
                        bool b = Convert.ToBoolean(q);
                        c = Convert.ToInt32(b != a);
                        break;

                }
                textBox1.Text = c.ToString();
            }
            catch { }



        }
    }
}

