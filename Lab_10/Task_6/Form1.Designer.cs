using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_6
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
            button2 = new Button();
            minutesLabel = new Label();
            label2 = new Label();
            secondsLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(112, 75);
            button1.Name = "button1";
            button1.Size = new Size(73, 29);
            button1.TabIndex = 0;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += startButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(192, 75);
            button2.Name = "button2";
            button2.Size = new Size(73, 29);
            button2.TabIndex = 1;
            button2.Text = "Стоп";
            button2.UseVisualStyleBackColor = true;
            button2.Click += stopButton_Click;
            // 
            // minutesLabel
            // 
            minutesLabel.AutoSize = true;
            minutesLabel.Location = new Point(160, 42);
            minutesLabel.Name = "minutesLabel";
            minutesLabel.Size = new Size(25, 20);
            minutesLabel.TabIndex = 2;
            minutesLabel.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 42);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 3;
            label2.Text = ":";
            // 
            // secondsLabel
            // 
            secondsLabel.AutoSize = true;
            secondsLabel.Location = new Point(192, 42);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(25, 20);
            secondsLabel.TabIndex = 4;
            secondsLabel.Text = "00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 168);
            Controls.Add(secondsLabel);
            Controls.Add(label2);
            Controls.Add(minutesLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Секундомір";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label minutesLabel;
        private Label label2;
        private Label secondsLabel;
        private System.Windows.Forms.Timer timer1;
    }
}