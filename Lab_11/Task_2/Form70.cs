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
    public partial class Form70 : Form
    {
        public string FormInfo { get; set; }
        public Form70(string infoFromPreviousForm, string name)
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

        private void Form70_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form90 form90 = new Form90(textBox1.Text, this.Text);
            form90.ShowDialog();
            label1.Text = form90.Text;
            label2.Text = form90.FormInfo;
        }
    }
}
