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
                Form2 form2 = new Form2(comboBox1.Text, "����� (Prague): ������� " +
                    "�����, ����� �������� ����� �������� ������������, " +
                    "������� ������ ���� � �������� ����.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\�����.jfif");
                form2.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Form2 form2 = new Form2(comboBox1.Text, "���� (Brno): ������ �� " +
                    "�������� ����� �����, ���� - ����� �������� � �����.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\����.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form2 form2 = new Form2(comboBox1.Text, "������� (Ostrava): ���� " +
                    "����� �������� ����� ��������������� � ��������� ����������� " +
                    "���������� Colours of Ostrava.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\�������.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Form2 form2 = new Form2(comboBox1.Text, "������� (Plzen): ������� - " +
                    "������ ������������ ����� ���� � �����, ��� ���������� Pilsner Fest.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\�������.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Form2 form2 = new Form2(comboBox1.Text, "������� (Liberec): ����� � " +
                    "�������� ��������� ����������, ��������� ������ ������������ ���������.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\�������.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Form2 form2 = new Form2(comboBox1.Text, "������� (Olomouc): ������� - " +
                    "������������ ����� � ���������� ���������� � ������������� ����������.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\�������.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Form2 form2 = new Form2(comboBox1.Text, "�����-���������� (Ceske " +
                    "Budejovice): ����� ���������� ���������� ������� ���� Budweiser Budvar.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\�����-�.jfif");
                form2.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Form2 form2 = new Form2(comboBox1.Text, "����-���-����� (Usti nad Labem): " +
                    "������������� � ����� ������� � ���������, ����-���-����� ������ ������ �������� �������.", "C:\\Users\\Public\\Desktop\\������\\.NET\\�����\\����.jfif");
                form2.ShowDialog();
            }
        }
    }
}