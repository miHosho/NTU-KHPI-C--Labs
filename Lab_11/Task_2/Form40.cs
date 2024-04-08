using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form40 : Form
    {
        public string FormInfo { get; set; }
        public Form40(string infoFromPreviousForm, string name)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = "Переданая инфа: " + infoFromPreviousForm;
            this.FormClosing += GetInfo;
        }
        private void GetInfo(object sender, FormClosingEventArgs e)
        {
            FormInfo = textBox1.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form100 form100 = new Form100(textBox1.Text, this.Text);
            form100.ShowDialog();
            label1.Text = form100.Text;
            label2.Text = form100.FormInfo;
        }
    }
}
