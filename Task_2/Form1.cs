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
            // Створюємо три компоненти Label
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();

            // Налаштовуємо текст і розміщення для кожного Label
            label1.Text = "Перший текст";
            label2.Text = "Другий текст";
            label3.Text = "Третій текст";

            label1.Location = new System.Drawing.Point(10, 10);
            label2.Location = new System.Drawing.Point(10, 70);
            label3.Location = new System.Drawing.Point(10, 100);

            // Налаштовуємо кольори та розмір шрифту
            label1.ForeColor = System.Drawing.Color.Green;
            label2.ForeColor = System.Drawing.Color.Gray;
            label3.ForeColor = System.Drawing.Color.Pink;

            // Задаємо фоновий колір для кожного Label
            label1.BackColor = System.Drawing.Color.Red;
            label2.BackColor = System.Drawing.Color.Yellow;
            label3.BackColor = System.Drawing.Color.Blue;

            // Змінюємо стиль шрифту для кожного Label
            label1.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Underline);
            label3.Font = new System.Drawing.Font("Courier New", 14, FontStyle.Bold);

            // Змінюємо розмір Label, щоб уникнути обрізання тексту
            label1.Size = new System.Drawing.Size(400, 60);
            label2.Size = new System.Drawing.Size(400, 30);
            label3.Size = new System.Drawing.Size(400, 30);

            // Вирівнюємо текст
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label3.TextAlign = ContentAlignment.MiddleRight;

            // Додаємо Label до форми
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
        }


    }
}