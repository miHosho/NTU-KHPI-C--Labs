namespace Task_6
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
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox7.Checked = false;
            }
            else
            {
                checkBox7.Checked = true;
                checkBox6.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
                checkBox7.Checked = false;
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
            if (checkBox6.Checked)
            {
                label6.Text = price + "грн";
                label7.Text = price - 10000 + "грн";
                double discount = (price - 10000) / 10;
                label8.Text = discount + "грн";
                label9.Text = price - discount + "грн";
            }
            else
            {
                label6.Text = ConvertToBitcoin((float)price) + "btc";
                label7.Text = ConvertToBitcoin((float)price - 10000) + "btc";
                double discount = (price - 10000) / 10;
                label8.Text = ConvertToBitcoin((float)discount) + "btc";
                label9.Text = ConvertToBitcoin((float)(price - discount)) + "btc";
            }
            

        }

        public float ConvertToBitcoin(float amountInUAH)
        {
            float bitcoinRateInUAH = 1248685.37f;
            float amountInBitcoin = amountInUAH / bitcoinRateInUAH;
            return amountInBitcoin;
        }

        
    }
}