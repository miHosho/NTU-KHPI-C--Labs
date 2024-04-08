using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form2 : Form
    {
        public Form2(string name, string info, string imagePath)
        {
            InitializeComponent();
            this.Text = name;
            label1.Text = info;
            Image originalImage = Image.FromFile(imagePath);

            Image resizedImage = ResizeImage(originalImage, pictureBox1.Size);

            pictureBox1.Image = resizedImage;

            // Освобождаем ресурсы
            originalImage.Dispose();
        }

        private Image ResizeImage(Image image, Size newSize)
        {
            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                graphics.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }

            return newImage;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
