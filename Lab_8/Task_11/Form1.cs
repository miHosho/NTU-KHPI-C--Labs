namespace Task_11
{
    public partial class Form1 : Form
    {
        private Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange };
        private int colorIndex = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500; // Интервал в миллисекундах (0,5 секунды)
            timer1.Tick += ChangeButtonColor;
            timer1.Start(); // Запуск таймера при загрузке формы
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ChangeButtonColor(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            button1.ForeColor = colors[colorIndex];
        }
    }
}