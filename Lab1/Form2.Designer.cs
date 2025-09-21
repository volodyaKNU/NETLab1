namespace Lab1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            A = new DataGridViewTextBoxColumn();
            Temperature = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(646, 667);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { A, Temperature });
            dataGridView1.Location = new Point(21, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(367, 633);
            dataGridView1.TabIndex = 1;
            // 
            // A
            // 
            A.HeaderText = "Дата";
            A.MinimumWidth = 8;
            A.Name = "A";
            A.Width = 150;
            // 
            // Temperature
            // 
            Temperature.HeaderText = "Температура";
            Temperature.MinimumWidth = 8;
            Temperature.Name = "Temperature";
            Temperature.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 59);
            label1.Name = "label1";
            label1.Size = new Size(354, 25);
            label1.TabIndex = 2;
            label1.Text = "Дані \u007fпро температуру повітря нижче -10";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 167);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 127);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 4;
            label2.Text = "Декада (1-3)";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 265);
            button2.Name = "button2";
            button2.Size = new Size(345, 34);
            button2.TabIndex = 5;
            button2.Text = "Розрахувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 363);
            label3.Name = "label3";
            label3.Size = new Size(266, 25);
            label3.TabIndex = 6;
            label3.Text = "Дні з температурою нижче -10";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(685, 363);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 736);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn Temperature;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}