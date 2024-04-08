namespace Task_8
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
                    if (amount < 6)
                    {
                        label3.Text = "�������� ����:";
                        label2.Text = (amount * 16000).ToString() + "���";
                    }
                    else
                    {
                        label3.Text = "������ ����:";
                        label2.Text = ((amount * 16000)*0.85).ToString() + "���";
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (amount < 6)
                    {
                        label3.Text = "�������� ����:";
                        label2.Text = (amount * 42000).ToString() + "���";
                    }
                    else
                    {
                        label3.Text = "������ ����:";
                        label2.Text = ((amount * 42000) * 0.7).ToString() + "���";
                    }
                }
                else
                {
                    if (amount < 6)
                    {
                        label3.Text = "�������� ����:";
                        label2.Text = (amount * 5000).ToString() + "���";
                    }
                    else
                    {
                        label3.Text = "������ ����:";
                        label2.Text = ((amount * 5000) * 0.9).ToString() + "���";
                    }
                }
            }
        }
    }
}