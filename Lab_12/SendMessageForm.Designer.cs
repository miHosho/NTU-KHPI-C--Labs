namespace Lab_12
{
    partial class SendMessageForm
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
            gradientPanel2 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.Controls.Add(textBox2);
            gradientPanel2.Controls.Add(label4);
            gradientPanel2.Controls.Add(textBox1);
            gradientPanel2.Controls.Add(label10);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(button1);
            gradientPanel2.Controls.Add(richTextBox1);
            gradientPanel2.Location = new Point(12, 12);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(323, 367);
            gradientPanel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Honeydew;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(84, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 25);
            textBox2.TabIndex = 19;
            // 
            // label4
            // 
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(79, 68);
            label4.Name = "label4";
            label4.Size = new Size(216, 22);
            label4.TabIndex = 18;
            label4.Text = "___________________________________________________________________________";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(93, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 25);
            textBox1.TabIndex = 17;
            // 
            // label10
            // 
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(85, 28);
            label10.Name = "label10";
            label10.Size = new Size(235, 22);
            label10.TabIndex = 16;
            label10.Text = "___________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 5;
            label3.Text = "Text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 4;
            label2.Text = "Theme:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 17);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 2;
            label1.Text = "To whom:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(201, 315);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(16, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(279, 169);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // SendMessageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 396);
            Controls.Add(gradientPanel2);
            Name = "SendMessageForm";
            Text = "SendMessageForm";
            Load += SendMessageForm_Load;
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel2;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label10;
    }
}