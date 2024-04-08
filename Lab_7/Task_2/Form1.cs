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

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

                if(clickedButton.Text == "button1")
                    label1.Text = "111111111";
                else if(clickedButton.Text == "button2")
                    label1.Text = "222222222";
                else if(clickedButton.Text == "button3")
                    label1.Text = "333333333";
                //MessageBox.Show($"Натиснута кнопка: {clickedButton.Text}");

        }
    }
}