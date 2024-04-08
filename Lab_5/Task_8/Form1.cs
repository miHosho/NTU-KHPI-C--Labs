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
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.ColumnCount = 7;
            tableLayoutPanel.Dock = DockStyle.Fill;

            // Встановлення однакового розміру для всіх рядків та стовпців.
            for (int row = 0; row < tableLayoutPanel.RowCount; row++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            }

            for (int col = 0; col < tableLayoutPanel.ColumnCount; col++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            }

            // Додавання TableLayoutPanel на форму.
            this.Controls.Add(tableLayoutPanel);

            Button button = new Button();
            button.Text = $"Кнопка 1";
            button.Dock = DockStyle.Fill; 
            tableLayoutPanel.Controls.Add(button, 0, 0);

            Button button1 = new Button();
            button1.Text = $"Кнопка 2";
            button1.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(button1, 0, 1);

            Button button2 = new Button();
            button2.Text = $"Кнопка 3";
            button2.Dock = DockStyle.Fill; 
            tableLayoutPanel.Controls.Add(button2, 0, 2);

            Button button3 = new Button();
            button3.Text = $"Кнопка 4";
            button3.Dock = DockStyle.Fill; 
            tableLayoutPanel.Controls.Add(button3, 2, 2);

            Button button4 = new Button();
            button4.Text = $"Кнопка 5";
            button4.Dock = DockStyle.Fill; 
            tableLayoutPanel.Controls.Add(button4, 4, 0);
        }


    }
}