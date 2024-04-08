using Microsoft.VisualBasic;
using System.Reflection.Emit;

namespace Task_2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20(textBox1.Text, this.Text);
            form20.ShowDialog();
            label1.Text = form20.Text;
            label2.Text = form20.FormInfo;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30(textBox1.Text, this.Text);
            form30.ShowDialog();
            label1.Text = form30.Text;
            label2.Text = form30.FormInfo;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form40 form40 = new Form40(textBox1.Text, this.Text);
            form40.ShowDialog();
            label1.Text = form40.Text;
            label2.Text = form40.FormInfo;
        }
    }
}