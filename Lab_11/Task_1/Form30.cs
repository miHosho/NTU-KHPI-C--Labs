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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form50 form50 = new Form50();
            form50.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form60 form60 = new Form60();
            form60.ShowDialog();
        }
    }
}
