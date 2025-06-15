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
    public partial class turnTimer : Form
    {
        private static List<string> leaderboard = new List<string>();//排行榜
        private int totalGames = 0;
        private int winCount = 0;


        private const int BoardSize = 15; // 15x15 棋盤
        private const int CellSize = 30;  // 每格 30px
        private int[,] board = new int[BoardSize, BoardSize]; // 0: 空, 1: 玩家1, 2: 玩家2/電腦
        private int currentPlayer = 1;
        private bool vsAI = false;
        private bool gameOver = false;
        public turnTimer()
        {
            InitializeComponent();
            pnlBoard.Paint += DrawBoard;
            pnlBoard.MouseClick += HandleClick;
            pnlBoard.Width = BoardSize * CellSize;
            pnlBoard.Height = BoardSize * CellSize;

            cmbMode.Items.Add("PVP");
            cmbMode.Items.Add("PVE");
            cmbMode.SelectedIndex = 0;

            cmbDifficulty.Items.Add("中等");
            cmbDifficulty.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            board = new int[BoardSize, BoardSize];
            currentPlayer = 1;
            gameOver = false;
            lblStatus.Text = "";
            vsAI = cmbMode.SelectedItem.ToString() == "PVE";
            pnlBoard.Invalidate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DrawBoard(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = Pens.Black;

            for (int i = 0; i < BoardSize; i++)
            {
                g.DrawLine(pen, i * CellSize, 0, i * CellSize, BoardSize * CellSize);
                g.DrawLine(pen, 0, i * CellSize, BoardSize * CellSize, i * CellSize);
            }

            // 畫棋子
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 1)
                        g.FillEllipse(Brushes.Black, x * CellSize + 2, y * CellSize + 2, CellSize - 4, CellSize - 4);
                    else if (board[x, y] == 2)
                        g.FillEllipse(Brushes.White, x * CellSize + 2, y * CellSize + 2, CellSize - 4, CellSize - 4);
                }
            }
        }
        private void HandleClick(object sender, MouseEventArgs e)
        {
            if (gameOver || currentPlayer == 2 && vsAI) return; // 電腦不要手動下棋

            int x = e.X / CellSize;
            int y = e.Y / CellSize;

            if (x >= BoardSize || y >= BoardSize || board[x, y] != 0) return;

            board[x, y] = currentPlayer;
            pnlBoard.Invalidate();

            if (CheckWin(x, y, currentPlayer))
            {
                gameOver = true;
                lblStatus.Text = $"玩家{currentPlayer} 勝利！";

                totalGames++;
                if (currentPlayer == 1) winCount++;

                leaderboard.Add($"第 {totalGames} 局：玩家{currentPlayer} 勝（玩家1勝率 {winCount}/{totalGames}）");

                return;
            }

            // 換人
            currentPlayer = currentPlayer == 1 ? 2 : 1;

            // ✅ 每次換人時重設計時器
            StartTurnTimer();

            if (vsAI && currentPlayer == 2)
            {
                AIMove();
            }
        }
        private void StartTurnTimer()
        {
            //turnTime = 10;
            //lblTimer.Text = $"剩餘時間：{turnTime} 秒";
            //turnTimer.Start();
        }
        private void AIMove()
        {
            string difficulty = cmbDifficulty.SelectedItem.ToString();

            if (difficulty == "簡單")
            {
               // SimpleAIMove();// 原本的邏輯
                return;
            }
            else if (difficulty == "中等")
            {
                MediumAIMove(); // 新的中等難度邏輯
                return;
            }
        }
            
        private void SimpleAIMove()
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 0)
                    {
                        board[x, y] = 2; // 試著放
                        if (CheckWin(x, y, 2))
                        {
                            FinalizeAIMove(x, y);
                            return;
                        }
                        board[x, y] = 0; // 撤回
                    }
                }
            }
        }
        private void MediumAIMove()
{
            // 1. 嘗試贏
            if (TryWinOrBlock(2)) return;

            // 2. 嘗試擋玩家致勝（即將贏）
            if (TryWinOrBlock(1)) return;

            // 3. 偵測玩家可能的活三或活四
            if (TryBlockThreat()) return;

            // 4. 嘗試找活三或活四自己進攻
            Point? strategic = FindStrategicMove(2);
            if (strategic != null)
            {
                FinalizeAIMove(strategic.Value.X, strategic.Value.Y);
                return;
            }

            // 5. 靠近下
            for (int radius = 1; radius < 4; radius++)
            {
                for (int x = 0; x < BoardSize; x++)
                {
                    for (int y = 0; y < BoardSize; y++)
                    {
                        if (board[x, y] == 0 && HasNeighbor(x, y, radius))
                        {
                            board[x, y] = 2;
                            FinalizeAIMove(x, y);
                            return;
                        }
                    }
                }
            }

            // 6. 亂下
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 0)
                    {
                        board[x, y] = 2;
                        FinalizeAIMove(x, y);
                        return;
                    }
                }
            }
        }
        private bool TryBlockThreat()
        {
            Point? bestBlock = null;
            int maxThreat = 0;

            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 0)
                    {
                        board[x, y] = 1; // 假設玩家在這裡下
                        int threat = CountConnected(x, y, 1); // 評估玩家連線數
                        board[x, y] = 0; // 撤回

                        if (threat >= 3 && threat > maxThreat)
                        {
                            bestBlock = new Point(x, y);
                            maxThreat = threat;
                        }
                    }
                }
            }

            if (bestBlock != null)
            {
                FinalizeAIMove(bestBlock.Value.X, bestBlock.Value.Y);
                return true;
            }

            return false;
        }
        private bool TryWinOrBlock(int player)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 0)
                    {
                        board[x, y] = player;
                        if (CheckWin(x, y, player))
                        {
                            board[x, y] = 2; // AI 下這
                            FinalizeAIMove(x, y);
                            return true;
                        }
                        board[x, y] = 0;
                    }
                }
            }
            return false;
        }
        private Point? FindStrategicMove(int player)
        {
            Point? bestMove = null;
            int maxScore = 0;

            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 0)
                    {
                        int score = CountConnected(x, y, player);
                        if (score >= 3 && score > maxScore)
                        {
                            maxScore = score;
                            bestMove = new Point(x, y);
                        }
                    }
                }
            }
            return bestMove;
        }

        private int CountConnected(int x, int y, int player)
        {
            // 評估落在這格後，與鄰近方向最多有幾顆連續
            int max = 0;
            int[][] dirs = new int[][] {
        new int[]{1, 0}, new int[]{0, 1},
        new int[]{1, 1}, new int[]{1, -1}
    };

            foreach (var dir in dirs)
            {
                int count = CountDirection(x, y, dir[0], dir[1], player) +
                            CountDirection(x, y, -dir[0], -dir[1], player);
                max = Math.Max(max, count);
            }
            return max;
        }

        private void FinalizeAIMove(int x, int y)
        {
            board[x, y] = 2;  // AI 真正下這一步
            pnlBoard.Invalidate();

            if (CheckWin(x, y, 2))
            {
                gameOver = true;
                lblStatus.Text = "電腦獲勝！";

                totalGames++;
                leaderboard.Add($"第 {totalGames} 局：電腦勝（玩家1勝率 {winCount}/{totalGames}）");
            }

            currentPlayer = 1;
        }

        private bool HasNeighbor(int x, int y, int range)
        {
            for (int dx = -range; dx <= range; dx++)
            {
                for (int dy = -range; dy <= range; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;
                    if (nx >= 0 && ny >= 0 && nx < BoardSize && ny < BoardSize)
                    {
                        if (board[nx, ny] != 0)
                            return true;
                    }
                }
            }
            return false;
        }

        private bool CheckWin(int x, int y, int player)
        {
            return CountDirection(x, y, 1, 0, player) + CountDirection(x, y, -1, 0, player) >= 4 ||
                   CountDirection(x, y, 0, 1, player) + CountDirection(x, y, 0, -1, player) >= 4 ||
                   CountDirection(x, y, 1, 1, player) + CountDirection(x, y, -1, -1, player) >= 4 ||
                   CountDirection(x, y, 1, -1, player) + CountDirection(x, y, -1, 1, player) >= 4;
        }

        private int CountDirection(int x, int y, int dx, int dy, int player)
        {
            int count = 0;
            for (int i = 1; i < 5; i++)
            {
                int nx = x + dx * i;
                int ny = y + dy * i;
                if (nx < 0 || ny < 0 || nx >= BoardSize || ny >= BoardSize || board[nx, ny] != player)
                    break;
                count++;
            }
            return count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 加上這段計時邏輯 ↓
            //turnTime--;
            //lblTimer.Text = $"剩餘時間：{turnTime} 秒";

            //if (turnTime <= 0)
            {
                //turnTimer.Stop();
                lblStatus.Text = $"玩家{currentPlayer} 超時，換對方下";

                currentPlayer = currentPlayer == 1 ? 2 : 1;
                StartTurnTimer();

                if (vsAI && currentPlayer == 2)
                {
                    AIMove();
                }
            }
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm lb = new LeaderboardForm(leaderboard, "");
            lb.ShowDialog();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
