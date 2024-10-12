namespace timeeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int hours;
            int minutes;
            int seconds;
            if (!int.TryParse(textBox1.Text, out hours) || !int.TryParse(textBox2.Text, out minutes) || !int.TryParse(textBox3.Text, out seconds))
            {
                MessageBox.Show("введи норм значени€ емае");
                return;
            }
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            {
                MessageBox.Show("у теб€ познание времени вообще есть?");
                return;
            }
            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            label1.Text = $"—екунд с полуночи: {totalSeconds}";
        }
    }
}