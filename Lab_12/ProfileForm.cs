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
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab_12
{
    public partial class ProfileForm : Form
    {
        public string email1;
        public ProfileForm(string myName, string email)
        {
            email1 = email;
            InitializeComponent();
            string[] nameParts = myName.Split(' ');
            if (nameParts.Length == 2)
            {
                firstName.Text = nameParts[0];
                lastName.Text = nameParts[1];
            }
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

        private void Form3_Load(object sender, EventArgs e)
        {
            GradientPanel();
            textBox1.Text = firstName.Text;
            textBox2.Text = lastName.Text;


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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firstName.Text = textBox1.Text;
            lastName.Text = textBox2.Text;
            linkLabel1.Visible = true;
            linkLabel2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            string connectionString = "server=localhost; user=root; password=0672951355; database=loginsdb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string newName = "" + firstName.Text + " " + lastName.Text + "";

                // Запрос для обновления значения столбца Name по электронной почте
                string updateNameQuery = "UPDATE users SET Name = @NewName WHERE Email = @Email";

                using (MySqlCommand updateNameCommand = new MySqlCommand(updateNameQuery, connection))
                {
                    updateNameCommand.Parameters.AddWithValue("@NewName", newName);
                    updateNameCommand.Parameters.AddWithValue("@Email", email1);

                    int rowsAffected = updateNameCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запись обновлена успешно.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с указанным email не найден.");
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendMessageForm form = new SendMessageForm(email1);
            form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetMessageForm form = new GetMessageForm(email1);
            form.ShowDialog();
            this.Show();
        }
    }
}
