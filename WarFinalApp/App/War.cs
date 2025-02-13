using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class War : Form
    {
        CardGroup playerCards;
        CardGroup dealerCards;
        CardGroup initDeck;
        Card playerPlayCard;
        Card dealerPlayCard;
        CardGroup playerWarCards;
        CardGroup dealerWarCards;
        Card dealerWarPlayCardCode;
        Card playerWarPlayCardCode;
        bool auto = false;
        ResourceManager rm = new ResourceManager(typeof(Resource1));
        bool atWar = false;
        public War()
        {
            InitializeComponent();
            HideAll();
            endButton.Hide();
            dealerDeckLabel.Hide();
            playerDeckLabel.Hide();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ((Control)sender).Hide();
            endButton.Show();
            StartGame();
            ShowOptions();
        }

        public void StartGame()
        {
            PopulateCards();
        }


        private void roundButton_Click(object sender, EventArgs e)
        {
            roundButton.Hide();
            autoPlayButton.Hide();
            DealCards();
            Wait(2000);
            CheckWinner();
        }

        public void AutoPlay()
        {
            while (auto)
            {
                DealCards();
                Wait(2000);
                CheckWinner();
            }
        }


        public void PopulateCards()
        {
            //----------------------------------populate cards-----------------------------------------------
            playerWarCards = new CardGroup();
            dealerWarCards = new CardGroup();

            playerCards = new CardGroup();
            dealerCards = new CardGroup();
            initDeck = new CardGroup();

            initDeck.MakeWholeDeck();
            initDeck.Shuffle();

            for (int i = 0; i < initDeck.NumCards; i += 2)
            {
                playerCards.AddToGroup(initDeck.GetCard(i));
                dealerCards.AddToGroup(initDeck.GetCard(i + 1));
            }
            UpdateLabels();
            playerDeck.Image = (Bitmap)rm.GetObject("red");
            dealerDeck.Image = (Bitmap)rm.GetObject("red");
            playerDeck.Show();
            dealerDeck.Show();
            dealerDeckLabel.Show();
            playerDeckLabel.Show();

        }

        public void DealCards()
        {
            Debug.WriteLine("in dealCards()");
            playerPlayCard = playerCards.DealTopCard();
            dealerPlayCard = dealerCards.DealTopCard();


            string playerFile = playerPlayCard.FileName();
            string dealerFile = dealerPlayCard.FileName();

            playerPlayCardBox.Image = (Bitmap)rm.GetObject(playerFile);
            dealerPlayCardBox.Image = (Bitmap)rm.GetObject(dealerFile);



            playerPlayCardBox.Show();
            dealerPlayCardBox.Show();
            UpdateLabels();

        }

        public void CheckWinner()
        {
            int dealerValue = 0;
            int playerValue = 0;
            if (!atWar)
            {
                if (int.TryParse(playerPlayCard.Face, out playerValue))
                {
                    //do nothing
                }
                else
                {
                    switch (playerPlayCard.Face)
                    {
                        case "A":
                            playerValue = 14;
                            break;
                        case "K":
                            playerValue = 13;
                            break;
                        case "Q":
                            playerValue = 12;
                            break;
                        case "J":
                            playerValue = 11;
                            break;

                    }
                }

                if (int.TryParse(dealerPlayCard.Face, out dealerValue))
                {
                    //do nothing
                }
                else
                {
                    switch (dealerPlayCard.Face)
                    {
                        case "A":
                            dealerValue = 14;
                            break;
                        case "K":
                            dealerValue = 13;
                            break;
                        case "Q":
                            dealerValue = 12;
                            break;
                        case "J":
                            dealerValue = 11;
                            break;

                    }
                }

                if (playerValue > dealerValue)
                {
                    PlayerWins();
                }
                else if (playerValue < dealerValue)
                {
                    DealerWins();
                }
                else
                {

                    GoToWar();
                }
            }
            else
            {
                if (int.TryParse(playerWarPlayCardCode.Face, out playerValue))
                {
                    //do nothing
                }
                else
                {
                    switch (playerWarPlayCardCode.Face)
                    {
                        case "A":
                            playerValue = 14;
                            break;
                        case "K":
                            playerValue = 13;
                            break;
                        case "Q":
                            playerValue = 12;
                            break;
                        case "J":
                            playerValue = 11;
                            break;

                    }
                }

                if (int.TryParse(dealerWarPlayCardCode.Face, out dealerValue))
                {
                    //do nothing
                }
                else
                {
                    switch (dealerWarPlayCardCode.Face)
                    {
                        case "A":
                            dealerValue = 14;
                            break;
                        case "K":
                            dealerValue = 13;
                            break;
                        case "Q":
                            dealerValue = 12;
                            break;
                        case "J":
                            dealerValue = 11;
                            break;

                    }
                }

                if (playerValue > dealerValue)
                {
                    PlayerWinsWar();
                }
                else if (playerValue < dealerValue)
                {
                    DealerWinsWar();
                }
                else
                {

                    WarDraw();
                }
            }



        }



        public void PlayerWins()
        {

            playerCards.AddToGroup(dealerPlayCard);
            playerCards.AddToGroup(playerPlayCard);
            UpdateLabels();
            PlayerWinsLabel.Show();
            Wait(2000);
            playerPlayCardBox.Hide();
            dealerPlayCardBox.Hide();
            PlayerWinsLabel.Hide();
            CheckGameOver();

        }

        public void DealerWins()
        {
            dealerCards.AddToGroup(dealerPlayCard);
            dealerCards.AddToGroup(playerPlayCard);
            UpdateLabels();
            dealerWinsLabel.Show();
            Wait(2000);
            playerPlayCardBox.Hide();
            dealerPlayCardBox.Hide();
            dealerWinsLabel.Hide();
            CheckGameOver();
        }



        public void GoToWar()
        {

            if ((dealerCards.NumCards < 4 && playerCards.NumCards < 4) || atWar)
            {
                WarDraw();
            }
            else if (dealerCards.NumCards < 4)
            {
                PlayerWinsWar();
            }
            else if (playerCards.NumCards < 4)
            {
                DealerWinsWar();
            }
            else //war
            {
                atWar = true;
                for (int i = 0; i < 3; i++)
                {
                    playerWarCards.AddToGroup(playerCards.DealTopCard());
                    dealerWarCards.AddToGroup(dealerCards.DealTopCard());
                }

                dealerWarPlayCardCode = dealerCards.DealTopCard();
                playerWarPlayCardCode = playerCards.DealTopCard();

                playerWarCard1.Image = (Bitmap)rm.GetObject("red");
                dealerWarCard1.Image = (Bitmap)rm.GetObject("red");
                playerWarCard1.Show();
                dealerWarCard1.Show();
                Wait(1500);

                playerWarCard2.Image = (Bitmap)rm.GetObject("red");
                dealerWarCard2.Image = (Bitmap)rm.GetObject("red");
                playerWarCard2.Show();
                dealerWarCard2.Show();
                Wait(1500);

                playerWarCard3.Image = (Bitmap)rm.GetObject("red");
                dealerWarCard3.Image = (Bitmap)rm.GetObject("red");
                playerWarCard3.Visible = true;
                dealerWarCard3.Visible = true;
                Wait(2000);

                string playerfile = playerWarPlayCardCode.FileName();
                string dealerfile = dealerWarPlayCardCode.FileName();

                playerWarPlayCard.Image = (Bitmap)rm.GetObject(playerfile);
                dealerWarPlayCard.Image = (Bitmap)rm.GetObject(dealerfile);
                playerWarPlayCard.Show();
                dealerWarPlayCard.Show();
                UpdateLabels();
                Wait(1500);

                CheckWinner();
            }

        }

        public void WarDraw()
        {

            DrawLabel.Show();
            dealerCards.AddToGroup(dealerWarPlayCardCode);
            playerCards.AddToGroup(playerWarPlayCardCode);
            UpdateLabels();
            ShowCards();

            for (int i = 0; i < 3; i++)
            {
                playerCards.AddToGroup(playerWarCards.DealTopCard());
                dealerCards.AddToGroup(dealerWarCards.DealTopCard());
            }

            dealerCards.AddToGroup(dealerPlayCard);
            playerCards.AddToGroup(playerPlayCard);
            atWar = false;
            CheckGameOver();
        }

        public void PlayerWinsWar()
        {
            PlayerWinsLabel.Show();
            ShowCards();
            playerCards.AddToGroup(playerWarPlayCardCode);
            playerCards.AddToGroup(playerPlayCard);
            playerCards.AddToGroup(dealerWarPlayCardCode);
            playerCards.AddToGroup(dealerPlayCard);
            UpdateLabels();


            for (int i = 0; i < 3; i++)
            {
                playerCards.AddToGroup(playerWarCards.DealTopCard());
                playerCards.AddToGroup(dealerWarCards.DealTopCard());
            }

            atWar = false;
            CheckGameOver();
        }

        public void DealerWinsWar()
        {
            dealerWinsLabel.Show();
            ShowCards();
            dealerCards.AddToGroup(playerWarPlayCardCode);
            dealerCards.AddToGroup(playerPlayCard);
            dealerCards.AddToGroup(dealerWarPlayCardCode);
            dealerCards.AddToGroup(dealerPlayCard);
            UpdateLabels();


            for (int i = 0; i < 3; i++)
            {
                dealerCards.AddToGroup(playerWarCards.DealTopCard());
                dealerCards.AddToGroup(dealerWarCards.DealTopCard());
            }

            atWar = false;
            CheckGameOver();
        }

        public void ShowCards()
        {
            playerWarCard3.Image = (Bitmap)(rm.GetObject(playerWarCards.GetCard(2).FileName()));
            dealerWarCard3.Image = (Bitmap)(rm.GetObject(dealerWarCards.GetCard(2).FileName()));
            Wait(1000);

            playerWarCard2.Image = (Bitmap)(rm.GetObject(playerWarCards.GetCard(1).FileName()));
            dealerWarCard2.Image = (Bitmap)(rm.GetObject(dealerWarCards.GetCard(1).FileName()));
            Wait(1000);

            playerWarCard1.Image = (Bitmap)(rm.GetObject(playerWarCards.GetCard(0).FileName()));
            dealerWarCard1.Image = (Bitmap)(rm.GetObject(dealerWarCards.GetCard(0).FileName()));
            Wait(3000);

            playerWarCard1.Hide();
            dealerWarCard1.Hide();
            playerWarCard2.Hide();
            dealerWarCard2.Hide();
            playerWarCard3.Hide();
            dealerWarCard3.Hide();
            dealerWarPlayCard.Hide();
            playerWarPlayCard.Hide();
            playerPlayCardBox.Hide();
            dealerPlayCardBox.Hide();
            PlayerWinsLabel.Hide();
            dealerWinsLabel.Hide();
        }




        public void CheckGameOver()
        {

            if (playerCards.NumCards <= 0 || dealerCards.NumCards <= 0)
            {
                auto = false;
                HideAll();
                gameOverLabel.Show();
                if (playerCards.NumCards <= 0)
                {
                    PlayerWinsLabel.Show();
                }
                else
                {
                    dealerWinsLabel.Show();
                }
                Wait(4000);
                PlayerWinsLabel.Hide();
                dealerWinsLabel.Hide();
                gameOverLabel.Hide();
                StartButton.Show();
            }
            else
            {
                HideAll();
                ShowOptions();
            }
        }

        public void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();

            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void autoPlayButton_Click(object sender, EventArgs e)
        {
            auto = true;
            HideAll();
            AutoPlay();
        }

        public void UpdateLabels()
        {
            dealerDeckLabel.Text = dealerCards.NumCards.ToString();
            playerDeckLabel.Text = playerCards.NumCards.ToString();
        }

        private void endButton_Click(object sender, EventArgs e)
        {

            if(!atWar)
            {
                auto = false;
                HideAll();
                playerDeckLabel.Text = (26).ToString();
                dealerDeckLabel.Text = (26).ToString();
                Wait(1500);
                endButton.Hide();
                StartButton.Show();
            }
            
        }

        public void HideAll()
        {
            PlayerWinsLabel.Hide();
            dealerWinsLabel.Hide();
            playerPlayCardBox.Hide();
            playerWarCard1.Hide();
            playerWarCard2.Hide();
            playerWarCard3.Hide();
            playerWarPlayCard.Hide();
            dealerPlayCardBox.Hide();
            dealerWarCard1.Hide();
            dealerWarCard2.Hide();
            dealerWarCard3.Hide();
            dealerWarPlayCard.Hide();
            roundButton.Hide();
            autoPlayButton.Hide();
            gameOverLabel.Hide();
            DrawLabel.Hide();
        }

        public void ShowOptions()
        {
            if (!auto)
            {
                roundButton.Show();
                autoPlayButton.Show();
            }
        }
    }
}
