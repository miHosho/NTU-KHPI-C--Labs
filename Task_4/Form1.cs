namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ��� ���������� TextBox
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBox textBox3 = new TextBox();

            // ����������� ����� �� ��������� ��� ������� TextBox
            textBox1.Text = "������ �����";
            textBox2.Text = "������ �����";
            textBox3.Text = "����� �����";

            textBox1.Location = new System.Drawing.Point(10, 10);
            textBox2.Location = new System.Drawing.Point(10, 70);
            textBox3.Location = new System.Drawing.Point(10, 100);

            // ����������� ������� �� ����� ������
            textBox1.ForeColor = System.Drawing.Color.Green;
            textBox2.ForeColor = System.Drawing.Color.Gray;
            textBox3.ForeColor = System.Drawing.Color.Pink;

            // ������ ������� ���� ��� ������� TextBox
            textBox1.BackColor = System.Drawing.Color.Red;
            textBox2.BackColor = System.Drawing.Color.Yellow;
            textBox3.BackColor = System.Drawing.Color.Blue;

            // ������� ����� ������ ��� ������� TextBox
            textBox1.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            textBox2.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Underline);
            textBox3.Font = new System.Drawing.Font("Courier New", 14, FontStyle.Bold);

            // ������� ����� TextBox, ��� �������� �������� ������
            textBox1.Size = new System.Drawing.Size(400, 60);
            textBox2.Size = new System.Drawing.Size(400, 30);
            textBox3.Size = new System.Drawing.Size(400, 30);

            // ��������� �����
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox3.TextAlign = HorizontalAlignment.Right;

            // ������ TextBox �� �����
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
        }
    }
}