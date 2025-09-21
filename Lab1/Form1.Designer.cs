namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            масивиToolStripMenuItem = new ToolStripMenuItem();
            одновимірнийМасивToolStripMenuItem = new ToolStripMenuItem();
            двовимірнийМасивToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(493, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(711, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 58);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 4;
            label1.Text = "Xn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 64);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 5;
            label2.Text = "Xn";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 61);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 6;
            label3.Text = "h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 58);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 7;
            label4.Text = "a";
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Location = new Point(974, 60);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView1.Location = new Point(36, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(579, 645);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 8;
            x.Name = "x";
            x.ReadOnly = true;
            x.Width = 150;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 8;
            y.Name = "y";
            y.ReadOnly = true;
            y.Width = 150;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(680, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 143);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(647, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(750, 216);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { масивиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1423, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // масивиToolStripMenuItem
            // 
            масивиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одновимірнийМасивToolStripMenuItem, двовимірнийМасивToolStripMenuItem });
            масивиToolStripMenuItem.Name = "масивиToolStripMenuItem";
            масивиToolStripMenuItem.Size = new Size(91, 29);
            масивиToolStripMenuItem.Text = "Масиви";
            // 
            // одновимірнийМасивToolStripMenuItem
            // 
            одновимірнийМасивToolStripMenuItem.Name = "одновимірнийМасивToolStripMenuItem";
            одновимірнийМасивToolStripMenuItem.Size = new Size(292, 34);
            одновимірнийМасивToolStripMenuItem.Text = "Одновимірний масив";
            одновимірнийМасивToolStripMenuItem.Click += одновимірнийМасивToolStripMenuItem_Click;
            // 
            // двовимірнийМасивToolStripMenuItem
            // 
            двовимірнийМасивToolStripMenuItem.Name = "двовимірнийМасивToolStripMenuItem";
            двовимірнийМасивToolStripMenuItem.Size = new Size(292, 34);
            двовимірнийМасивToolStripMenuItem.Text = "Двовимірний масив";
            двовимірнийМасивToolStripMenuItem.Click += двовимірнийМасивToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 820);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem масивиToolStripMenuItem;
        private ToolStripMenuItem одновимірнийМасивToolStripMenuItem;
        private ToolStripMenuItem двовимірнийМасивToolStripMenuItem;
    }
}
