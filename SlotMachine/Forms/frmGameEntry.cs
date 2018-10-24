using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlotMachine.Classes; 

namespace SlotMachine.Forms
{
    public partial class frmGameEntry : Form
    {
        private string playerName;
        private int startingBalance = 0;

        public frmGameEntry()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a valid name.", "Error");
                    txtName.Text = "";
                    txtName.Focus();
                }
                else
                {
                    btnEnterGame.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid name.", "Error");
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void btnEnterMoney_Click(object sender, EventArgs e)
        {
            try
            {
                startingBalance = Convert.ToInt32(txtMoney.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount of money", "Error");
                txtMoney.Text = "";
                txtMoney.Focus();
            }
        }

        private void btnEnterGame_Click(object sender, EventArgs e)
        {
            Player player = new Player(playerName, startingBalance);
            Form frmSlots = new frmSlots();
            frmSlots.Show();
        }

    }
}
