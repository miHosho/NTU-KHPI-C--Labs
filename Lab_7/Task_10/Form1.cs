namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enter += textBox_MouseCheck;
            textBox1.Leave += textBox_MouseCheck;

            textBox2.Enter += textBox_MouseCheck;
            textBox2.Leave += textBox_MouseCheck;

            textBox3.Enter += textBox_MouseCheck;
            textBox3.Leave += textBox_MouseCheck;
        }
        private void textBox_MouseCheck(object sender, EventArgs e)
        {
            TextBox clickedBox = sender as TextBox;

            if (clickedBox != null)
            {
                if (clickedBox.BackColor == Color.Red)
                    clickedBox.BackColor = Color.Blue;
                else
                    clickedBox.BackColor = Color.Red;
            }
        }
    }
}