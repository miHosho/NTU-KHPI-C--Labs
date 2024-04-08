namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enter += textBox1_MouseCheck;
            textBox1.Leave += textBox1_MouseCheck;

            textBox2.Enter += textBox2_MouseCheck;
            textBox2.Leave += textBox2_MouseCheck;

            textBox3.Enter += textBox3_MouseCheck;
            textBox3.Leave += textBox3_MouseCheck;
        }
        private void textBox1_MouseCheck(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Red)
                textBox1.BackColor = Color.Blue;
            else
                textBox1.BackColor = Color.Red;
        }
        private void textBox2_MouseCheck(object sender, EventArgs e)
        {
            if (textBox2.BackColor == Color.Red)
                textBox2.BackColor = Color.Blue;
            else
                textBox2.BackColor = Color.Red;
        }
        private void textBox3_MouseCheck(object sender, EventArgs e)
        {
            if (textBox3.BackColor == Color.Red)
                textBox3.BackColor = Color.Blue;
            else
                textBox3.BackColor = Color.Red;
        }
    }
}