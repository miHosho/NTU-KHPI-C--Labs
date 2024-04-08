namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int amount))
            {
                if (radioButton1.Checked)
                {
                    label2.Text = (amount * 16000).ToString() + "грн";
                }
                else if (radioButton2.Checked)
                {
                    label2.Text = (amount * 42000).ToString() + "грн";
                }
                else
                {
                    label2.Text = (amount * 5000).ToString() + "грн";
                }
            }
        }
    }
}