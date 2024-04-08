namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int totalElements = 5;
            int initialWidth = 100;
            int step = 20;

            int bottomY = 100;
            for (int i = 1; i <= totalElements; i++)
            {
                PictureBox pictureBox = new PictureBox();

                if(i == 3)
                {
                    int pictureHeight = 65 - Math.Abs(3 - i) * 20;
                    int topY = bottomY - pictureHeight;
                    pictureBox.Size = new Size(initialWidth, pictureHeight);
                    pictureBox.Location = new Point(10 + (i - 1) * (initialWidth + step), topY);
                }
                else
                {
                    int pictureHeight = 100 - Math.Abs(3 - i) * 25;
                    int topY = bottomY - pictureHeight;
                    pictureBox.Location = new Point(10 + (i - 1) * (initialWidth + step), topY);
                    pictureBox.Size = new Size(initialWidth, pictureHeight);
                }
                    
                pictureBox.Image = Image.FromFile(@"C:\Users\Public\Pictures\images.jpeg"); 
                this.Controls.Add(pictureBox);
            }


            for (int i = 0; i < 3; i++)
            {
                PictureBox pictureBox = new PictureBox();
                if (i == 2)
                    pictureBox.Location = new Point(10 + i * (initialWidth/2 + step + 100), 200);
                else
                    pictureBox.Location = new Point(10 + i * (initialWidth + step + 100), 200);

                if(i == 1)
                    pictureBox.Size = new Size(initialWidth * 1, 100);
                else
                    pictureBox.Size = new Size(initialWidth * 2, 100);
                pictureBox.Image = Image.FromFile(@"C:\Users\Vyacheslav\Pictures\images.jpeg");
                this.Controls.Add(pictureBox);
            }
        }

    }
}