using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.DataFormats;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using MySql.Data.MySqlClient;

namespace Lab_12
{
    public partial class RegForm : Form
    {
        private bool correctPass = false;
        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        public RegForm()
        {
            InitializeComponent();
            foreach (Control control in gradientPanel.Controls)
            {
                if (control is System.Windows.Forms.Label)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            GradientPanel();


        }

        private void GradientPanel() // Устанавливаем градиентный фон на панели
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(gradientPanel.ClientRectangle, Color.White, Color.LightGreen, 90f);
            gradientPanel.Paint += (s, args) =>
            {
                GraphicsPath path = new GraphicsPath();
                int cornerRadius = 20; // Размер закругления углов
                Rectangle bounds = gradientPanel.ClientRectangle;

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
            if (textBox1.Text.Length > 0) label5.Visible = false;
            else label5.Visible = true;
            string inputText = textBox1.Text;

            // Определяем регулярное выражение для разрешенных символов
            string pattern = "^[a-zA-Z]*$";

            if (inputText.Length > 15)
            {
                textBox1.Text = inputText.Substring(0, 15);
                textBox1.SelectionStart = textBox1.Text.Length;
            }

            // Проверка на соответствие регулярному выражению
            if (!Regex.IsMatch(inputText, pattern))
            {
                // Если текст не соответствует, удаляем последний введенный символ
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0) label6.Visible = false;
            else label6.Visible = true;
            string inputText = textBox2.Text;

            string pattern = "^[a-zA-Z]*$";

            if (inputText.Length > 15)
            {
                textBox2.Text = inputText.Substring(0, 15);
                textBox2.SelectionStart = textBox2.Text.Length;
            }

            // Проверка на соответствие регулярному выражению
            if (!Regex.IsMatch(inputText, pattern))
            {
                // Если текст не соответствует, удаляем последний введенный символ
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; user=root; password=0672951355; database=loginsdb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Проверяем, существует ли значение в столбце "Email"
                string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE Email = @Email";

                using (MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection))
                {
                    checkEmailCommand.Parameters.AddWithValue("@Email", textBox3.Text);
                    int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                    if (emailCount > 0)
                    {
                        label15.Visible = true;
                    }
                    else
                        label15.Visible = false;
                }
            }


            if (!validate_emailaddress.IsMatch(textBox3.Text))
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox4.Text;


            bool isLengthValid = false;
            bool hasDigits = false;
            bool hasSpecialChar = false;
            bool hasLetters = false;

            // Проверка длины пароля
            if (inputText.Length >= 12)
            {
                isLengthValid = true;
            }

            // Проверка наличия цифр
            if (Regex.IsMatch(inputText, "[0-9]"))
            {
                hasDigits = true;
            }

            // Проверка наличия специальных символов
            if (Regex.IsMatch(inputText, "[!@#$%^&*()]"))
            {
                hasSpecialChar = true;
            }

            // Проверка наличия букв латинского алфавита
            if (Regex.IsMatch(inputText, "[a-zA-Z]"))
            {
                hasLetters = true;
            }

            if (isLengthValid && hasDigits && hasSpecialChar && hasLetters)
            {
                correctPass = true;
                label8.Visible = false;
            }
            else
            {
                correctPass = false;
                label8.Visible = true;
            }
            if (inputText.Length > 12)
            {
                textBox4.Text = inputText.Substring(0, 12);
                textBox4.SelectionStart = textBox4.Text.Length;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!correctPass)
            {
                textBox4.Clear();
            }
            if (!label5.Visible && !label6.Visible && !label7.Visible && !label8.Visible && !label15.Visible)
            {
                string connectionString = "server=localhost; user=root; password=0672951355; database=loginsdb";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO users (Name, Email, Password) VALUES (@Name, @Email, @Password)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", textBox1.Text + " " + textBox2.Text);
                        command.Parameters.AddWithValue("@Email", textBox3.Text);
                        command.Parameters.AddWithValue("@Password", textBox4.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Регистрация успено завершена.");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка.");
                        }
                    }
                }
                this.Close();
            }

        }

    }

}
