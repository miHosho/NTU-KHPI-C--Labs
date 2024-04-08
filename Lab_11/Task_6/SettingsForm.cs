using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class SettingsForm : Form
    {
        public Color SelectedBackgroundColor;
        public Font SelectedFontSize;
        public Color SelectedTextColor;
        public SettingsForm(Color BackColor, Font Font, Color ForeColor)
        {
            InitializeComponent();
            SelectedBackgroundColor = BackColor;
            SelectedFontSize = Font;
            SelectedTextColor = ForeColor;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SelectedBackgroundColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            SelectedFontSize = fontDialog1.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SelectedTextColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
