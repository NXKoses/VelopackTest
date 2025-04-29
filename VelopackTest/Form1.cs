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
            // 更新を確認する
            await UpdateProcess.CheckForUpdateAsync();
        }
    }
}
