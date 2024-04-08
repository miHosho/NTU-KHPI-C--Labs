namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripButton1.Click += toolStripButton_Click;
            toolStripButton2.Click += toolStripButton_Click;
            toolStripButton3.Click += toolStripButton_Click;
            toolStripButton4.Click += toolStripButton_Click;
        }
        private void toolStripButton_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton button)
            {
                DialogResult result = MessageBox.Show(
                "Ïîäñêàçûâàş ÷òî-òî :)" + "\n",
                "ÏÎÄÑÊÀÇÊÀ ÏÎÄÑÊÀÇÎ×ÊÀ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
        }
    }
}