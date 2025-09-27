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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class FormTest4 : Form
    {
        public FormTest4()
        {
            InitializeComponent();
        }

        private void FormTest4_Load(object sender, EventArgs e)
        {

        }

        private void завдання2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTest5 f = new();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new();
            f.Show(); this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            Lab3_iss1 tst = new Lab3_iss1(a, b, c);

            int count = tst.calculateNumbers();

            label4.Text = $"К-сть кратних 27: {count}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
