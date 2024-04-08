using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_2
{
    public partial class Form30 : Form
    {
        public string FormInfo { get; set; }
        public Form30(string infoFromPreviousForm, string name)
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
            Form50 form50 = new Form50(textBox1.Text, this.Text);
            form50.ShowDialog();
            label1.Text = form50.Text;
            label2.Text = form50.FormInfo;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form60 form60 = new Form60(textBox1.Text, this.Text);
            form60.ShowDialog();
            label1.Text = form60.Text;
            label2.Text = form60.FormInfo;
        }
    }
}
