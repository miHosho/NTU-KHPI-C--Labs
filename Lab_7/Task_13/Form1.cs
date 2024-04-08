namespace Task_13
{
    public partial class Form1 : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.A)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new System.Drawing.Point(50, 50);
                pictureBox.Size = new System.Drawing.Size(100, 100);
                pictureBox.Image = Image.FromFile(@"C:\Users\Public\Pictures\images.jpeg");

                this.Controls.Add(pictureBox);
                pictureBoxes.Add(pictureBox);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                if (pictureBoxes.Count > 0)
                {
                    PictureBox pictureBox = pictureBoxes[pictureBoxes.Count - 1];
                    this.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                    pictureBoxes.RemoveAt(pictureBoxes.Count - 1);
                }
            }
        }
    }
}