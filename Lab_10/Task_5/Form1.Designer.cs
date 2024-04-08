namespace Task_5
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            principalTextBox = new TextBox();
            monthsTextBox = new TextBox();
            interestRateTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(12, 192);
            listView1.Name = "listView1";
            listView1.Size = new Size(475, 188);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Місяць";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Борг";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Відсоток";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Платіж";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "Сума:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 63);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Термін (міс):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 97);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Відсоткова ставка:";
            // 
            // principalTextBox
            // 
            principalTextBox.Location = new Point(192, 31);
            principalTextBox.Name = "principalTextBox";
            principalTextBox.Size = new Size(125, 27);
            principalTextBox.TabIndex = 4;
            // 
            // monthsTextBox
            // 
            monthsTextBox.Location = new Point(192, 64);
            monthsTextBox.Name = "monthsTextBox";
            monthsTextBox.Size = new Size(125, 27);
            monthsTextBox.TabIndex = 5;
            // 
            // interestRateTextBox
            // 
            interestRateTextBox.Location = new Point(192, 97);
            interestRateTextBox.Name = "interestRateTextBox";
            interestRateTextBox.Size = new Size(125, 27);
            interestRateTextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(192, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 392);
            Controls.Add(button1);
            Controls.Add(interestRateTextBox);
            Controls.Add(monthsTextBox);
            Controls.Add(principalTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Фінансовий калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox principalTextBox;
        private TextBox monthsTextBox;
        private TextBox interestRateTextBox;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}