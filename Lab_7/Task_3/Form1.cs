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
            label1.DoubleClick += new EventHandler(label1_DoubleClick);
            label2.DoubleClick += new EventHandler(label2_DoubleClick);
            label3.DoubleClick += new EventHandler(label3_DoubleClick);
        }
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.Red) label1.BackColor = Color.Blue;
            else label1.BackColor = Color.Red;
        }
        private void label2_DoubleClick(object sender, EventArgs e)
        {
            if (label2.BackColor == Color.Red) label2.BackColor = Color.Blue;
            else label2.BackColor = Color.Red;
        }
        private void label3_DoubleClick(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.Red) label3.BackColor = Color.Blue;
            else label3.BackColor = Color.Red;
        }
    }
}