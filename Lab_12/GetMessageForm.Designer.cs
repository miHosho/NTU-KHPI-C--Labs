namespace Lab_12
{
    partial class GetMessageForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            label10 = new Label();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.Controls.Add(listBox1);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(label10);
            gradientPanel2.Location = new Point(12, 12);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(323, 367);
            gradientPanel2.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(43, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 264);
            listBox1.TabIndex = 19;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 8);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 18;
            label1.Text = "Inbox";
            // 
            // label10
            // 
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(43, 24);
            label10.Name = "label10";
            label10.Size = new Size(250, 22);
            label10.TabIndex = 17;
            label10.Text = "___________________________________________________________________________";
            // 
            // GetMessageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 396);
            Controls.Add(gradientPanel2);
            Name = "GetMessageForm";
            Text = "SendMessageForm";
            Load += GetMessageForm_Load;
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel2;
        private Label label1;
        private Label label10;
        private ListBox listBox1;
    }
}