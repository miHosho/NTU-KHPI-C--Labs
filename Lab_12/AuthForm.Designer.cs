namespace Lab_12
{
    partial class AuthForm
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label10 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.Controls.Add(linkLabel1);
            gradientPanel2.Controls.Add(button1);
            gradientPanel2.Controls.Add(label6);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label4);
            gradientPanel2.Controls.Add(label10);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(textBox2);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(textBox1);
            gradientPanel2.Location = new Point(12, 12);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(463, 273);
            gradientPanel2.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.Location = new Point(291, 214);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(239, 174);
            button1.Name = "button1";
            button1.Size = new Size(170, 37);
            button1.TabIndex = 19;
            button1.Text = "Log-in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(18, 239);
            label6.Name = "label6";
            label6.Size = new Size(178, 19);
            label6.TabIndex = 18;
            label6.Text = "Incorrect email or password";
            label6.Visible = false;
            // 
            // label3
            // 
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(38, 144);
            label3.Name = "label3";
            label3.Size = new Size(398, 22);
            label3.TabIndex = 17;
            label3.Text = "________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 21);
            label4.Name = "label4";
            label4.Size = new Size(191, 28);
            label4.TabIndex = 15;
            label4.Text = "User Authorization";
            // 
            // label10
            // 
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(38, 34);
            label10.Name = "label10";
            label10.Size = new Size(398, 22);
            label10.TabIndex = 14;
            label10.Text = "________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 115);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(188, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 32);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(188, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 32);
            textBox1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 294);
            Controls.Add(gradientPanel2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel2;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label10;
        private Label label4;
        private Label label6;
        private Label label3;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}