using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task_4
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
                    label1.Text = selectedFolder;
                    imageFiles.AddRange(files);

                    if (imageFiles.Count > 0)
                    {
                        // ������� ListBox ����� ����������� ����� ���������
                        listBox1.Items.Clear();

                        foreach (string file in imageFiles)
                        {
                            // �������� ������ ��� ����� � ��������� ��� � ListBox
                            listBox1.Items.Add(Path.GetFileName(file));
                        }

                        // ���������� ������ ��������
                        DisplayCurrentImage();
                    }
                }
            }
        }

        private void DisplayCurrentImage()
        {
            if (currentImageIndex >= 0 && currentImageIndex < imageFiles.Count)
            {
                Image originalImage = Image.FromFile(imageFiles[currentImageIndex]);

                // ������������ ����������� �� �������� PictureBox
                Image scaledImage = ScaleImage(originalImage, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = scaledImage;

                // ����������� �������
                originalImage.Dispose();
            }
        }

        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            return new Bitmap(image, maxWidth, maxHeight);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����������� ������� ����������� ��� ������ �������� � ListBox
            currentImageIndex = listBox1.SelectedIndex;
            DisplayCurrentImage();
        }
    }
}
