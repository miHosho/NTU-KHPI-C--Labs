using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class ReadMessageForm : Form
    {
        public ReadMessageForm(string theme, string text)
        {
            InitializeComponent();
            label3.Text = theme;
            label4.Text = text;
        }

        private void ReadMessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
