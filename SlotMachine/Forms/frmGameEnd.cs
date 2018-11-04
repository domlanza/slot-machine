/* Temple University / CIS 3309 / Slot Machine
 * Form: frmGameEnd 
 * Author: Zachary Goncalves & Michael Rodriguez
 */
using System;
using System.Windows.Forms;

namespace SlotMachine.Forms
{
    public partial class frmGameEnd : Form
    {
        public frmGameEnd()
        {
            InitializeComponent();
        }
        // Exits the application.
        // Author: Zachary Goncalves
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Displays player winnings and calls updateScoreboard method.
        // Authors: Michael Rodriguez & Zachary Goncalves 
		private void frmGameEnd_Load(object sender, EventArgs e)
		{
			lblWinnings.Text="$"+GlobalData.player.getScore().ToString();
            GlobalData.scoreboard.updateScoreboard(GlobalData.player.preparePlayerScore());
        }

        // Resets player object attributes, loads new game entry form, and closes game end form. 
        // Author: Zachary Goncalves
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            GlobalData.player.resetPlayer();
            Form newGameEntry = new frmGameEntry();
            newGameEntry.Show();
            this.Close();
        }

        // Displays scoreboard with top scores.
        // Author: Zachary Goncalves
        private void btnViewScores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalData.scoreboard.displayScoreboard(),"Top Scores");
        }
    }
}
