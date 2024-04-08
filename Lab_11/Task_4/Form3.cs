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
    public partial class Form3 : Form
    {
        public Form3(int x, int y, int z)
        {
            InitializeComponent();
            label6.Text = "Відповідь: " + Calculate(x, y, z).ToString("N2");
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private double Calculate(int x, int y, int z)
        {
            double result = 0;
            for (int i = 0; i <= x * y * z; i++)
            {
                if (i == z)
                    continue;

                result += (Math.Cos(y) * Math.Sin(x)) / (i - z);
            }
            return result;
        }
    }
}
