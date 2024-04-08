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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 192, 0);
            textBox1.Location = new Point(35, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 52);
            textBox1.TabIndex = 0;
            textBox1.Text = "GY8WE6SAI7O8IFSUHJ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Yellow;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Underline, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(35, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 36);
            textBox2.TabIndex = 1;
            textBox2.Text = "ERDTSDHSGDF";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(255, 128, 255);
            textBox3.Location = new Point(35, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(417, 39);
            textBox3.TabIndex = 2;
            textBox3.Text = "123123";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}