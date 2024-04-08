namespace Task_5
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
            foreach (ToolStripMenuItem topLevelItem in menuStrip1.Items)
            {
                AddClickEventToLeafItems(topLevelItem);
            }
        }

        private void AddClickEventToLeafItems(ToolStripMenuItem parentItem)
        {
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
                string itemName = item.Text;
                MessageBox.Show($"������ ����� ����: {itemName}");
            }
        }

    }
}