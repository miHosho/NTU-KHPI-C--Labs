namespace Task_3
{
    public partial class Form1 : Form
    {
        public int hipotenuza;
        public int katet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out hipotenuza) 
                || !int.TryParse(textBox2.Text, out katet))
            {
                Console.WriteLine("Неверно введены данные!");
                return;
            }
            label3.Text = "Периметр - " + Perimetr(hipotenuza, katet).ToString("N2");
            label4.Text = "Гіпотенуза - " + hipotenuza.ToString();

        }
        private double Perimetr(int hipotenuza, int katet)
        {
            double b = Math.Sqrt(hipotenuza * hipotenuza - katet * katet);
            double result = katet * b;
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out hipotenuza)
                || !int.TryParse(textBox2.Text, out katet))
            {
                Console.WriteLine("Неверно введены данные!");
                return;
            }
            Form2 form2 = new Form2(hipotenuza, katet);
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out hipotenuza)
                || !int.TryParse(textBox2.Text, out katet))
            {
                Console.WriteLine("Неверно введены данные!");
                return;
            }
            Form3 form3 = new Form3(Perimetr(hipotenuza, katet), hipotenuza);
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out hipotenuza)
                || !int.TryParse(textBox2.Text, out katet))
            {
                Console.WriteLine("Неверно введены данные!");
                return;
            }
            Form4 form4 = new Form4(Perimetr(hipotenuza, katet), hipotenuza, katet);
            form4.ShowDialog();
        }
    }
}