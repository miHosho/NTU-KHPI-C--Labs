using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        private bool isProcessing;

        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += textBox1_KeyPress;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '-')
            {

            }
            else if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Length < 2)
            {
                MessageBox.Show("Invalid name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
                return;
            }
            string text = maskedTextBox1.Text;
            int digitCount = text.Count(char.IsDigit);
            if (digitCount != 12)
            {
                MessageBox.Show("Invalid Phone Number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox1.Focus();
                return;
            }
            if (!validate_emailaddress.IsMatch(textBox3.Text))
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox3.Focus();
                return;
            }
            else
            {
                ShowPersonalInfo();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            maskedTextBox1.Text = null;
            textBox3.Text = null;
            dateTimePicker1.Value = new DateTime(2023, 10, 20);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            richTextBox1.Text = null;

            radioButton12.Checked = true;
            radioButton5.Checked = true;
        }

        private void ShowPersonalInfo()
        {
            string message = "��'�: " + textBox1.Text + "\n";
            message += "�������: " + maskedTextBox1.Text + "\n";
            message += "�����: " + textBox3.Text + "\n";
            message += "���� ����������: " + dateTimePicker1.Value + "\n";
            message += "³�: " + comboBox1.SelectedItem + "\n";
            message += "�������� �����: " + comboBox2.SelectedItem + "\n";

            DialogResult result = MessageBox.Show(
                message + "\n",
                "�������� ����������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this.BackColor, this.Font, this.ForeColor);
            settingsForm.ShowDialog();

            if(settingsForm.SelectedBackgroundColor != null) this.BackColor = settingsForm.SelectedBackgroundColor;
            if (settingsForm.SelectedTextColor != null) this.ForeColor = settingsForm.SelectedTextColor;
            if (settingsForm.SelectedFontSize != null) this.Font = new Font(settingsForm.SelectedFontSize, FontStyle.Regular);

        }
    }
}