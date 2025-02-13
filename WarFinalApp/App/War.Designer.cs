namespace App
{
    partial class War
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(War));
            StartButton = new Button();
            playerPlayCardBox = new PictureBox();
            dealerPlayCardBox = new PictureBox();
            dealerWarCard1 = new PictureBox();
            dealerWarCard2 = new PictureBox();
            dealerWarCard3 = new PictureBox();
            playerWarCard1 = new PictureBox();
            dealerWarPlayCard = new PictureBox();
            playerWarCard2 = new PictureBox();
            playerWarCard3 = new PictureBox();
            playerWarPlayCard = new PictureBox();
            roundButton = new Button();
            playerDeck = new PictureBox();
            dealerDeck = new PictureBox();
            PlayerWinsLabel = new Label();
            dealerWinsLabel = new Label();
            gameOverLabel = new Label();
            endButton = new Button();
            autoPlayButton = new Button();
            dealerDeckLabel = new Label();
            playerDeckLabel = new Label();
            DrawLabel = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)playerPlayCardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerPlayCardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerWarCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarPlayCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerWarCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerWarCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerWarPlayCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDeck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerDeck).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StartButton.BackColor = Color.RosyBrown;
            StartButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            StartButton.Location = new Point(629, 298);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(458, 308);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start New Game";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // playerPlayCardBox
            // 
            playerPlayCardBox.Anchor = AnchorStyles.Bottom;
            playerPlayCardBox.Location = new Point(721, 557);
            playerPlayCardBox.Name = "playerPlayCardBox";
            playerPlayCardBox.Size = new Size(282, 392);
            playerPlayCardBox.TabIndex = 1;
            playerPlayCardBox.TabStop = false;
            // 
            // dealerPlayCardBox
            // 
            dealerPlayCardBox.Anchor = AnchorStyles.Top;
            dealerPlayCardBox.Location = new Point(721, 12);
            dealerPlayCardBox.Name = "dealerPlayCardBox";
            dealerPlayCardBox.Size = new Size(282, 392);
            dealerPlayCardBox.TabIndex = 2;
            dealerPlayCardBox.TabStop = false;
            // 
            // dealerWarCard1
            // 
            dealerWarCard1.Anchor = AnchorStyles.Top;
            dealerWarCard1.Location = new Point(587, 12);
            dealerWarCard1.Name = "dealerWarCard1";
            dealerWarCard1.Size = new Size(282, 392);
            dealerWarCard1.TabIndex = 3;
            dealerWarCard1.TabStop = false;
            // 
            // dealerWarCard2
            // 
            dealerWarCard2.Anchor = AnchorStyles.Top;
            dealerWarCard2.Location = new Point(499, 12);
            dealerWarCard2.Name = "dealerWarCard2";
            dealerWarCard2.Size = new Size(282, 392);
            dealerWarCard2.TabIndex = 4;
            dealerWarCard2.TabStop = false;
            // 
            // dealerWarCard3
            // 
            dealerWarCard3.Anchor = AnchorStyles.Top;
            dealerWarCard3.Location = new Point(399, 12);
            dealerWarCard3.Name = "dealerWarCard3";
            dealerWarCard3.Size = new Size(282, 392);
            dealerWarCard3.TabIndex = 5;
            dealerWarCard3.TabStop = false;
            // 
            // playerWarCard1
            // 
            playerWarCard1.Anchor = AnchorStyles.Bottom;
            playerWarCard1.Location = new Point(587, 557);
            playerWarCard1.Name = "playerWarCard1";
            playerWarCard1.Size = new Size(282, 392);
            playerWarCard1.TabIndex = 6;
            playerWarCard1.TabStop = false;
            // 
            // dealerWarPlayCard
            // 
            dealerWarPlayCard.Anchor = AnchorStyles.Top;
            dealerWarPlayCard.Location = new Point(299, 12);
            dealerWarPlayCard.Name = "dealerWarPlayCard";
            dealerWarPlayCard.Size = new Size(282, 392);
            dealerWarPlayCard.TabIndex = 7;
            dealerWarPlayCard.TabStop = false;
            // 
            // playerWarCard2
            // 
            playerWarCard2.Anchor = AnchorStyles.Bottom;
            playerWarCard2.Location = new Point(499, 557);
            playerWarCard2.Name = "playerWarCard2";
            playerWarCard2.Size = new Size(282, 392);
            playerWarCard2.TabIndex = 8;
            playerWarCard2.TabStop = false;
            // 
            // playerWarCard3
            // 
            playerWarCard3.Anchor = AnchorStyles.Bottom;
            playerWarCard3.Location = new Point(399, 557);
            playerWarCard3.Name = "playerWarCard3";
            playerWarCard3.Size = new Size(282, 392);
            playerWarCard3.TabIndex = 9;
            playerWarCard3.TabStop = false;
            // 
            // playerWarPlayCard
            // 
            playerWarPlayCard.Anchor = AnchorStyles.Bottom;
            playerWarPlayCard.Location = new Point(299, 557);
            playerWarPlayCard.Name = "playerWarPlayCard";
            playerWarPlayCard.Size = new Size(282, 392);
            playerWarPlayCard.TabIndex = 10;
            playerWarPlayCard.TabStop = false;
            // 
            // roundButton
            // 
            roundButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            roundButton.Font = new Font("Segoe UI", 12F);
            roundButton.Location = new Point(701, 421);
            roundButton.Name = "roundButton";
            roundButton.Size = new Size(151, 75);
            roundButton.TabIndex = 11;
            roundButton.Text = "Start Next Round";
            roundButton.UseVisualStyleBackColor = true;
            roundButton.Click += roundButton_Click;
            // 
            // playerDeck
            // 
            playerDeck.Anchor = AnchorStyles.Bottom;
            playerDeck.Location = new Point(1312, 557);
            playerDeck.Name = "playerDeck";
            playerDeck.Size = new Size(282, 392);
            playerDeck.TabIndex = 12;
            playerDeck.TabStop = false;
            // 
            // dealerDeck
            // 
            dealerDeck.Anchor = AnchorStyles.Top;
            dealerDeck.Location = new Point(1312, 12);
            dealerDeck.Name = "dealerDeck";
            dealerDeck.Size = new Size(282, 392);
            dealerDeck.TabIndex = 13;
            dealerDeck.TabStop = false;
            // 
            // PlayerWinsLabel
            // 
            PlayerWinsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PlayerWinsLabel.AutoSize = true;
            PlayerWinsLabel.BackColor = Color.Transparent;
            PlayerWinsLabel.Font = new Font("Segoe UI", 15F);
            PlayerWinsLabel.Location = new Point(785, 468);
            PlayerWinsLabel.Name = "PlayerWinsLabel";
            PlayerWinsLabel.Size = new Size(125, 28);
            PlayerWinsLabel.TabIndex = 14;
            PlayerWinsLabel.Text = "Player Wins!!";
            // 
            // dealerWinsLabel
            // 
            dealerWinsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dealerWinsLabel.AutoSize = true;
            dealerWinsLabel.Font = new Font("Segoe UI", 15F);
            dealerWinsLabel.Location = new Point(785, 468);
            dealerWinsLabel.Name = "dealerWinsLabel";
            dealerWinsLabel.Size = new Size(128, 28);
            dealerWinsLabel.TabIndex = 15;
            dealerWinsLabel.Text = "Dealer Wins!!";
            // 
            // gameOverLabel
            // 
            gameOverLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            gameOverLabel.AutoSize = true;
            gameOverLabel.Font = new Font("Segoe UI", 25F);
            gameOverLabel.Location = new Point(757, 421);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(188, 46);
            gameOverLabel.TabIndex = 16;
            gameOverLabel.Text = "Game Over";
            // 
            // endButton
            // 
            endButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            endButton.BackColor = Color.Crimson;
            endButton.Font = new Font("Segoe UI", 20F);
            endButton.Location = new Point(63, 828);
            endButton.Name = "endButton";
            endButton.Size = new Size(188, 102);
            endButton.TabIndex = 17;
            endButton.Text = "End Game";
            endButton.UseVisualStyleBackColor = false;
            endButton.Click += endButton_Click;
            // 
            // autoPlayButton
            // 
            autoPlayButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            autoPlayButton.Font = new Font("Segoe UI", 12F);
            autoPlayButton.Location = new Point(891, 421);
            autoPlayButton.Name = "autoPlayButton";
            autoPlayButton.Size = new Size(151, 75);
            autoPlayButton.TabIndex = 18;
            autoPlayButton.Text = "Auto-Play";
            autoPlayButton.UseVisualStyleBackColor = true;
            autoPlayButton.Click += autoPlayButton_Click;
            // 
            // dealerDeckLabel
            // 
            dealerDeckLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dealerDeckLabel.AutoSize = true;
            dealerDeckLabel.BackColor = Color.Transparent;
            dealerDeckLabel.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            dealerDeckLabel.ForeColor = SystemColors.HotTrack;
            dealerDeckLabel.Location = new Point(1225, 163);
            dealerDeckLabel.Name = "dealerDeckLabel";
            dealerDeckLabel.Size = new Size(81, 62);
            dealerDeckLabel.TabIndex = 19;
            dealerDeckLabel.Text = "26";
            // 
            // playerDeckLabel
            // 
            playerDeckLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            playerDeckLabel.AutoSize = true;
            playerDeckLabel.BackColor = Color.Transparent;
            playerDeckLabel.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            playerDeckLabel.ForeColor = SystemColors.HotTrack;
            playerDeckLabel.Location = new Point(1225, 736);
            playerDeckLabel.Name = "playerDeckLabel";
            playerDeckLabel.Size = new Size(81, 62);
            playerDeckLabel.TabIndex = 20;
            playerDeckLabel.Text = "26";
            // 
            // DrawLabel
            // 
            DrawLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DrawLabel.AutoSize = true;
            DrawLabel.Font = new Font("Segoe UI", 15F);
            DrawLabel.Location = new Point(816, 468);
            DrawLabel.Name = "DrawLabel";
            DrawLabel.Size = new Size(69, 28);
            DrawLabel.TabIndex = 21;
            DrawLabel.Text = "Draw!!";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.SeaGreen;
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 549);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // War
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1624, 961);
            Controls.Add(StartButton);
            Controls.Add(roundButton);
            Controls.Add(autoPlayButton);
            Controls.Add(gameOverLabel);
            Controls.Add(richTextBox1);
            Controls.Add(playerDeckLabel);
            Controls.Add(dealerDeckLabel);
            Controls.Add(endButton);
            Controls.Add(dealerDeck);
            Controls.Add(playerDeck);
            Controls.Add(playerWarPlayCard);
            Controls.Add(playerWarCard3);
            Controls.Add(playerWarCard2);
            Controls.Add(playerWarCard1);
            Controls.Add(playerPlayCardBox);
            Controls.Add(dealerWarPlayCard);
            Controls.Add(dealerWarCard3);
            Controls.Add(dealerWarCard2);
            Controls.Add(dealerWarCard1);
            Controls.Add(dealerPlayCardBox);
            Controls.Add(DrawLabel);
            Controls.Add(dealerWinsLabel);
            Controls.Add(PlayerWinsLabel);
            MinimumSize = new Size(1640, 900);
            Name = "War";
            Text = "War";
            ((System.ComponentModel.ISupportInitialize)playerPlayCardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerPlayCardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerWarCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerWarPlayCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerWarCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerWarCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerWarPlayCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDeck).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerDeck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private PictureBox playerPlayCardBox;
        private PictureBox dealerPlayCardBox;
        private PictureBox dealerWarCard1;
        private PictureBox dealerWarCard2;
        private PictureBox dealerWarCard3;
        private PictureBox playerWarCard1;
        private PictureBox dealerWarPlayCard;
        private PictureBox playerWarCard2;
        private PictureBox playerWarCard3;
        private PictureBox playerWarPlayCard;
        private Button roundButton;
        private PictureBox playerDeck;
        private PictureBox dealerDeck;
        private Label PlayerWinsLabel;
        private Label dealerWinsLabel;
        private Label gameOverLabel;
        private Button endButton;
        private Button autoPlayButton;
        private Label dealerDeckLabel;
        private Label playerDeckLabel;
        private Label DrawLabel;
        private RichTextBox richTextBox1;
    }
}