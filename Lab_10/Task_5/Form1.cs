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

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            double principal = Convert.ToDouble(principalTextBox.Text);
            

            int months = Convert.ToInt32(monthsTextBox.Text);
            double interestRate = Convert.ToDouble(interestRateTextBox.Text) / 100;

            double endPayment = principal + principal * interestRate;

            double monthlyPayment = endPayment / months; // ����������� ������

            double rate = (endPayment - principal) / months;

            // ���������� ��� ������� ������
            for (int month = 1; month <= months; month++)
            {

                ListViewItem item = new ListViewItem(month.ToString());
                item.SubItems.Add(endPayment.ToString("C")); // ����������� ��� ������
                item.SubItems.Add(rate.ToString("C"));
                item.SubItems.Add(monthlyPayment.ToString("C"));
                listView1.Items.Add(item);

                endPayment -= monthlyPayment; // ��������� ���������� ����� �����
            }
        }
    }
}