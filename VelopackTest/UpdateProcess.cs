using Velopack;
using Velopack.Sources;

namespace VelopackTest
{
    internal class UpdateProcess
    {
        private const string GITHUB_URL = "https://github.com/NXKoses/VelopackTest";

        public static async Task CheckForUpdateAsync()
        {
            try
            {
                var mgr = new UpdateManager(new GithubSource(GITHUB_URL, null, false));

                if (!mgr.IsInstalled)
                {
                    // インストールされていない場合は、インストールを促す
                    MessageBox.Show("更新を確認できませんでした。", "エラー", MessageBoxButtons.OK);
                    return;
                }

                // 新しいバージョンがないかをチェックする
                var newVersion = await mgr.CheckForUpdatesAsync();
                if (newVersion == null)
                {
                    return; // 新しいバージョンがない場合は何もしない
                }

                var result = MessageBox.Show("新しいバージョンが見つかりました。更新しますか？", "更新", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await mgr.DownloadUpdatesAsync(newVersion);
                    mgr.ApplyUpdatesAndRestart(newVersion);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK);
            }
        }
    }
}
