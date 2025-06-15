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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            // 設定背景圖片

            InitializeComponent();
            this.BackgroundImage = Properties.Resources.gggg; // 如果檔名叫 bg.png
            this.BackgroundImageLayout = ImageLayout.Stretch; // 讓圖片填滿表單
        }

        private void btnDiceGame_Click(object sender, EventArgs e)
        {
            DiceGameForm diceGame = new DiceGameForm();
            diceGame.ShowDialog();
        }

        private void btnBlackjack_Click(object sender, EventArgs e)
        {
            BlackjackForm blackjackGame = new BlackjackForm();
            blackjackGame.ShowDialog();
        }
     

        private void btnGomoku_Click(object sender, EventArgs e)
        {
            turnTimer gomokuGame = new turnTimer();
            gomokuGame.ShowDialog();

        }

        private void btnNumberGuess_Click(object sender, EventArgs e)
        {
           NumberGuessForm numberGuessGame = new NumberGuessForm();
           numberGuessGame.ShowDialog();
        }
    }
    }

