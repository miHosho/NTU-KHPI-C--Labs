namespace Task_1
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                ConvertToIndianRupees();
            }
        }
        private void ConvertToIndianRupees()
        {
            float exchangeRate = 2.30f;

            if (float.TryParse(textBox1.Text, out float amountInHryvnia))
            {
                float amountInRupees = amountInHryvnia * exchangeRate;

                label2.Text = amountInRupees.ToString("N2") + " INR"; // два знака после запятой
            }
            else
            {
                MessageBox.Show("Введите корректное число в гривнах.");
            }
        }

    }
}