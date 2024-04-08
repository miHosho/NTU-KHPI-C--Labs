namespace Task_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Запустити верхню панель?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

            }
            else
            {
                this.ControlBox = false;
            }
        }
    }
}