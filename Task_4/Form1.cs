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
            // Створюємо три компоненти TextBox
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBox textBox3 = new TextBox();

            // Налаштовуємо текст та розміщення для кожного TextBox
            textBox1.Text = "Перший текст";
            textBox2.Text = "Другий текст";
            textBox3.Text = "Третій текст";

            textBox1.Location = new System.Drawing.Point(10, 10);
            textBox2.Location = new System.Drawing.Point(10, 70);
            textBox3.Location = new System.Drawing.Point(10, 100);

            // Налаштовуємо кольори та розмір шрифту
            textBox1.ForeColor = System.Drawing.Color.Green;
            textBox2.ForeColor = System.Drawing.Color.Gray;
            textBox3.ForeColor = System.Drawing.Color.Pink;

            // Задаємо фоновий колір для кожного TextBox
            textBox1.BackColor = System.Drawing.Color.Red;
            textBox2.BackColor = System.Drawing.Color.Yellow;
            textBox3.BackColor = System.Drawing.Color.Blue;

            // Змінюємо стиль шрифту для кожного TextBox
            textBox1.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            textBox2.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Underline);
            textBox3.Font = new System.Drawing.Font("Courier New", 14, FontStyle.Bold);

            // Змінюємо розмір TextBox, щоб уникнути обрізання тексту
            textBox1.Size = new System.Drawing.Size(400, 60);
            textBox2.Size = new System.Drawing.Size(400, 30);
            textBox3.Size = new System.Drawing.Size(400, 30);

            // Вирівнюємо текст
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox3.TextAlign = HorizontalAlignment.Right;

            // Додаємо TextBox до форми
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
        }
    }
}