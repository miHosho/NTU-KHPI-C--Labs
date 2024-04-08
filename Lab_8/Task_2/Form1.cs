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
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            radioButton4.Checked = true;
            radioButton7.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int deltaY = 20; 

            foreach (Control control in groupBox1.Controls)
            {
                if (control is Label label)
                {
                    label.Top -= deltaY;
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Label label)
                {
                    label.Top -= deltaY;
                }
            }
        }


    }
}