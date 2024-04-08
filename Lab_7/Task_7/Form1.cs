namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.MouseDown += label1_MouseClick;
            label1.MouseUp += label1_MouseClick;

            label2.MouseDown += label2_MouseClick;
            label2.MouseUp += label2_MouseClick;

            label3.MouseDown += label3_MouseClick;
            label3.MouseUp += label3_MouseClick;
        }
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (label1.BackColor == Color.Red) label1.BackColor = Color.Blue;
                else label1.BackColor = Color.Red;
            }
        }
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (label2.BackColor == Color.Red) label2.BackColor = Color.Blue;
                else label2.BackColor = Color.Red;
            }
        }
        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (label3.BackColor == Color.Red) label3.BackColor = Color.Blue;
                else label3.BackColor = Color.Red;
            }
        }
    }
}