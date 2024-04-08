using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Зібрання творів: У 6 т. — К., 2003. — Т. 1: Поезія 1837-1847. — С. 371; С. 750-752";
            label1.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Gray;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(10, 10);
            label1.AutoSize = false;
            label1.Size = new Size(this.ClientSize.Width - 20, label1.Height);

            Label label2 = new Label();
            label2.Text = "Як умру, то поховайте";
            label2.Font = new Font("Arial", 17, FontStyle.Underline);
            label2.ForeColor = Color.Brown;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Location = new Point(10, 50);
            label2.AutoSize = false;
            label2.Size = new Size(this.ClientSize.Width - 20, label2.Height);

            Label label3 = new Label();
            label3.Text = "Тарас Шевченко";
            label3.Font = new Font("Arial", 13, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(10, 90);
            label3.AutoSize = false;
            label3.Size = new Size(this.ClientSize.Width - 20, label3.Height);

            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
        }
    }
}
