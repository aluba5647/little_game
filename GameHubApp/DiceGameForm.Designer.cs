namespace GameHubApp
{
    partial class DiceGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picPlayerDice = new System.Windows.Forms.PictureBox();
            this.picCpuDice = new System.Windows.Forms.PictureBox();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuDice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPlayerScore.Location = new System.Drawing.Point(204, 273);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(109, 20);
            this.lblPlayerScore.TabIndex = 0;
            this.lblPlayerScore.Text = "玩家點數：";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblComputerScore.Location = new System.Drawing.Point(455, 273);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(109, 20);
            this.lblComputerScore.TabIndex = 1;
            this.lblComputerScore.Text = "電腦點數：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(335, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "結果";
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.SystemColors.Control;
            this.btnRoll.Location = new System.Drawing.Point(327, 303);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 48);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "擲骰子";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(327, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picPlayerDice
            // 
            this.picPlayerDice.Location = new System.Drawing.Point(207, 118);
            this.picPlayerDice.Name = "picPlayerDice";
            this.picPlayerDice.Size = new System.Drawing.Size(80, 80);
            this.picPlayerDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerDice.TabIndex = 5;
            this.picPlayerDice.TabStop = false;
            // 
            // picCpuDice
            // 
            this.picCpuDice.Location = new System.Drawing.Point(437, 118);
            this.picCpuDice.Name = "picCpuDice";
            this.picCpuDice.Size = new System.Drawing.Size(80, 80);
            this.picCpuDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCpuDice.TabIndex = 6;
            this.picCpuDice.TabStop = false;
            // 
            // turnTimer
            // 
            this.turnTimer.Interval = 1000;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(789, 436);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(11, 15);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "l";
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Location = new System.Drawing.Point(75, 269);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(75, 23);
            this.btnLeaderboard.TabIndex = 8;
            this.btnLeaderboard.Text = "排行榜";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // DiceGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picCpuDice);
            this.Controls.Add(this.picPlayerDice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Name = "DiceGameForm";
            this.Text = "DiceGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picPlayerDice;
        private System.Windows.Forms.PictureBox picCpuDice;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}