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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Прага (Prague): Столица " +
                    "Чехии, Прага известна своей красивой архитектурой, " +
                    "включая Карлов мост и Пражский Град.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Прага.jfif");
                form2.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Брно (Brno): Второй по " +
                    "величине город Чехии, Брно - центр культуры и науки.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Брно.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Острава (Ostrava): Этот " +
                    "город славится своей промышленностью и ежегодным музыкальным " +
                    "фестивалем Colours of Ostrava.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Острава.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Пльзень (Plzen): Пльзень - " +
                    "родина одноименного сорта пива и место, где проводится Pilsner Fest.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Пльзень.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Либерец (Liberec): Город в " +
                    "красивой природной обстановке, известный своими горнолыжными курортами.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Либерец.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Оломоуц (Olomouc): Оломоуц - " +
                    "исторический город с множеством культурных и архитектурных памятников.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Оломоуц.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Ческе-Будейовице (Ceske " +
                    "Budejovice): Здесь производят популярное чешское пиво Budweiser Budvar.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Ческе-Б.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Form2 form2 = new Form2(comboBox1.Text, "Усти-над-Лабем (Usti nad Labem): " +
                    "Расположенный в близи границы с Германией, Усти-над-Лабем служит важным торговым центром.", "C:\\Users\\Public\\Desktop\\Универ\\.NET\\Чехия\\Усти.jfif");
                form2.ShowDialog();
            }
        }
    }
}