namespace Task_3
{
    partial class Form3
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
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 41);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 9;
            label6.Text = "Відповідь: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 61);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 8;
            label4.Text = "Гіпотенуза - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 41);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 7;
            label3.Text = "Периметр - ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 125);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label3;
    }
}