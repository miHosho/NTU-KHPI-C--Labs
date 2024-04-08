namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.MouseDown += label_MouseCheck;
            label1.MouseUp += label_MouseCheck;

            label2.MouseDown += label_MouseCheck;
            label2.MouseUp += label_MouseCheck;

            label3.MouseDown += label_MouseCheck;
            label3.MouseUp += label_MouseCheck;
        }
        private void label_MouseCheck(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
}