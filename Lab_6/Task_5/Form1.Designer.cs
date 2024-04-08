namespace Task_5
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(417, 61);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(426, 104);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 1;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(464, 84);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 2;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(403, 126);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 3;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(207, 58);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 4;
            label1.Text = "Спорт";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(207, 81);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 5;
            label2.Text = "Мандрівки";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(207, 101);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 6;
            label3.Text = "Майстрування";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(207, 123);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 7;
            label4.Text = "Малювання";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Location = new Point(284, 38);
            label5.Name = "label5";
            label5.Size = new Size(198, 20);
            label5.TabIndex = 8;
            label5.Text = "Виберіть ващі інтереси:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Location = new Point(293, 142);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 9;
            button1.Text = "Вибрати";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(400, 142);
            button2.Name = "button2";
            button2.Size = new Size(122, 38);
            button2.TabIndex = 10;
            button2.Text = "Відмовитися";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}