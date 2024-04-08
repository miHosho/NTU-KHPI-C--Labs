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
            button1.MouseEnter += new EventHandler(btn1_anim);
            button1.MouseLeave += new EventHandler(btn1_anim);

            button2.MouseEnter += new EventHandler(btn2_anim);
            button2.MouseLeave += new EventHandler(btn2_anim);

            button3.MouseEnter += new EventHandler(btn3_anim);
            button3.MouseLeave += new EventHandler(btn3_anim);
        }
        private void btn1_anim(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Green) button1.BackColor = Color.White;
            else button1.BackColor = Color.Green;
        }

        private void btn2_anim(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Green) button2.BackColor = Color.White;
            else button2.BackColor = Color.Green;
        }
        private void btn3_anim(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Green) button3.BackColor = Color.White;
            else button3.BackColor = Color.Green;
        }
    }
}