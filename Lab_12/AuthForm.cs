using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;

namespace Lab_12
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
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

        private void Form2_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RegForm form = new RegForm();
            form.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; user=root; password=0672951355; database=loginsdb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string email = textBox1.Text;
                string password = textBox2.Text;

                // Запрос для выбора пользователя по email
                string selectUserQuery = "SELECT * FROM users WHERE Email = @Email";
                
                using (MySqlCommand selectUserCommand = new MySqlCommand(selectUserQuery, connection))
                {
                    selectUserCommand.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = selectUserCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["Password"].ToString(); // Получаем пароль из базы данных
                            string name = reader["Name"].ToString();

                            // Сравниваем введенный пароль с хранимым паролем
                            if (password == storedPassword)
                            {
                                label6.Text = "Верный пароль. Вход разрешен.";
                                this.Hide();
                                ProfileForm form3 = new ProfileForm(name, email);
                                form3.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                label6.Text = "Неверный пароль. Вход запрещен.";
                            }
                            label6.Visible = true;
                        }
                        else
                        {
                            label6.Text = "Пользователь с таким email не найден.";
                            label6.Visible = true;
                        }
                    }
                }
            }

        }
    }

}
