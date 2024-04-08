using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_12
{

    public partial class GetMessageForm : Form
    {
        public class CustomItem
        {
            public string Email { get; set; }
            public string Theme { get; set; }
            public string Message { get; set; }
        }
        List<CustomItem> customList = new List<CustomItem>();

        private string myEmail;
        public GetMessageForm(string target)
        {
            myEmail = target;
            InitializeComponent();
            foreach (Control control in gradientPanel2.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.Transparent;
                }
                if (control is TextBox textBox)
                {
                    RoundCorners(textBox);
                }
                if (control is Button btn)
                {
                    RoundBtn(btn);
                }
            }
        }

        private void GetMessageForm_Load(object sender, EventArgs e)
        {
            GradientPanel();
            try
            {
                string filePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_12\\log.txt";

                string fileContent = File.ReadAllText(filePath);

                // Разделяем содержимое файла на сообщения по ()|()
                string[] messages = fileContent.Split(new string[] { "()|()" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string message1 in messages)
                {
                    // Разделяем каждое сообщение на абзацы по переводу строки (\n)
                    string[] paragraphs = message1.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    // paragraphs[0] содержит имейл, paragraphs[1] содержит тему, paragraphs[2] содержит текст сообщения
                    string email1 = paragraphs[0];
                    string subject1 = paragraphs[1];
                    string text1 = "";
                    string targetEmail;
                    if(paragraphs.Length > 4)
                    {
                        
                        for(int i = 2; i < paragraphs.Length - 2; i++)
                        {
                            text1 += paragraphs[i] + "\n";
                        }
                        targetEmail = paragraphs[paragraphs.Length -1];
                    }
                    else
                    {
                        //MessageBox.Show(paragraphs[0]);
                        text1 = paragraphs[2];
                        targetEmail = paragraphs[3];
                    }

                    if (myEmail == targetEmail)
                    {
                        customList.Add(new CustomItem { Email = email1, Theme = subject1, Message = text1 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (CustomItem item in customList)
            {
                listBox1.Items.Add(item.Email);
            }

        }

        private void GradientPanel() // Устанавливаем градиентный фон на панели
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(gradientPanel2.ClientRectangle, Color.White, Color.LightGreen, 90f);
            gradientPanel2.Paint += (s, args) =>
            {
                GraphicsPath path = new GraphicsPath();
                int cornerRadius = 20; // Размер закругления углов
                Rectangle bounds = gradientPanel2.ClientRectangle;

                // Верхний левый угол
                path.AddArc(bounds.Left, bounds.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
                // Верхний правый угол
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
                // Нижний правый угол
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                // Нижний левый угол
                path.AddArc(bounds.Left, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                path.CloseFigure();

                // Заполняем панель градиентом, оставляя закругленные углы
                args.Graphics.FillPath(gradientBrush, path);
            };
        }
        private void RoundCorners(TextBox textBox)
        {
            int cornerRadius = 2; // Размер закругления углов

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle bounds = textBox.ClientRectangle;
                // Верхний левый угол
                path.AddArc(bounds.Left, bounds.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
                // Верхний правый угол
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
                // Нижний правый угол
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                // Нижний левый угол
                path.AddArc(bounds.Left, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                path.CloseFigure();
                textBox.Region = new Region(path);
            }
        }
        private void RoundBtn(Button btn)
        {
            btn.FlatAppearance.BorderColor = Color.DarkGray; // Цвет границы
            btn.FlatAppearance.MouseDownBackColor = Color.PaleGreen; // Цвет при нажатии
            int cornerRadius = 2; // Размер закругления углов

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle bounds = btn.ClientRectangle;
                // Верхний левый угол
                path.AddArc(bounds.Left, bounds.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
                // Верхний правый угол
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
                // Нижний правый угол
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                // Нижний левый угол
                path.AddArc(bounds.Left, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                path.CloseFigure();
                btn.Region = new Region(path);
            }
        }

        private void ReadMessage(int targetIndex)
        {
            ReadMessageForm form = new ReadMessageForm(customList[targetIndex].Theme, 
                customList[targetIndex].Message);
            form.ShowDialog();
            //MessageBox.Show($"Text:\n{customList[targetIndex].Message}", $" Theme: {customList[targetIndex].Theme}", MessageBoxButtons.OK);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string email = listBox1.Text;
            ReadMessage(listBox1.SelectedIndex);
        }
    }
}
