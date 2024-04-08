namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или клавишей Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToIndianRupees();
            ConvertToUAH();
        }
        private void ConvertToIndianRupees()
        {
            float exchangeRate = 2.30f;

            if (float.TryParse(textBox1.Text, out float amountInHryvnia))
            {
                float amountInRupees = amountInHryvnia * exchangeRate;
                label2.Text = amountInRupees.ToString("N2") + " INR"; // два знака после запятой
            }
        }
        private void ConvertToUAH()
        {
            float exchangeRate = 0.43f;

            if (float.TryParse(textBox2.Text, out float amountInRS))
            {
                float amountInUAH = amountInRS * exchangeRate;
                label4.Text = amountInUAH.ToString("N2") + " UAH";
            }
        }

        
    }
}