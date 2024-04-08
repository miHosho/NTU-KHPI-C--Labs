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
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            label9 = new Label();
            groupBox4 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Контактна інформація";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(280, 44);
            maskedTextBox1.Mask = "+38(000) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(140, 19);
            maskedTextBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(280, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 19);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(280, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 10, 20, 12, 9, 2, 0);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(280, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 19);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Дата відвідування";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Пошта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Телефон";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 153);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Персональна інформація";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(280, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(175, 67);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Грецька ", "Італійська ", "Французька ", "Іспанська ", "Китайська ", "Японська ", "Індійська ", "Тайська", "Мексиканська", "Бразильська", "Турецька", "Російська", "Українська", "Арабська", "В'єтнамська" });
            comboBox2.Location = new Point(280, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 19);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "18+", "30+", "45+", "80+" });
            comboBox1.Location = new Point(280, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(67, 19);
            comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(12, 72);
            label6.Name = "label6";
            label6.Size = new Size(230, 40);
            label6.TabIndex = 2;
            label6.Text = "Які страви ви б хотіли бачити в меню?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 47);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 1;
            label7.Text = "Улюблена кухня";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 23);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 0;
            label8.Text = "Вік";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(12, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(506, 267);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Оцінка нашої установи";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(12, 216);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(45, 24);
            radioButton6.TabIndex = 7;
            radioButton6.Text = "Ні";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(12, 186);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(53, 24);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "Так";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 163);
            label9.Name = "label9";
            label9.Size = new Size(450, 20);
            label9.TabIndex = 1;
            label9.Text = "Чи будете рекомендувати нашу установу друзям та знайомим?";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton9);
            groupBox4.Controls.Add(radioButton10);
            groupBox4.Controls.Add(radioButton11);
            groupBox4.Controls.Add(radioButton12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(12, 300);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(506, 160);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Оцінка нашої установи";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(12, 136);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(331, 24);
            radioButton9.TabIndex = 5;
            radioButton9.Text = "Оптимальне співвідношення ціни та якості";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(12, 106);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(101, 24);
            radioButton10.TabIndex = 4;
            radioButton10.Text = "Порадили";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(12, 76);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(154, 24);
            radioButton11.TabIndex = 3;
            radioButton11.Text = "Побачив рекламу";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Checked = true;
            radioButton12.Location = new Point(12, 46);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(221, 24);
            radioButton12.TabIndex = 2;
            radioButton12.TabStop = true;
            radioButton12.Text = "Недалеко від роботи /дому";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 23);
            label11.Name = "label11";
            label11.Size = new Size(214, 20);
            label11.TabIndex = 0;
            label11.Text = "Чому обрали нашу установу?";
            // 
            // button1
            // 
            button1.Location = new Point(12, 573);
            button1.Name = "button1";
            button1.Size = new Size(113, 36);
            button1.TabIndex = 13;
            button1.Text = "Відправити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(141, 573);
            button2.Name = "button2";
            button2.Size = new Size(104, 36);
            button2.TabIndex = 14;
            button2.Text = "Очистити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 633);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Анкета відвідувача ресторана:";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private Label label9;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private GroupBox groupBox4;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private Label label11;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
    }
}