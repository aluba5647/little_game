namespace GameHubApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDiceGame = new System.Windows.Forms.Button();
            this.btnBlackjack = new System.Windows.Forms.Button();
            this.btnGomoku = new System.Windows.Forms.Button();
            this.btnNumberGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("PMingLiU", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(277, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "\t遊戲大廳";
            // 
            // btnDiceGame
            // 
            this.btnDiceGame.Location = new System.Drawing.Point(92, 185);
            this.btnDiceGame.Name = "btnDiceGame";
            this.btnDiceGame.Size = new System.Drawing.Size(90, 90);
            this.btnDiceGame.TabIndex = 1;
            this.btnDiceGame.Text = "骰子遊戲";
            this.btnDiceGame.UseVisualStyleBackColor = true;
            this.btnDiceGame.Click += new System.EventHandler(this.btnDiceGame_Click);
            // 
            // btnBlackjack
            // 
            this.btnBlackjack.Location = new System.Drawing.Point(237, 185);
            this.btnBlackjack.Name = "btnBlackjack";
            this.btnBlackjack.Size = new System.Drawing.Size(90, 90);
            this.btnBlackjack.TabIndex = 2;
            this.btnBlackjack.Text = "二十一點";
            this.btnBlackjack.UseVisualStyleBackColor = true;
            this.btnBlackjack.Click += new System.EventHandler(this.btnBlackjack_Click);
            // 
            // btnGomoku
            // 
            this.btnGomoku.Location = new System.Drawing.Point(354, 185);
            this.btnGomoku.Name = "btnGomoku";
            this.btnGomoku.Size = new System.Drawing.Size(90, 90);
            this.btnGomoku.TabIndex = 3;
            this.btnGomoku.Text = "五子棋";
            this.btnGomoku.UseVisualStyleBackColor = true;
            this.btnGomoku.Click += new System.EventHandler(this.btnGomoku_Click);
            // 
            // btnNumberGuess
            // 
            this.btnNumberGuess.Location = new System.Drawing.Point(494, 185);
            this.btnNumberGuess.Name = "btnNumberGuess";
            this.btnNumberGuess.Size = new System.Drawing.Size(90, 90);
            this.btnNumberGuess.TabIndex = 4;
            this.btnNumberGuess.Text = "猜數字";
            this.btnNumberGuess.UseVisualStyleBackColor = true;
            this.btnNumberGuess.Click += new System.EventHandler(this.btnNumberGuess_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumberGuess);
            this.Controls.Add(this.btnGomoku);
            this.Controls.Add(this.btnBlackjack);
            this.Controls.Add(this.btnDiceGame);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDiceGame;
        private System.Windows.Forms.Button btnBlackjack;
        private System.Windows.Forms.Button btnGomoku;
        private System.Windows.Forms.Button btnNumberGuess;
    }
}

