namespace fukuv0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int ans = rand.Next(101);
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show(count.ToString() + "��ڂ̒���");
            int guess = int.Parse(textBox1.Text);
            if (ans == guess)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
                ans = rand.Next(101);
            }
            else if (ans < guess)
                MessageBox.Show("Less");
            else
                MessageBox.Show("Greater");
        }
    }
}