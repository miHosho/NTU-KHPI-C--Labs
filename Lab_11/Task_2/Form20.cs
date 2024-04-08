using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form20 : Form
    {
        public string FormInfo { get; set; }
        public Form20(string infoFromPreviousForm, string name)
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
        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form80 form80 = new Form80(textBox1.Text, this.Text);
            form80.ShowDialog();
            label1.Text = form80.Text;
            label2.Text = form80.FormInfo;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form70 form70 = new Form70(textBox1.Text, this.Text);
            form70.ShowDialog();
            label1.Text = form70.Text;
            label2.Text = form70.FormInfo;
        }
    }
}
