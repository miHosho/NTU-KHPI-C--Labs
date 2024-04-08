using Timer = System.Windows.Forms.Timer;

namespace Task_12
{
    public partial class Form1 : Form
    {
        private Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange };
        private int colorIndex = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ChangeButtonColor(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            button1.ForeColor = colors[colorIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Tick += ChangeButtonColor;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}