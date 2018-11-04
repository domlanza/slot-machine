/* Temple University / CIS 3309 / Slot Machine
 * Form: frmGameEntry 
 * Authors: Zachary Goncalves & Michael Rodriguez
 */
using System;
using System.ComponentModel;
using System.Media;
using System.Windows.Forms;

namespace SlotMachine.Forms
{
    public partial class frmGameEntry : Form
    {
		SoundPlayer bgMusic = new System.Media.SoundPlayer(Properties.Resources.theme);
		BackgroundWorker worker = new BackgroundWorker();
        private string playerName;
        private int startingBalance = 0;

        public frmGameEntry()
        {
            InitializeComponent();
        }
        // Validates user inputted data and enables play button.
        // Author: Zachary Goncalves
        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                playerName = txtName.Text;
                if (string.IsNullOrEmpty(playerName))
                {
                    MessageBox.Show("Please enter a valid name.", "Error");
                    txtName.Text = "";
                    txtName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid name.", "Error");
                txtName.Text = "";
                txtName.Focus();
            }

            try
            {
                startingBalance = Convert.ToInt32(txtMoney.Text);
                btnEnterGame.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount of money", "Error");
                txtMoney.Text = "";
                txtMoney.Focus();
            }

            btnEnterGame.Enabled = true;
        }

        // Instantiates and opens game form. Updates player object with user inputted balance and name.
        // Author: Zachary Goncalves
        private void btnEnterGame_Click(object sender, EventArgs e)
        {
			GlobalData.player.setPlayer(txtName.Text, Int32.Parse(txtMoney.Text));
            Form frmSlots = new Forms.frmSlots();
            frmSlots.Show();
        }
	}   
}
