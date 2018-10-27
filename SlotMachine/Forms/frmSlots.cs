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
        public frmSlots()
        {
            InitializeComponent();
        }

		private void btnSpin_Click(object sender, EventArgs e)
		{
			GlobalData.internalfrm.spinReel();
		}

		private void btnAddCoin_Click(object sender, EventArgs e)
		{
			GlobalData.internalfrm.AddCoin(1);
		}

		private void btnMaxCoins_Click(object sender, EventArgs e)
		{
			GlobalData.internalfrm.AddCoin(3);
		}
	}
}
