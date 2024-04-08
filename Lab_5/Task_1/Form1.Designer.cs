namespace Task_1
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(500, 50);
            label1.TabIndex = 0;
            label1.Text = "3w5ehrdtgn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(500, 50);
            label2.TabIndex = 1;
            label2.Text = "3w5ehrdtgn";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 255);
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(500, 50);
            label3.TabIndex = 2;
            label3.Text = "3w5ehrdtgn";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}