using Lab1.logic_lab2;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            n = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            Arrays2D arr = new Arrays2D(n, m);
            DataGridViewTextBoxColumn dvage;

            for (int i = 0; i < m; i++)
            {
                dvage = new DataGridViewTextBoxColumn();
                dvage.Width = 40;
                dataGridView1.Columns.Add(dvage);
            }

            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = arr.X_length;
            dataGridView1.ColumnCount = arr.Y_length;
            for (int i = 0; i < arr.X_length; i++)
                for (int j = 0; j < arr.Y_length; j++)
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();

            var res = arr.PositionInfo;
            label3.Text = $"Позиція: {res.Item4}";
            label4.Text = $"Індекс: [{res.Item2},{res.Item3}]";
            label5.Text = $"Значення: {res.Item1}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
