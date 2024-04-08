namespace Task_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += comboBox1_ShowSelected;
        }

        private void comboBox1_ShowSelected(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }
    }
}