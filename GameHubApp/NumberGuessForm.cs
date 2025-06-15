using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHubApp
{
    public partial class NumberGuessForm : Form
    {
        private static List<string> leaderboard = new List<string>();//排行榜
        private DateTime startTime;

        private int secretNumber;
        private int guessCount;
        private Random random = new Random();
        public NumberGuessForm()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            secretNumber = random.Next(1, 101); // 1~100
            guessCount = 0;
            lblHint.Text = "";
            lblCount.Text = "次數：0";
            txtGuess.Text = "";
            txtGuess.Focus();
            startTime = DateTime.Now;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int guess))
            {
                guessCount++;
                lblCount.Text = $"次數：{guessCount}";

                if (guess > secretNumber)
                {
                    lblHint.Text = "太大了！再試一次";
                }
                else if (guess < secretNumber)
                {
                    lblHint.Text = "太小了！再試一次";
                }
                else
                {
                    TimeSpan timeUsed = DateTime.Now - startTime;
                    lblHint.Text = $"🎉 恭喜你猜對了！答案是 {secretNumber}";

                    string record = $"猜中！次數：{guessCount}，用時：{timeUsed.Seconds} 秒";
                    leaderboard.Add(record);

                    MessageBox.Show("你猜對了！已加入排行榜！", "🎉 完成");
                }
            }
            else
            {
                lblHint.Text = "請輸入有效的整數！";
            }
            txtGuess.SelectAll();
            txtGuess.Focus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm lb = new LeaderboardForm(leaderboard, "");
            lb.ShowDialog();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
