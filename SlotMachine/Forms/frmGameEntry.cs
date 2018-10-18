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
                    Player player = new Player(name);
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

        private void btnEnterGame_Click(object sender, EventArgs e)
        {
            Form frmSlots = new frmSlots();
            frmSlots.Show();
        }
    }
}
