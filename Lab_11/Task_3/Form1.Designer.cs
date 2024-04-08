namespace Task_3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 83);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Гіпотенуза(см) -";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 116);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Катет(см) - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 193);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "Периметр - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 213);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 4;
            label4.Text = "Гіпотенуза - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 33);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Дано:";
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
            textBox2.Location = new Point(179, 109);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 257);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}