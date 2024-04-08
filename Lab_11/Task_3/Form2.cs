using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form2 : Form
    {
        public Form2(int hipotenuza, int katet)
        {
            InitializeComponent();
            label1.Text = "Гіпотенуза - " + hipotenuza.ToString();
            label2.Text = "Катет - " + katet.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
