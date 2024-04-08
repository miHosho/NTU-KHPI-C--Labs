namespace Task_6
{
    public partial class Form1 : Form
    {
        private bool isRunning = false; 
        private int seconds = 0;
        private int minutes = 0; 
        int need = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            UpdateTimeLabels();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                timer1.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                seconds++; 

                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }

                UpdateTimeLabels(); 
            }
        }

        private void UpdateTimeLabels()
        {
            secondsLabel.Text = seconds.ToString("D2");
            minutesLabel.Text = minutes.ToString("D2");
            if (int.Parse(secondsLabel.Text) == need)
            {
                need += 5;
                ChangeColors();
            }
        }
        private void ChangeColors()
        {
            secondsLabel.BackColor = GetRandomColor();
            minutesLabel.BackColor = GetRandomColor();
            secondsLabel.ForeColor = GetRandomColor();
            minutesLabel.ForeColor = GetRandomColor();
        }
        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}