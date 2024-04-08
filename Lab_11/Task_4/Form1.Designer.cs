namespace Task_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "X -";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 66);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 2;
            label2.Text = "Y - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 193);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "123123";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 9);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Вхідні дані:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 193);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 6;
            label6.Text = "Відповідь: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(11, 149);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 8;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 149);
            button2.Name = "button2";
            button2.Size = new Size(69, 29);
            button2.TabIndex = 9;
            button2.Text = "Дані";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(199, 149);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 10;
            button3.Text = "Результати";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(301, 139);
            button4.Name = "button4";
            button4.Size = new Size(117, 49);
            button4.TabIndex = 11;
            button4.Text = "Дані та результати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 95);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 12;
            label7.Text = "Z - ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 9);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 15;
            label8.Text = "Формула:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 257);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label8;
    }
}