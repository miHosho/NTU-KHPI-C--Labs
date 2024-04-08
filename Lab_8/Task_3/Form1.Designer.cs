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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 69);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "Виберіть ваші інтереси:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 92);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Спорт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 122);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Мандрівки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 152);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Майстрування";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 182);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "Малювання";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(419, 92);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(419, 122);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 6;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(419, 152);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 7;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(419, 182);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 8;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(231, 222);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Вибрати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 222);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Відмовитися";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private Button button2;
    }
}