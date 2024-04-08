namespace Task_2
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles;
        private int currentImageIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageFiles = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    string[] files = Directory.GetFiles(selectedFolder, "*.jpg");
                    imageFiles.AddRange(files);

                    if (imageFiles.Count > 0)
                    {
                        DisplayCurrentImage();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                if (currentImageIndex > 0) currentImageIndex--;
                DisplayCurrentImage();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                if (currentImageIndex < imageFiles.Count - 1) currentImageIndex++;
                DisplayCurrentImage();
            }
        }

        private void DisplayCurrentImage()
        {
            if (currentImageIndex >= 0 && currentImageIndex < imageFiles.Count)
            {
                Image originalImage = Image.FromFile(imageFiles[currentImageIndex]);

                // Масштабируем изображение до размеров PictureBox
                Image scaledImage = ScaleImage(originalImage, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = scaledImage;

                // Освобождаем ресурсы
                originalImage.Dispose();
            }
        }

        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            return new Bitmap(image, maxWidth, maxHeight);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Tick += ImageTimer_Tick;
            timer1.Start();
        }
        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= imageFiles.Count)
            {
                currentImageIndex = 0;
            }

            DisplayCurrentImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
