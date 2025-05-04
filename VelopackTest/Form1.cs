using System.Reflection;

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
            await UpdateProcess.CheckForUpdateAsync(this);

            var assembly = Assembly.GetExecutingAssembly().GetName();
            var version = assembly.Version;
            label1.Text = version.ToString(3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
