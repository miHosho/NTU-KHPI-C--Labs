namespace Task_8
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
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            fontComboBox = new ComboBox();
            colorComboBox = new ComboBox();
            sizeComboBox = new ComboBox();
            styleComboBox = new ComboBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 608);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.Click += richTextBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(805, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(54, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveButton_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(59, 24);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 676);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // fontComboBox
            // 
            fontComboBox.FormattingEnabled = true;
            fontComboBox.Location = new Point(12, 31);
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(151, 28);
            fontComboBox.TabIndex = 5;
            fontComboBox.SelectedIndexChanged += fontComboBox_SelectedIndexChanged;
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Location = new Point(169, 31);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(71, 28);
            colorComboBox.TabIndex = 6;
            colorComboBox.SelectedIndexChanged += colorComboBox_SelectedIndexChanged;
            // 
            // sizeComboBox
            // 
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Location = new Point(356, 31);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(51, 28);
            sizeComboBox.TabIndex = 7;
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            // 
            // styleComboBox
            // 
            styleComboBox.FormattingEnabled = true;
            styleComboBox.Location = new Point(246, 31);
            styleComboBox.Name = "styleComboBox";
            styleComboBox.Size = new Size(104, 28);
            styleComboBox.TabIndex = 8;
            styleComboBox.SelectedIndexChanged += styleComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(694, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 700);
            Controls.Add(button1);
            Controls.Add(styleComboBox);
            Controls.Add(sizeComboBox);
            Controls.Add(colorComboBox);
            Controls.Add(fontComboBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Label label1;
        private ComboBox fontComboBox;
        private ComboBox colorComboBox;
        private ComboBox sizeComboBox;
        private ComboBox styleComboBox;
        private Button button1;
    }
}