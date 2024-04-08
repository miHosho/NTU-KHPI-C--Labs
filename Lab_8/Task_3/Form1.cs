namespace Task_3
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
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
            checkBox1.Checked = true;
            checkBox2.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int deltaY = 20;

            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.Top -= deltaY;
                }
            }
        }
    }
}