namespace Task_8
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            toolStripStatusLabel1.Text = currentTime.Minute.ToString();

            string inputText = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                int textLength = inputText.Length;
                int halfLength = textLength / 2;
                string secondHalf = inputText.Substring(halfLength, textLength - halfLength);

                toolStripStatusLabel2.Text = "Вторая половина текста: " + secondHalf;
            }
            else
            {
                toolStripStatusLabel2.Text = "";
            }
        }

    }
}