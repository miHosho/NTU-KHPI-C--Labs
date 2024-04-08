namespace Lab_12
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            gradientPanel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            label10 = new Label();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.Controls.Add(pictureBox1);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(button1);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label10);
            gradientPanel2.Location = new Point(10, 9);
            gradientPanel2.Margin = new Padding(3, 2, 3, 2);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(249, 158);
            gradientPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(7, 144);
            label1.Name = "label1";
            label1.Size = new Size(95, 10);
            label1.TabIndex = 19;
            label1.Text = "Author: Ivanchykhin Mylhailo";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(85, 98);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(73, 27);
            button1.TabIndex = 18;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(25, 68);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 17;
            label3.Text = "Welcome to FriendWave";
            // 
            // label10
            // 
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(3, 52);
            label10.Name = "label10";
            label10.Size = new Size(242, 16);
            label10.TabIndex = 16;
            label10.Text = "___________________________________________________________________________";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 178);
            Controls.Add(gradientPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StartForm";
            Text = "Form4";
            Load += StartForm_Load;
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel2;
        private Label label3;
        private Label label10;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}