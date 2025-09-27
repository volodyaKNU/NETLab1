namespace Lab1
{
    partial class FormTest5
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
            menuStrip1 = new MenuStrip();
            завдання1ToolStripMenuItem = new ToolStripMenuItem();
            завдання2ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { завдання1ToolStripMenuItem, завдання2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // завдання1ToolStripMenuItem
            // 
            завдання1ToolStripMenuItem.Name = "завдання1ToolStripMenuItem";
            завдання1ToolStripMenuItem.Size = new Size(120, 29);
            завдання1ToolStripMenuItem.Text = "Завдання 1";
            завдання1ToolStripMenuItem.Click += завдання1ToolStripMenuItem_Click;
            // 
            // завдання2ToolStripMenuItem
            // 
            завдання2ToolStripMenuItem.Name = "завдання2ToolStripMenuItem";
            завдання2ToolStripMenuItem.Size = new Size(120, 29);
            завдання2ToolStripMenuItem.Text = "Завдання 2";
            // 
            // button1
            // 
            button1.Location = new Point(677, 395);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 60);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 4;
            label1.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 59);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 5;
            label2.Text = "b";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(54, 225);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 225);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 7;
            label3.Text = "К-сть парних і на 3:";
            // 
            // FormTest5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTest5";
            Text = "FormTest5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem завдання1ToolStripMenuItem;
        private ToolStripMenuItem завдання2ToolStripMenuItem;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}