using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ищем все конечные элементы в MenuStrip
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
                        // Рекурсивно ищем конечные элементы в дочерних элементах
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
                MessageBox.Show($"Выбран пункт меню: {itemName}");
            }
        }

    }
}