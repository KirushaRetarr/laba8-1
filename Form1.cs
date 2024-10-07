namespace laba8
{
    public partial class Form1 : Form
    {
        bool isClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                button1.BackColor = Color.Aqua;
                button2.Height = 100;
                button3.Visible = false;
                button4.Text = "Текст";
                button4.Enabled = false;
                button5.Location = new Point(315, 53);
                isClicked = true;
            }
            else
            {
                button1.BackColor = Color.White;
                button2.Height = 23;
                button3.Visible = true;
                button4.Text = "button 4";
                button4.Enabled = true;
                button5.Location = new Point(315, 103);
                isClicked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
