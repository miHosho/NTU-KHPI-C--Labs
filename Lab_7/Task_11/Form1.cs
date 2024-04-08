namespace Task_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += textBox_Settings;

        }
        private void textBox_Settings(object sender, KeyPressEventArgs e)
        {
            char upperChar = char.ToUpper(e.KeyChar);

            if (upperChar >= 'A' && upperChar <= 'M') e.KeyChar = upperChar;
            else e.Handled = true;
        }
    }
}