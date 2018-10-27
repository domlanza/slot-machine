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
    public partial class frmSlots : Form
    {
        private int coinCounter = 0;
        public frmSlots()
        {
            InitializeComponent();
        }

		private void btnSpin_Click(object sender, EventArgs e)
		{
			GlobalData.internalfrm.spinReel();
            test1.Text = GlobalData.internalfrm.getSpinOne().ToString();
            test2.Text = GlobalData.internalfrm.getSpinTwo().ToString();
            test3.Text = GlobalData.internalfrm.getSpinThree().ToString();
		}

		private void btnAddCoin_Click(object sender, EventArgs e)
		{
            coinCounter += 1;
            if(coinCounter <= 3)
            {
                txtCoinsToPlay.Text = coinCounter.ToString();
                GlobalData.internalfrm.AddCoin(1);
            }
            else if(coinCounter > 3)
            {
                MessageBox.Show("You cannot bet more than three coins.", "Error");
                coinCounter = 3;
                txtCoinsToPlay.Text = coinCounter.ToString();
            }
            if(coinCounter == 3)
            {
                btnAddCoin.Enabled = false;
                btnMaxCoins.Enabled = false;
            }
            
        }

		private void btnMaxCoins_Click(object sender, EventArgs e)
		{
			GlobalData.internalfrm.AddCoin(3);
            coinCounter = 3; 
            txtCoinsToPlay.Text = coinCounter.ToString();
            btnAddCoin.Enabled = false;
            btnMaxCoins.Enabled = false;
		}
	}
}
