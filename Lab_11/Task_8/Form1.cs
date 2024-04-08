using System;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        private Font currentFont = new Font("Arial", 12);
        private Color currentTextColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ���������� �� ������� ������ � �������
            InitializeFontComboBox();
            InitializeColorComboBox();
            InitializeSizeComboBox();
            InitializeStyleComboBox();
        }

        private void InitializeFontComboBox()
        {
            // ���������� ���������� � ���������� ��������
            FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                fontComboBox.Items.Add(fontFamily.Name);
            }

            // ����� �������� ������ � ����������
            fontComboBox.SelectedItem = currentFont.Name;
        }

        private void InitializeColorComboBox()
        {
            // ���������� ���������� � ���������� ������� ������
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                colorComboBox.Items.Add(color);
            }

            // ����� �������� ����� ������ � ����������
            colorComboBox.SelectedItem = currentTextColor;
        }
        private void InitializeSizeComboBox()
        {
            // ���������� ���������� � ���������� ��������� ������
            for (int size = 8; size <= 72; size += 2)
            {
                sizeComboBox.Items.Add(size.ToString());
            }

            // ����� �������� ������� ������ � ����������
            sizeComboBox.SelectedItem = currentFont.Size.ToString();
        }
        private void InitializeStyleComboBox()
        {
            // ���������� ���������� �� ������� ������
            styleComboBox.Items.Add("�������");
            styleComboBox.Items.Add("����������");
            styleComboBox.Items.Add("������");
            styleComboBox.Items.Add("������������");

            // ����� ����� �� ���������
            styleComboBox.SelectedIndex = 0;
        }
        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            switch (styleComboBox.SelectedIndex)
            {
                case 1:
                    fontStyle = FontStyle.Bold;
                    break;
                case 2:
                    fontStyle = FontStyle.Italic;
                    break;
                case 3:
                    fontStyle = FontStyle.Underline;
                    break;
                default:
                    fontStyle = FontStyle.Regular;
                    break;
            }

            currentFont = new Font(currentFont.FontFamily, currentFont.Size, fontStyle);
            richTextBox1.SelectionFont = currentFont;
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ��������� ������ ������ � ������� �������
            currentFont = new Font(fontComboBox.SelectedItem.ToString(), currentFont.Size);
            ApplyFontStyle();
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ��������� ������� ������ ������ � ������� �������
            float size;
            if (float.TryParse(sizeComboBox.SelectedItem.ToString(), out size))
            {
                currentFont = new Font(currentFont.FontFamily, size);
                ApplyFontStyle();
            }
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ��������� ����� ������ � ������� �������
            currentTextColor = Color.FromName(colorComboBox.SelectedItem.ToString());
            ApplyFontStyle();
        }

        private void ApplyFontStyle()
        {
            // ���������� ����� � ����������� ������ ��� ������ � ������� �������
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;

            richTextBox1.SelectionFont = currentFont;
            richTextBox1.SelectionColor = currentTextColor;

            // �������������� ������� �������
            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // ������� ������ ���������� �����
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ��������� ����� �� richTextBox1 � ��������� ����
                string filePath = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filePath, richTextBox1.Text);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // ������� ������ �������� �����
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ��������� ����� �� ���������� ����� � ���������� � richTextBox1
                string filePath = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int currentPos = richTextBox1.SelectionStart;
            label1.Text = "������� �������: " + currentPos.ToString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Text = "��� ��������";
            form.Show();
        }
    }
}
