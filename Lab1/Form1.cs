using Lab1.logic;
using ScottPlot;
using ScottPlot.WinForms;

namespace Lab1
{
    public partial class Form1 : Form
    {

        private FormsPlot plot;

        public Form1()
        {
            InitializeComponent();
            InitPlot();

            this.Load += (_, __) =>
            {
                double[] xs = Enumerable.Range(0, 200).Select(i => i / 20.0).ToArray();
                double[] ys = xs.Select(x => Math.Sin(x)).ToArray();
                plot.Plot.Clear();
                plot.Plot.Add.Scatter(xs, ys);
                plot.Refresh();
            };
        }

        private void InitPlot()
        {
            plot = new FormsPlot
            {
                Name = "formsPlot1",
                Dock = DockStyle.Bottom,
                Height = 380
            };
            Controls.Add(plot);
            plot.BringToFront();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            var tabul = new Tabul();

            double xn = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);

            //dataGridView1.Rows.Clear();
            tabul.tab(xn, xk, h, a);

            double[] xs = new double[tabul.n];
            double[] ys = new double[tabul.n];

            for (int i = 0; i < tabul.n; i++)
            {
                double x = Math.Round(tabul.xy[i, 0], 2);
                double y = Math.Round(tabul.xy[i, 1], 3);

                dataGridView1.Rows.Add(x, y);

                xs[i] = x;
                ys[i] = y;
            }

            plot.Plot.Clear();
            plot.Plot.Add.Scatter(xs, ys);
            plot.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void одновимірнийМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new();
            f.Show();
            this.Hide();
        }

        private void двовимірнийМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new();
            f.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
