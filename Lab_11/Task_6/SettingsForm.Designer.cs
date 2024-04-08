namespace Task_6
{
    partial class SettingsForm
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
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 0;
            button1.Text = "BackgroundColor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 43);
            button2.TabIndex = 1;
            button2.Text = "Font";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(250, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 43);
            button3.TabIndex = 2;
            button3.Text = "Fore Color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(396, 166);
            button5.Name = "button5";
            button5.Size = new Size(114, 40);
            button5.TabIndex = 4;
            button5.Text = "Применить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 218);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}