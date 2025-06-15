namespace GameHubApp
{
    partial class BlackjackForm
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
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.lblDealerPoints = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstPlayerCards = new System.Windows.Forms.ListBox();
            this.lstDealerCards = new System.Windows.Forms.ListBox();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.Location = new System.Drawing.Point(236, 221);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(82, 15);
            this.lblPlayerPoints.TabIndex = 0;
            this.lblPlayerPoints.Text = "玩家點數：";
            // 
            // lblDealerPoints
            // 
            this.lblDealerPoints.AutoSize = true;
            this.lblDealerPoints.Location = new System.Drawing.Point(487, 221);
            this.lblDealerPoints.Name = "lblDealerPoints";
            this.lblDealerPoints.Size = new System.Drawing.Size(82, 15);
            this.lblDealerPoints.TabIndex = 1;
            this.lblDealerPoints.Text = "電腦點數：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(84, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 15);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "結果：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(248, 272);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 46);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "發牌";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(367, 272);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(88, 46);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "\t要牌";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(481, 272);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(88, 46);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "停牌";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(593, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 46);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstPlayerCards
            // 
            this.lstPlayerCards.FormattingEnabled = true;
            this.lstPlayerCards.ItemHeight = 15;
            this.lstPlayerCards.Location = new System.Drawing.Point(239, 76);
            this.lstPlayerCards.Name = "lstPlayerCards";
            this.lstPlayerCards.Size = new System.Drawing.Size(137, 124);
            this.lstPlayerCards.TabIndex = 7;
            // 
            // lstDealerCards
            // 
            this.lstDealerCards.FormattingEnabled = true;
            this.lstDealerCards.ItemHeight = 15;
            this.lstDealerCards.Location = new System.Drawing.Point(481, 76);
            this.lstDealerCards.Name = "lstDealerCards";
            this.lstDealerCards.Size = new System.Drawing.Size(137, 124);
            this.lstDealerCards.TabIndex = 8;
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Location = new System.Drawing.Point(61, 217);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(75, 23);
            this.btnLeaderboard.TabIndex = 9;
            this.btnLeaderboard.Text = "排行榜";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.lstDealerCards);
            this.Controls.Add(this.lstPlayerCards);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDealerPoints);
            this.Controls.Add(this.lblPlayerPoints);
            this.Name = "BlackjackForm";
            this.Text = "BlackjackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label lblDealerPoints;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstPlayerCards;
        private System.Windows.Forms.ListBox lstDealerCards;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}