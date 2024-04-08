namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.DoubleClick += new EventHandler(label_DoubleClick);
            label2.DoubleClick += new EventHandler(label_DoubleClick);
            label3.DoubleClick += new EventHandler(label_DoubleClick);
        }
        private void label_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.BackColor == Color.Red)
                    clickedLabel.BackColor = Color.Blue;
                else
                    clickedLabel.BackColor = Color.Red;
            }
        }
    }
}