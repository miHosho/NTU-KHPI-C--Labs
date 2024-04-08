namespace Task_2
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(578, 304);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 35);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(293, 3);
            button3.Name = "button3";
            button3.Size = new Size(50, 29);
            button3.TabIndex = 2;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(239, 3);
            button2.Name = "button2";
            button2.Size = new Size(50, 29);
            button2.TabIndex = 1;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Папка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(584, 170);
            button4.Name = "button4";
            button4.Size = new Size(84, 31);
            button4.TabIndex = 2;
            button4.Text = "Start";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(626, 98);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 75);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "Interval:";
            // 
            // button5
            // 
            button5.Location = new Point(674, 170);
            button5.Name = "button5";
            button5.Size = new Size(84, 31);
            button5.TabIndex = 5;
            button5.Text = "Stop";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 342);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button5;
    }
}