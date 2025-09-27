using Lab1.logic_lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormTest5 : Form
    {
        public FormTest5()
        {
            InitializeComponent();
        }

        private void завдання1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTest4 f = new();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);


            Task2 tst = new Task2(a, b);

            int count = tst.FindTargetNumbersCount();

            label3.Text = $"К-сть парних і на 3: {count.ToString()}";
        }
    }
}
