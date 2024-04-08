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
            button1.MouseEnter += new EventHandler(btn_anim);
            button1.MouseLeave += new EventHandler(btn_anim);

            button2.MouseEnter += new EventHandler(btn_anim);
            button2.MouseLeave += new EventHandler(btn_anim);

            button3.MouseEnter += new EventHandler(btn_anim);
            button3.MouseLeave += new EventHandler(btn_anim);
        }
        private void btn_anim(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;

            if (clickedBtn.BackColor == Color.Green) clickedBtn.BackColor = Color.White;
            else clickedBtn.BackColor = Color.Green;
        }
    }
}