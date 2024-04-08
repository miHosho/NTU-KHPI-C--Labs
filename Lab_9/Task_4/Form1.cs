namespace Task_4
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
            KilometersToFeet();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FeetToKilometers();
        }
        private void KilometersToFeet()
        {
            double feetInAKilometer = 3280.84;

            if (double.TryParse(textBox1.Text, out double kilometers))
            {
                double feet = kilometers * feetInAKilometer;
                label2.Text = feet.ToString("N2") + " ft.";
            }
        }
        private void FeetToKilometers()
        {
            double feetInAKilometer = 3280.84;

            if (double.TryParse(textBox2.Text, out double feets))
            {
                double kilometers = feets / feetInAKilometer;
                label3.Text = kilometers.ToString("N2") + " km.";
            }
        }
    }

}