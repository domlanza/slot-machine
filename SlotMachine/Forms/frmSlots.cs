/* Temple University / CIS 3309 / Slot Machine
 * Form: frmSlots 
 * Author: Zachary Goncalves & Michael Rodriguez
 */
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SlotMachine.Forms
{
    public partial class frmSlots : Form
    {
        private int betCounter = 0;
        private int winnings = 0;
        private int score = GlobalData.player.getBalance();
		SoundPlayer win = new SoundPlayer(Properties.Resources.Jackpot);
		SoundPlayer jackpot = new SoundPlayer(Properties.Resources.theme);

        public frmSlots()
        {
            InitializeComponent();
        }

        // Calls cycle reels method, get returns, and plays audio depending on conditions.
        // Resets form after spin and checks if player has lost.
        // Authors: Zachary Goncalves & Michael Rodriguez
		private void btnSpin_Click(object sender, EventArgs e)
        {
			jackpot.Stop();
            cycleReels();
			winnings = GlobalData.internalfrm.getReelResult();
			if (winnings == 0)
			{
				score -= betCounter;
				txtBalance.Text = score.ToString();
			}
			else if (winnings == 600)
			{
				jackpot.Play();
				score += winnings;
				txtBalance.Text = score.ToString();
			}
			else
			{
				win.Play();
				score += winnings;
				txtBalance.Text = score.ToString();
			}

            txtWinnings.Text = winnings.ToString();
            txtBet.Text = "";
            betCounter = 0;
            btnPlaceBet.Enabled = true;
            btnMaxBet.Enabled = true;
            btnSpin.Enabled = false;

			//user lost all their money
			if (score <= 0)
			{
				MessageBox.Show("You lose!");
				//execute our btnPayout click event
				btnPayout_Click(sender, e);
			}
			GlobalData.internalfrm.ResetCoin();
		}

        // Cycles the reels over a defned time interval. Refreshses picture boxes on form using result of spin.
        // Authors: Zachary Goncalves
        public void cycleReels()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromSeconds(3.6))
            {
                GlobalData.internalfrm.spinReel();

				pbReel1.Image = slotImages.Images[GlobalData.internalfrm.getSpinOne()];
				pbReel1.Refresh();
                pbReel2.Image = slotImages.Images[GlobalData.internalfrm.getSpinTwo()];
                pbReel2.Refresh();
                pbReel3.Image = slotImages.Images[GlobalData.internalfrm.getSpinThree()];
                pbReel3.Refresh();
                Task.Delay(50).Wait();
			}
            timer.Stop();
        }

        // Increments betCounter and validates user has the money to bet. 
        // Author: Michael Rodriguez 
        private void btnAddCoin_Click(object sender, EventArgs e)
        {
			betCounter += 1;
			if (betCounter > score)
			{
				MessageBox.Show("You don't have enough to wager this amount!");
				betCounter -= 1;
			}
			else
			{
				if (betCounter <= 3)
				{
					txtBet.Text = betCounter.ToString();
					GlobalData.internalfrm.AddCoin(1);
				}
				else if (betCounter > 3)
				{
					MessageBox.Show("You cannot bet more than three coins.", "Error");
					betCounter = 3;
					txtBet.Text = betCounter.ToString();

				}
				if (betCounter == 3)
				{
					btnPlaceBet.Enabled = false;
					btnMaxBet.Enabled = false;
				}
				if (betCounter != 0)
				{
					btnSpin.Enabled = true;
				}
			}

        }

        // Adds maximum bet amount. 
        // Author: Michael Rodriguez
        private void btnMaxCoins_Click(object sender, EventArgs e)
        {
			betCounter = 3;
			if (betCounter > score)
			{
				MessageBox.Show("You don't have enough to wager this amount!");
				betCounter = 0;
			}
			else
			{
				GlobalData.internalfrm.AddCoin(3);
				txtBet.Text = betCounter.ToString();
				btnPlaceBet.Enabled = false;
				btnMaxBet.Enabled = false;
				btnSpin.Enabled = true;
			}
        }

        // Instantiates game ending form and updates player object with values from game.
        // Allows the user to quit or continue playing.
        // Author: Zachary Goncalves
        private void btnPayout_Click(object sender, EventArgs e)
        {
            GlobalData.player.setScore(score);
            Form frmGameEnd = new Forms.frmGameEnd();
            if (GlobalData.player.calculateScore() > 0)
            {
                this.Close();
                frmGameEnd.Show();
            }
            else
            {
                var result = MessageBox.Show("You haven't won anything! Keep playing to win. \n\nWould you like to quit?", "End Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        // Updates Score textbox with user-inputted balance on form load.
        // Author: Michael Rodriguez
 		private void frmSlots_Load(object sender, EventArgs e)
		{
			txtBalance.Text = score.ToString();
		}
	}
}
