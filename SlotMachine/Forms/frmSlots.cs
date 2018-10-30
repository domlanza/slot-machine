using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Forms
{
    public partial class frmSlots : Form
    {
        private int betCounter = 0;
        private int winnings = 0;
        private int score = GlobalData.player.getBalance();

        public frmSlots()
        {
            InitializeComponent();
        }


		private void btnSpin_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromSeconds(3))
            {
				Task.Delay(1000).Wait();
				GlobalData.internalfrm.spinReel();
                test1.Text = GlobalData.internalfrm.getSpinOne().ToString();
                test2.Text = GlobalData.internalfrm.getSpinTwo().ToString();
                test3.Text = GlobalData.internalfrm.getSpinThree().ToString();
                pbReel1.Image = slotImages.Images[GlobalData.internalfrm.getSpinOne()];
                pbReel1.Refresh();
                pbReel2.Image = slotImages.Images[GlobalData.internalfrm.getSpinTwo()];
                pbReel2.Refresh();
                pbReel3.Image = slotImages.Images[GlobalData.internalfrm.getSpinThree()];
                pbReel3.Refresh();
            }
            timer.Stop();

            winnings = GlobalData.internalfrm.getReelResult();
            score += GlobalData.internalfrm.getReelResult();
            if(winnings == 0)
            {
                score -=  GlobalData.internalfrm.GetCoins();
                txtBalance.Text = score.ToString();
            }
            else
            {
                txtBalance.Text = score.ToString();
            }
            txtWinnings.Text = winnings.ToString();
            txtBet.Text = "";
            betCounter = 0;
            btnPlaceBet.Enabled = true;
            btnMaxBet.Enabled = true;
            btnSpin.Enabled = false;

			GlobalData.internalfrm.ResetCoin();
		}

        private void btnAddCoin_Click(object sender, EventArgs e)
        {
            betCounter += 1;
            if(betCounter <= 3)
            {
                txtBet.Text = betCounter.ToString();
                GlobalData.internalfrm.AddCoin(1);
            }
            else if(betCounter > 3)
            {
                MessageBox.Show("You cannot bet more than three coins.", "Error");
                betCounter = 3;
                txtBet.Text = betCounter.ToString();

			}
            if(betCounter == 3)
            {
                btnPlaceBet.Enabled = false;
                btnMaxBet.Enabled = false;
            }
            if(betCounter != 0)
            {
                btnSpin.Enabled = true;
            }

        }

        private void btnMaxCoins_Click(object sender, EventArgs e)
        {
            GlobalData.internalfrm.AddCoin(3);
            betCounter = 3; 
            txtBet.Text = betCounter.ToString();
            btnPlaceBet.Enabled = false;
            btnMaxBet.Enabled = false;
            btnSpin.Enabled = true;
        }

        private void btnPayout_Click(object sender, EventArgs e)
        {
			//set player score at end of game
			GlobalData.player.setScore(score);

            Form frmGameEnd = new frmGameEnd();
            frmGameEnd.Show();
        }

		private void frmSlots_Load(object sender, EventArgs e)
		{
			txtBalance.Text = score.ToString();
		}
	}
}
