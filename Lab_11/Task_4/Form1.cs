namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int x)
                || !int.TryParse(textBox2.Text, out int y)
                || !int.TryParse(textBox3.Text, out int z))
            {
                Console.WriteLine("Ошибка входных данных! Введите пожалуйста целые числа");
                return;
            }
            label3.Text = Calculate(x, y, z).ToString("N2");

        }
        private double Calculate(int x, int y, int z)
        {
            double result = 0;
            for (int i = 0; i <= x * y * z; i++)
            {
                if (i == z)
                    continue;

                result += (Math.Cos(y) * Math.Sin(x)) / (i - z);
            }
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int x)
                || !int.TryParse(textBox2.Text, out int y)
                || !int.TryParse(textBox3.Text, out int z))
            {
                Console.WriteLine("Ошибка входных данных! Введите пожалуйста целые числа");
                return;
            }
            Form2 form2 = new Form2(x, y, z);
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int x)
                || !int.TryParse(textBox2.Text, out int y)
                || !int.TryParse(textBox3.Text, out int z))
            {
                Console.WriteLine("Ошибка входных данных! Введите пожалуйста целые числа");
                return;
            }
            Form3 form3 = new Form3(x, y, z);
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int x)
                || !int.TryParse(textBox2.Text, out int y)
                || !int.TryParse(textBox3.Text, out int z))
            {
                Console.WriteLine("Ошибка входных данных! Введите пожалуйста целые числа");
                return;
            }
            Form4 form4 = new Form4(x, y, z);
            form4.ShowDialog();
        }
    }
}