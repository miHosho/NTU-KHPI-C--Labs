namespace Lab_12
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            gradientPanel2 = new Panel();
            button2 = new Button();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            lastName = new Label();
            label3 = new Label();
            label10 = new Label();
            button1 = new Button();
            firstName = new Label();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.Controls.Add(button2);
            gradientPanel2.Controls.Add(linkLabel2);
            gradientPanel2.Controls.Add(label4);
            gradientPanel2.Controls.Add(textBox2);
            gradientPanel2.Controls.Add(textBox1);
            gradientPanel2.Controls.Add(linkLabel1);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(lastName);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label10);
            gradientPanel2.Controls.Add(button1);
            gradientPanel2.Controls.Add(firstName);
            gradientPanel2.Location = new Point(12, 12);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(429, 261);
            gradientPanel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(24, 209);
            button2.Name = "button2";
            button2.Size = new Size(48, 37);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(186, 101);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(40, 20);
            linkLabel2.TabIndex = 25;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Save";
            linkLabel2.Visible = false;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(423, 22);
            label4.TabIndex = 24;
            label4.Text = "___________________________________________________________________________";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 22;
            textBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 21;
            textBox1.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(337, 41);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 20);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Edit profile";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 19;
            label2.Text = "LastName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 18;
            label1.Text = "FirstName:";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(101, 71);
            lastName.Name = "lastName";
            lastName.Size = new Size(93, 20);
            lastName.TabIndex = 17;
            lastName.Text = "Name Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 16;
            label3.Text = "User Profile";
            // 
            // label10
            // 
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(3, 14);
            label10.Name = "label10";
            label10.Size = new Size(423, 22);
            label10.TabIndex = 15;
            label10.Text = "___________________________________________________________________________";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(381, 207);
            button1.Name = "button1";
            button1.Size = new Size(39, 39);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(101, 46);
            firstName.Name = "firstName";
            firstName.Size = new Size(93, 20);
            firstName.TabIndex = 1;
            firstName.Text = "Name Name";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 287);
            Controls.Add(gradientPanel2);
            Name = "ProfileForm";
            Text = "Form3";
            Load += Form3_Load;
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel2;
        private Button button1;
        private Label firstName;
        private Label label3;
        private Label label10;
        private Label lastName;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private LinkLabel linkLabel2;
        private Button button2;
    }
}