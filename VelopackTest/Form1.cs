namespace VelopackTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // �X�V���m�F����
            await UpdateProcess.CheckForUpdateAsync();
        }
    }
}
