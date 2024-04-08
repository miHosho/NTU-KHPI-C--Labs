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
    public partial class Form4 : Form
    {
        public Form4(double result, double hipotenuza, int katet)
        {
            InitializeComponent();
            label1.Text = "Гіпотенуза - " + hipotenuza.ToString();
            label2.Text = "Катет - " + katet.ToString();
            label3.Text = "Периметр - " + result.ToString("N2");
            label4.Text = "Гіпотенуза - " + hipotenuza.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
