namespace Task_1
{
    public partial class Form1 : Form
    {
        private int verticalOffset = 20;

        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBoxTextChanged;
            textBox2.TextChanged += TextBoxTextChanged;
            textBox3.TextChanged += TextBoxTextChanged;
            textBox4.TextChanged += TextBoxTextChanged;
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                button2.Enabled = true;
            }
            else button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Top -= verticalOffset;
            textBox2.Top -= verticalOffset;
            textBox3.Top -= verticalOffset;
            textBox4.Top -= verticalOffset;
        }
    }
}