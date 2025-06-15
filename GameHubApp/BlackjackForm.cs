using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHubApp
{
    public partial class BlackjackForm : Form
    {
        private static List<string> leaderboard = new List<string>();//排行榜
        private int totalGames = 0;
        private int winCount = 0;

        private List<string> deck = new List<string>();
        private List<string> playerHand = new List<string>();
        private List<string> dealerHand = new List<string>();
        private Random random = new Random();
        public BlackjackForm()
        {
            // 設定背景圖片
            this.BackgroundImage = Properties.Resources.pook; // 如果檔名叫 bg.png
            this.BackgroundImageLayout = ImageLayout.Stretch; // 讓圖片填滿表單
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            deck = CreateDeck();
            playerHand.Clear();
            dealerHand.Clear();
            lstPlayerCards.Items.Clear();
            lstDealerCards.Items.Clear();
            lblResult.Text = "";

            // 發牌
            playerHand.Add(DrawCard());
            playerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());

            // 顯示
            DisplayHand(playerHand, lstPlayerCards);
            DisplayHand(dealerHand, lstDealerCards);

            lblPlayerPoints.Text = "玩家點數：" + CalculatePoints(playerHand);
            lblDealerPoints.Text = "電腦點數：" + CalculatePoints(new List<string> { dealerHand[0] }) + " + ?";

            // 啟用按鈕
            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand.Add(DrawCard());
            DisplayHand(playerHand, lstPlayerCards);
            int playerPoints = CalculatePoints(playerHand);
            lblPlayerPoints.Text = "玩家點數：" + playerPoints;

            if (playerPoints > 21)
            {
                lblResult.Text = "爆牌！你輸了！";
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                totalGames++;
                leaderboard.Add($"第 {totalGames} 局：玩家爆牌輸了！（勝率 {winCount}/{totalGames}）");


            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            // 玩家停牌，電腦補牌
            while (CalculatePoints(dealerHand) < 17)
            {
                dealerHand.Add(DrawCard());
            }

            DisplayHand(dealerHand, lstDealerCards);
            int playerPoints = CalculatePoints(playerHand);
            int dealerPoints = CalculatePoints(dealerHand);

            lblPlayerPoints.Text = "玩家點數：" + playerPoints;
            lblDealerPoints.Text = "電腦點數：" + dealerPoints;

            string result = "";
            if (dealerPoints > 21 || playerPoints > dealerPoints)
                result = "你贏了！🎉";
            else if (playerPoints < dealerPoints)
                result = "你輸了 😢";
            else
                result = "平手！";

            lblResult.Text = result;

            btnHit.Enabled = false;
            btnStand.Enabled = false;

            totalGames++;//排行榜
            if (result.Contains("贏"))
            {
                winCount++;
            }
             totalGames++;
            leaderboard.Add($"第 {totalGames} 局：{result}（勝率 {winCount}/{totalGames}）");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<string> CreateDeck()
        {

            List<string> newDeck = new List<string>();
            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    newDeck.Add(value + suit);
                }
            }

            // 隨機洗牌
            for (int i = newDeck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (newDeck[i], newDeck[j]) = (newDeck[j], newDeck[i]);
            }

            return newDeck;
        }


        private string DrawCard()
        {
            string card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        private void DisplayHand(List<string> hand, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var card in hand)
            {
                listBox.Items.Add(card);
            }
        }

        private int CalculatePoints(List<string> hand)
        {
            int total = 0;
            int aceCount = 0;

            foreach (string card in hand)
            {
                string value = card.Substring(0, card.Length - 1);
                if (value == "A")
                {
                    aceCount++;
                    total += 11;
                }
                else if (value == "J" || value == "Q" || value == "K")
                {
                    total += 10;
                }
                else
                {
                    total += int.Parse(value);
                }
            }

            // 如果爆了，把 A 從 11 改為 1
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm lb = new LeaderboardForm(leaderboard, "");
            lb.ShowDialog();
        }
    }
}
