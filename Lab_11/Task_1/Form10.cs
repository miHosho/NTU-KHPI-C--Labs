namespace Task_1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.BackColor = Color.Blue;
            form20.ForeColor = Color.Red;
            form20.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.BackColor = Color.Purple;
            form30.ForeColor = Color.Red;
            form30.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form40 form40 = new Form40();
            form40.BackColor = Color.Black;
            form40.ForeColor = Color.Red;
            form40.ShowDialog();
        }
    }
}