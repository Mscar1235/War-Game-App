using System;
using System.Diagnostics;
using System.Drawing; // Assuming you are using System.Drawing for images
using System.Resources;
namespace App
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CardGroup deck = new CardGroup();
            deck.MakeWholeDeck();
            NewDeckText.Text = deck.ToString();
            deck.Shuffle();
            ShuffledDeckText.Text = deck.ToString();
            Card topCard = deck.DealTopCard();
            deck.AddToGroup(topCard);
            DealAddText.Text = deck.ToString();
            Card tenthCard = deck.GetCard(9);
            Card penCard = deck.GetCard(50);
            ResourceManager rm = new ResourceManager(typeof(Resource1));
            string tenthfile = tenthCard.FileName();
            string penfile = penCard.FileName();
            TenthCardPicBox.Image = (Bitmap)rm.GetObject(tenthfile);
            PenultCardPicBox.Image = (Bitmap)rm.GetObject(penfile);
        }

        private void StartWar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}
