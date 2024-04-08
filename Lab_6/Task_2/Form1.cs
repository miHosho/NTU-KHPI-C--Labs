namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Items.AddRange(new string[] { "Прага", "Брно", "Острава", "Пльзень", "Ліберець", "Оломоуц", "Усти-над-Лабем", "Градец-Кралове" });
            comboBox.Location = new Point(10, 10); 
            comboBox.Size = new Size(150, 20);
            this.Controls.Add(comboBox); 

            ListBox listBox = new ListBox();
            listBox.Items.AddRange(new object[] { "Прага", "Брно", "Острава", "Пльзень", "Ліберець", "Оломоуц", "Усти-над-Лабем", "Градец-Кралове" });
            listBox.Location = new Point(170, 10); 
            listBox.Size = new Size(150, 100); 
            this.Controls.Add(listBox); 
        }

    }
}