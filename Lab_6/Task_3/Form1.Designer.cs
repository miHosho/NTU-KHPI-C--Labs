﻿namespace Task_3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(194, 118);
            label1.Name = "label1";
            label1.Size = new Size(62, 27);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.Location = new Point(194, 145);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 1;
            label2.Text = "Телефон";
            // 
            // label3
            // 
            label3.Location = new Point(194, 172);
            label3.Name = "label3";
            label3.Size = new Size(140, 27);
            label3.TabIndex = 2;
            label3.Text = "Поштова скринька";
            // 
            // label4
            // 
            label4.Location = new Point(214, 199);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 3;
            label4.Text = "Дата народждення";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(475, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 19);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(479, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 19);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(481, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 19);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(481, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 19);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(378, 172);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 8;
            button1.Text = "Скинути";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(370, 217);
            button2.Name = "button2";
            button2.Size = new Size(87, 39);
            button2.TabIndex = 9;
            button2.Text = "Відіслати";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}