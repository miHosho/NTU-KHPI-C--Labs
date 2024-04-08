using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form2 : Form
    {
        public Form2(int x, int y, int z)
        {
            InitializeComponent();
            label1.Text = "X - " + x.ToString();
            label2.Text = "Y - " + y.ToString();
            label3.Text = "Z - " + z.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
