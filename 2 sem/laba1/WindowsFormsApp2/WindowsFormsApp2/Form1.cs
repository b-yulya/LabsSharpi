using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        List<int> Spis = new List<int>();
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                a = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < a; i++)
                {
                    Spis.Add(rand.Next(100));
                }
                for (int i = 0; i < a; i++)
                {
                    textBox2.Text += (i + 1 + " элемент: " + Spis[i]).ToString() + "\r\n";
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 1;
            textBox3.Clear();
            Spis.Sort();
            for (int i = a - 1; i >= 0; i--)
            {
                textBox3.Text += (k + " элемент: " + Spis[i]).ToString() + "\r\n";
                k++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Spis.Sort();
            for (int i = 0; i < a; i++)
            {
                textBox3.Text += (i + 1 + " элемент: " + Spis[i]).ToString() + "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            var max = Spis.Max(t => t);
            textBox3.Text += "Максимальный элемент: " + max.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            var sum = Spis.Sum(t => t);
            textBox3.Text += "Сумма всех элементов: " + sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            var more = Spis.Where(t => t > 50).OrderBy(t => t);
            textBox3.Text = "Элементы, значение которых больше 50:" + "\r\n";
            textBox3.Text += String.Join(" ", more);


        }
    }
}
