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
            // Заполните комбобоксы со стилями текста и цветами
            InitializeFontComboBox();
            InitializeColorComboBox();
            InitializeSizeComboBox();
            InitializeStyleComboBox();
        }

        private void InitializeFontComboBox()
        {
            // Заполнение комбобокса с доступными шрифтами
            FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                fontComboBox.Items.Add(fontFamily.Name);
            }

            // Выбор текущего шрифта в комбобоксе
            fontComboBox.SelectedItem = currentFont.Name;
        }

        private void InitializeColorComboBox()
        {
            // Заполнение комбобокса с доступными цветами текста
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                colorComboBox.Items.Add(color);
            }

            // Выбор текущего цвета текста в комбобоксе
            colorComboBox.SelectedItem = currentTextColor;
        }
        private void InitializeSizeComboBox()
        {
            // Заполнение комбобокса с доступными размерами шрифта
            for (int size = 8; size <= 72; size += 2)
            {
                sizeComboBox.Items.Add(size.ToString());
            }

            // Выбор текущего размера шрифта в комбобоксе
            sizeComboBox.SelectedItem = currentFont.Size.ToString();
        }
        private void InitializeStyleComboBox()
        {
            // Заполнение комбобокса со стилями шрифта
            styleComboBox.Items.Add("Обычный");
            styleComboBox.Items.Add("Выделенный");
            styleComboBox.Items.Add("Курсив");
            styleComboBox.Items.Add("Подчеркнутый");

            // Выбор стиля по умолчанию
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
            // Изменение шрифта текста с позиции курсора
            currentFont = new Font(fontComboBox.SelectedItem.ToString(), currentFont.Size);
            ApplyFontStyle();
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменение размера шрифта текста с позиции курсора
            float size;
            if (float.TryParse(sizeComboBox.SelectedItem.ToString(), out size))
            {
                currentFont = new Font(currentFont.FontFamily, size);
                ApplyFontStyle();
            }
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменение цвета текста с позиции курсора
            currentTextColor = Color.FromName(colorComboBox.SelectedItem.ToString());
            ApplyFontStyle();
        }

        private void ApplyFontStyle()
        {
            // Применение стиля к выделенному тексту или тексту с позиции курсора
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;

            richTextBox1.SelectionFont = currentFont;
            richTextBox1.SelectionColor = currentTextColor;

            // Восстановление позиции курсора
            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Открыть диалог сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохранить текст из richTextBox1 в выбранный файл
                string filePath = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filePath, richTextBox1.Text);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // Открыть диалог открытия файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Загрузить текст из выбранного файла и отобразить в richTextBox1
                string filePath = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int currentPos = richTextBox1.SelectionStart;
            label1.Text = "Позиция курсора: " + currentPos.ToString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Text = "Про програму";
            form.Show();
        }
    }
}
