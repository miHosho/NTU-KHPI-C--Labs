using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_7
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
            button1 = new Button();
            minutesLabel = new Label();
            label2 = new Label();
            secondsLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(136, 140);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 0;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += startButton_Click;
            // 
            // minutesLabel
            // 
            minutesLabel.AutoSize = true;
            minutesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            minutesLabel.Location = new Point(136, 27);
            minutesLabel.Name = "minutesLabel";
            minutesLabel.Size = new Size(41, 35);
            minutesLabel.TabIndex = 2;
            minutesLabel.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 27);
            label2.Name = "label2";
            label2.Size = new Size(20, 35);
            label2.TabIndex = 3;
            label2.Text = ":";
            // 
            // secondsLabel
            // 
            secondsLabel.AutoSize = true;
            secondsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            secondsLabel.Location = new Point(183, 27);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(41, 35);
            secondsLabel.TabIndex = 4;
            secondsLabel.Text = "00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(82, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(223, 33);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(52, 27);
            numericUpDown2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 7;
            label1.Text = "Хвилин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 35);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Секунд";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Location = new Point(33, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 69);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інтервал";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 184);
            Controls.Add(groupBox1);
            Controls.Add(secondsLabel);
            Controls.Add(label2);
            Controls.Add(minutesLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Секундомір";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label minutesLabel;
        private Label label2;
        private Label secondsLabel;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
    }
}