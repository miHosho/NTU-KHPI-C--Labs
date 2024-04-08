using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ���� ��� �������� �������� � MenuStrip
            foreach (ToolStripMenuItem topLevelItem in contextMenuStrip1.Items)
            {
                AddClickEventToLeafItems(topLevelItem);
            }
        }

        private void AddClickEventToLeafItems(ToolStripMenuItem parentItem)
        {
            if (parentItem.DropDownItems.Count == 0) parentItem.Click += MenuItemClick;

            foreach (ToolStripItem item in parentItem.DropDownItems)
            {
                if (item is ToolStripMenuItem subItem)
                {
                    if (subItem.DropDownItems.Count == 0)
                    {
                        subItem.Click += MenuItemClick;
                    }
                    else
                    {
                        // ���������� ���� �������� �������� � �������� ���������
                        AddClickEventToLeafItems(subItem);
                    }
                }
            }
        }
        private void MenuItemClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                Control sourceControl = contextMenuStrip1.SourceControl;

                if (sourceControl is Label label)
                {
                    //label.Location = new Point(label.Location.X, label.Location.Y - 10);
                    Random random = new Random();
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    label.ForeColor = randomColor;
                }
            }
        }
    }
}