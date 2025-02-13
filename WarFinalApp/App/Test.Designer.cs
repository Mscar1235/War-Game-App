namespace App
{
    partial class Test
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NewLabel = new Label();
            ShuffleLabel = new Label();
            DealLabel = new Label();
            PrintTenLabel = new Label();
            TenthCardPicBox = new PictureBox();
            PrintPenLabel = new Label();
            PenultCardPicBox = new PictureBox();
            NewDeckText = new Label();
            ShuffledDeckText = new Label();
            DealAddText = new Label();
            StartButton = new Button();
            StartWar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)TenthCardPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PenultCardPicBox).BeginInit();
            SuspendLayout();
            // 
            // NewLabel
            // 
            NewLabel.Anchor = AnchorStyles.Left;
            NewLabel.AutoSize = true;
            NewLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NewLabel.Location = new Point(12, 191);
            NewLabel.Name = "NewLabel";
            NewLabel.Size = new Size(169, 21);
            NewLabel.TabIndex = 0;
            NewLabel.Text = "Newly Created Deck:";
            // 
            // ShuffleLabel
            // 
            ShuffleLabel.Anchor = AnchorStyles.Left;
            ShuffleLabel.AutoSize = true;
            ShuffleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ShuffleLabel.Location = new Point(12, 245);
            ShuffleLabel.Name = "ShuffleLabel";
            ShuffleLabel.Size = new Size(116, 21);
            ShuffleLabel.TabIndex = 2;
            ShuffleLabel.Text = "Shufled Deck:";
            // 
            // DealLabel
            // 
            DealLabel.Anchor = AnchorStyles.Left;
            DealLabel.AutoSize = true;
            DealLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DealLabel.Location = new Point(12, 293);
            DealLabel.Name = "DealLabel";
            DealLabel.Size = new Size(237, 21);
            DealLabel.TabIndex = 4;
            DealLabel.Text = "Deal Top Card and Put At End:";
            // 
            // PrintTenLabel
            // 
            PrintTenLabel.Anchor = AnchorStyles.Left;
            PrintTenLabel.AutoSize = true;
            PrintTenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PrintTenLabel.Location = new Point(49, 364);
            PrintTenLabel.Name = "PrintTenLabel";
            PrintTenLabel.Size = new Size(200, 21);
            PrintTenLabel.TabIndex = 6;
            PrintTenLabel.Text = "Print Image of 10th Card:";
            // 
            // TenthCardPicBox
            // 
            TenthCardPicBox.Anchor = AnchorStyles.Left;
            TenthCardPicBox.Location = new Point(21, 400);
            TenthCardPicBox.Name = "TenthCardPicBox";
            TenthCardPicBox.Size = new Size(282, 392);
            TenthCardPicBox.TabIndex = 7;
            TenthCardPicBox.TabStop = false;
            // 
            // PrintPenLabel
            // 
            PrintPenLabel.Anchor = AnchorStyles.Left;
            PrintPenLabel.AutoSize = true;
            PrintPenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PrintPenLabel.Location = new Point(328, 364);
            PrintPenLabel.Name = "PrintPenLabel";
            PrintPenLabel.Size = new Size(260, 21);
            PrintPenLabel.TabIndex = 8;
            PrintPenLabel.Text = "Print Image of Penultimate Card:";
            // 
            // PenultCardPicBox
            // 
            PenultCardPicBox.Anchor = AnchorStyles.Left;
            PenultCardPicBox.Location = new Point(328, 400);
            PenultCardPicBox.Name = "PenultCardPicBox";
            PenultCardPicBox.Size = new Size(282, 392);
            PenultCardPicBox.TabIndex = 9;
            PenultCardPicBox.TabStop = false;
            // 
            // NewDeckText
            // 
            NewDeckText.Anchor = AnchorStyles.Left;
            NewDeckText.AutoSize = true;
            NewDeckText.Location = new Point(12, 221);
            NewDeckText.MaximumSize = new Size(1000, 0);
            NewDeckText.Name = "NewDeckText";
            NewDeckText.Size = new Size(123, 15);
            NewDeckText.TabIndex = 10;
            NewDeckText.Text = "start test to see results";
            // 
            // ShuffledDeckText
            // 
            ShuffledDeckText.Anchor = AnchorStyles.Left;
            ShuffledDeckText.AutoSize = true;
            ShuffledDeckText.Location = new Point(12, 269);
            ShuffledDeckText.MaximumSize = new Size(1000, 0);
            ShuffledDeckText.Name = "ShuffledDeckText";
            ShuffledDeckText.Size = new Size(123, 15);
            ShuffledDeckText.TabIndex = 11;
            ShuffledDeckText.Text = "start test to see results";
            // 
            // DealAddText
            // 
            DealAddText.Anchor = AnchorStyles.Left;
            DealAddText.AutoSize = true;
            DealAddText.Location = new Point(12, 314);
            DealAddText.MaximumSize = new Size(1000, 0);
            DealAddText.Name = "DealAddText";
            DealAddText.Size = new Size(126, 15);
            DealAddText.TabIndex = 12;
            DealAddText.Text = " start test to see results";
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Top;
            StartButton.BackColor = SystemColors.GradientActiveCaption;
            StartButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            StartButton.Location = new Point(23, 12);
            StartButton.Margin = new Padding(3, 3, 3, 10);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(999, 84);
            StartButton.TabIndex = 13;
            StartButton.Text = "Start Test";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StartWar
            // 
            StartWar.Anchor = AnchorStyles.Right;
            StartWar.BackColor = SystemColors.Info;
            StartWar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            StartWar.Location = new Point(665, 481);
            StartWar.Name = "StartWar";
            StartWar.Size = new Size(328, 238);
            StartWar.TabIndex = 14;
            StartWar.Text = "Start War Game";
            StartWar.UseVisualStyleBackColor = false;
            StartWar.Click += StartWar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1068, 804);
            Controls.Add(StartWar);
            Controls.Add(StartButton);
            Controls.Add(DealAddText);
            Controls.Add(ShuffledDeckText);
            Controls.Add(NewDeckText);
            Controls.Add(PenultCardPicBox);
            Controls.Add(PrintPenLabel);
            Controls.Add(TenthCardPicBox);
            Controls.Add(PrintTenLabel);
            Controls.Add(DealLabel);
            Controls.Add(ShuffleLabel);
            Controls.Add(NewLabel);
            MinimumSize = new Size(1084, 843);
            Name = "Test";
            Text = "Test";
            ((System.ComponentModel.ISupportInitialize)TenthCardPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PenultCardPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewLabel;
        private Label ShuffleLabel;
        private Label DealLabel;
        private Label PrintTenLabel;
        private PictureBox TenthCardPicBox;
        private Label PrintPenLabel;
        private PictureBox PenultCardPicBox;
        private Label NewDeckText;
        private Label ShuffledDeckText;
        private Label DealAddText;
        private Button StartButton;
        private Button StartWar;
        private ContextMenuStrip contextMenuStrip1;
    }
}
