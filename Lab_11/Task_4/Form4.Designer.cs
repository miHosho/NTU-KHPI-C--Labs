namespace Task_4
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 157);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 16;
            label4.Text = "otvet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 103);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 15;
            label3.Text = "Z";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 83);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 14;
            label2.Text = "Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 63);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 12;
            label1.Text = "X";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 234);
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}