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
            // ��������� ��� ���������� Label
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();

            // ����������� ����� � ��������� ��� ������� Label
            label1.Text = "������ �����";
            label2.Text = "������ �����";
            label3.Text = "����� �����";

            label1.Location = new System.Drawing.Point(10, 10);
            label2.Location = new System.Drawing.Point(10, 70);
            label3.Location = new System.Drawing.Point(10, 100);

            // ����������� ������� �� ����� ������
            label1.ForeColor = System.Drawing.Color.Green;
            label2.ForeColor = System.Drawing.Color.Gray;
            label3.ForeColor = System.Drawing.Color.Pink;

            // ������ ������� ���� ��� ������� Label
            label1.BackColor = System.Drawing.Color.Red;
            label2.BackColor = System.Drawing.Color.Yellow;
            label3.BackColor = System.Drawing.Color.Blue;

            // ������� ����� ������ ��� ������� Label
            label1.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Underline);
            label3.Font = new System.Drawing.Font("Courier New", 14, FontStyle.Bold);

            // ������� ����� Label, ��� �������� �������� ������
            label1.Size = new System.Drawing.Size(400, 60);
            label2.Size = new System.Drawing.Size(400, 30);
            label3.Size = new System.Drawing.Size(400, 30);

            // ��������� �����
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label3.TextAlign = ContentAlignment.MiddleRight;

            // ������ Label �� �����
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
        }


    }
}