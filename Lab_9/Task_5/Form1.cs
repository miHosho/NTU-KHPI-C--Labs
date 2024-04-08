namespace Task_5
{
    public partial class Form1 : Form
    {
        private double cover = 350;
        private double OS = 1200;
        private double glass = 320;
        private double memory1 = 2500;
        private double memory2 = 4200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox4.Checked = false;
                checkBox5.Checked = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
                checkBox5.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 10000;
            if (checkBox1.Checked)
            {
                price += cover;
            }
            if (checkBox2.Checked)
            {
                price += OS;
            }
            if (checkBox3.Checked)
            {
                price += glass;
            }
            if (checkBox4.Checked)
            {
                price += memory1;
            }
            else if (checkBox5.Checked)
            {
                price += memory2;
            }
            label6.Text = price + "грн";
            label7.Text = price - 10000 + "грн";
            double discount = (price - 10000) / 10;
            label8.Text = discount  + "грн";
            label9.Text = price - discount + "грн";
        }
    }
}