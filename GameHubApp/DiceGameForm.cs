using GameHubApp.Properties;
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
    public partial class DiceGameForm : Form
    {
        private static List<string> leaderboard = new List<string>();//排行榜
        private int totalGames = 0;
        private int winCount = 0;

        private int turnTime = 10;
        private Random random = new Random();

        public DiceGameForm()
        {
            // 設定背景圖片
            this.BackgroundImage = Properties.Resources.dicepic; // 如果檔名叫 bg.png
            this.BackgroundImageLayout = ImageLayout.Stretch; // 讓圖片填滿表單
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int player = random.Next(1, 7);    // 1~6
            int computer = random.Next(1, 7);

            lblPlayerScore.Text = "玩家點數：" + player;
            lblComputerScore.Text = "電腦點數：" + computer;
            // C: \Users\93022\source\repos\GameHubApp\GameHubApp\Resources\dice1.png
            picPlayerDice.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + player);
            picCpuDice.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + computer);

            if (player > computer)
            {
                winCount++;
                lblResult.Text = "你贏了！🎉";
            }
            else if (player < computer)
            {
                lblResult.Text = "你輸了 😢";
            }
            else
            {
                lblResult.Text = "平手！";
            }

            totalGames++;
            leaderboard.Add($"第 {totalGames} 局：{lblResult.Text}");

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
    }
}
