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
    public partial class Form3 : Form
    {
        public Form3(double result, double hipotenuza)
        {
            InitializeComponent();
            label3.Text = "Периметр - " + result.ToString("N2");
            label4.Text = "Гіпотенуза - " + hipotenuza.ToString();
        }
    private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
