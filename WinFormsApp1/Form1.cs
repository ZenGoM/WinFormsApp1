namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings1.Default.test1;
            label2.Text = Properties.Settings1.Default.test2;
        }
    }
}