using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form80 form80 = new Form80();
            form80.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form70 form70 = new Form70();
            form70.ShowDialog();
        }
    }
}
