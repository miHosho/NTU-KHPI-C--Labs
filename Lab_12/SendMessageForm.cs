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
    public partial class SendMessageForm : Form
    {
        string myEmail1;
        public SendMessageForm(string myEmail)
        {
            myEmail1 = myEmail;
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

        private void SendMessageForm_Load(object sender, EventArgs e)
        {
            GradientPanel();


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

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string subject = textBox2.Text;
            string text = richTextBox1.Text.ToString();

            string message = $"{myEmail1}\n{subject}\n{text}\n{email}\n()|()";

            string filePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_12\\log.txt";

            // Записываем сообщение в файл, добавляя новый абзац
            File.AppendAllText(filePath, message);
            MessageBox.Show("Сообщение успешно отправлено");
            this.Close();
        }
    }
}
