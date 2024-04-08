using System;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Развернуть");
            openMenuItem.Click += (sender, e) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            };

            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Закрыть");
            exitMenuItem.Click += (sender, e) =>
            {
                Application.Exit();
            };

            contextMenu.Items.Add(openMenuItem);
            contextMenu.Items.Add(exitMenuItem);

            notifyIcon1.ContextMenuStrip = contextMenu;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            toolStripStatusLabel1.Text = currentTime.Minute.ToString();

            string inputText = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                int textLength = inputText.Length;
                int halfLength = textLength / 2;
                string secondHalf = inputText.Substring(halfLength, textLength - halfLength);

                toolStripStatusLabel2.Text = "Вторая половина текста: " + secondHalf;
            }
            else
            {
                toolStripStatusLabel2.Text = "";
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_Click(object Sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}
