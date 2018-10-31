using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Forms
{
    public partial class frmGameEnd : Form
    {
        public frmGameEnd()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void frmGameEnd_Load(object sender, EventArgs e)
		{
			lblWinnings.Text="$"+GlobalData.player.getScore().ToString();
		}

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form frmSlots = new frmSlots();
            frmSlots.Show();
            this.Close();
        }

        private void btnViewScores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalData.scoreboard.displayScoreboard(),"Top Scores");
        }
    }
}
