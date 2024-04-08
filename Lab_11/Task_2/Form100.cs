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
    public partial class Form100 : Form
    {
        public string FormInfo { get; set; }
        public Form100(string infoFromPreviousForm, string name)
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
    }
}
