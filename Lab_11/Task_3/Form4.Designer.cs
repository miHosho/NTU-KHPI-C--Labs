﻿namespace Task_3
{
    partial class Form4
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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 151);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 18;
            label6.Text = "Відповідь: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 171);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 16;
            label4.Text = "Гіпотенуза - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 151);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 15;
            label3.Text = "Периметр - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 83);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 14;
            label2.Text = "Катет(см) - ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 63);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 12;
            label1.Text = "Гіпотенуза(см) -";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 234);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}