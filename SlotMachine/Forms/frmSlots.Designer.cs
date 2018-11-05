namespace SlotMachine.Forms
{
    partial class frmSlots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlots));
			this.lblGameControls = new System.Windows.Forms.Panel();
			this.btnMaxBet = new System.Windows.Forms.Button();
			this.btnSpin = new System.Windows.Forms.Button();
			this.btnPlaceBet = new System.Windows.Forms.Button();
			this.pbReel1 = new System.Windows.Forms.PictureBox();
			this.pbReel2 = new System.Windows.Forms.PictureBox();
			this.pbReel3 = new System.Windows.Forms.PictureBox();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.lblBalance = new System.Windows.Forms.Label();
			this.txtWinnings = new System.Windows.Forms.TextBox();
			this.lblWinnings = new System.Windows.Forms.Label();
			this.lblBet = new System.Windows.Forms.Label();
			this.txtBet = new System.Windows.Forms.TextBox();
			this.btnPayout = new System.Windows.Forms.Button();
			this.slotImages = new System.Windows.Forms.ImageList(this.components);
			this.btnScores = new System.Windows.Forms.Button();
			this.lblGameControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbReel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbReel3)).BeginInit();
			this.SuspendLayout();
			// 
			// lblGameControls
			// 
			this.lblGameControls.BackColor = System.Drawing.Color.Transparent;
			this.lblGameControls.Controls.Add(this.btnMaxBet);
			this.lblGameControls.Controls.Add(this.btnSpin);
			this.lblGameControls.Controls.Add(this.btnPlaceBet);
			this.lblGameControls.Location = new System.Drawing.Point(348, 546);
			this.lblGameControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblGameControls.Name = "lblGameControls";
			this.lblGameControls.Size = new System.Drawing.Size(587, 84);
			this.lblGameControls.TabIndex = 0;
			// 
			// btnMaxBet
			// 
			this.btnMaxBet.Location = new System.Drawing.Point(195, 20);
			this.btnMaxBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMaxBet.Name = "btnMaxBet";
			this.btnMaxBet.Size = new System.Drawing.Size(151, 46);
			this.btnMaxBet.TabIndex = 2;
			this.btnMaxBet.Text = "Place Max Bet";
			this.btnMaxBet.UseVisualStyleBackColor = true;
			this.btnMaxBet.Click += new System.EventHandler(this.btnMaxCoins_Click);
			// 
			// btnSpin
			// 
			this.btnSpin.Enabled = false;
			this.btnSpin.Location = new System.Drawing.Point(372, 20);
			this.btnSpin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSpin.Name = "btnSpin";
			this.btnSpin.Size = new System.Drawing.Size(203, 46);
			this.btnSpin.TabIndex = 1;
			this.btnSpin.Text = "Spin";
			this.btnSpin.UseVisualStyleBackColor = true;
			this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
			// 
			// btnPlaceBet
			// 
			this.btnPlaceBet.Location = new System.Drawing.Point(14, 20);
			this.btnPlaceBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPlaceBet.Name = "btnPlaceBet";
			this.btnPlaceBet.Size = new System.Drawing.Size(151, 46);
			this.btnPlaceBet.TabIndex = 0;
			this.btnPlaceBet.Text = "Place Bet";
			this.btnPlaceBet.UseVisualStyleBackColor = true;
			this.btnPlaceBet.Click += new System.EventHandler(this.btnAddCoin_Click);
			// 
			// pbReel1
			// 
			this.pbReel1.BackColor = System.Drawing.Color.Transparent;
			this.pbReel1.Location = new System.Drawing.Point(125, 85);
			this.pbReel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbReel1.Name = "pbReel1";
			this.pbReel1.Size = new System.Drawing.Size(275, 297);
			this.pbReel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbReel1.TabIndex = 1;
			this.pbReel1.TabStop = false;
			// 
			// pbReel2
			// 
			this.pbReel2.BackColor = System.Drawing.Color.Transparent;
			this.pbReel2.Location = new System.Drawing.Point(507, 85);
			this.pbReel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbReel2.Name = "pbReel2";
			this.pbReel2.Size = new System.Drawing.Size(275, 297);
			this.pbReel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbReel2.TabIndex = 2;
			this.pbReel2.TabStop = false;
			// 
			// pbReel3
			// 
			this.pbReel3.BackColor = System.Drawing.Color.Transparent;
			this.pbReel3.Location = new System.Drawing.Point(885, 85);
			this.pbReel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbReel3.Name = "pbReel3";
			this.pbReel3.Size = new System.Drawing.Size(275, 297);
			this.pbReel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbReel3.TabIndex = 3;
			this.pbReel3.TabStop = false;
			// 
			// txtBalance
			// 
			this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtBalance.Location = new System.Drawing.Point(606, 454);
			this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.ReadOnly = true;
			this.txtBalance.Size = new System.Drawing.Size(273, 75);
			this.txtBalance.TabIndex = 4;
			this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalance.ForeColor = System.Drawing.Color.White;
			this.lblBalance.Location = new System.Drawing.Point(475, 482);
			this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(113, 25);
			this.lblBalance.TabIndex = 5;
			this.lblBalance.Text = "BALANCE";
			// 
			// txtWinnings
			// 
			this.txtWinnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.txtWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWinnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtWinnings.Location = new System.Drawing.Point(253, 454);
			this.txtWinnings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtWinnings.Name = "txtWinnings";
			this.txtWinnings.ReadOnly = true;
			this.txtWinnings.Size = new System.Drawing.Size(157, 75);
			this.txtWinnings.TabIndex = 6;
			this.txtWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblWinnings
			// 
			this.lblWinnings.AutoSize = true;
			this.lblWinnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinnings.ForeColor = System.Drawing.Color.White;
			this.lblWinnings.Location = new System.Drawing.Point(101, 482);
			this.lblWinnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWinnings.Name = "lblWinnings";
			this.lblWinnings.Size = new System.Drawing.Size(121, 25);
			this.lblWinnings.TabIndex = 7;
			this.lblWinnings.Text = "WINNINGS";
			// 
			// lblBet
			// 
			this.lblBet.AutoSize = true;
			this.lblBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBet.ForeColor = System.Drawing.Color.White;
			this.lblBet.Location = new System.Drawing.Point(965, 482);
			this.lblBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBet.Name = "lblBet";
			this.lblBet.Size = new System.Drawing.Size(54, 25);
			this.lblBet.TabIndex = 9;
			this.lblBet.Text = "BET";
			// 
			// txtBet
			// 
			this.txtBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtBet.Location = new System.Drawing.Point(1036, 454);
			this.txtBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBet.Name = "txtBet";
			this.txtBet.ReadOnly = true;
			this.txtBet.Size = new System.Drawing.Size(104, 75);
			this.txtBet.TabIndex = 8;
			this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnPayout
			// 
			this.btnPayout.Location = new System.Drawing.Point(1096, 574);
			this.btnPayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPayout.Name = "btnPayout";
			this.btnPayout.Size = new System.Drawing.Size(119, 38);
			this.btnPayout.TabIndex = 10;
			this.btnPayout.Text = "Pay out";
			this.btnPayout.UseVisualStyleBackColor = true;
			this.btnPayout.Click += new System.EventHandler(this.btnPayout_Click);
			// 
			// slotImages
			// 
			this.slotImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("slotImages.ImageStream")));
			this.slotImages.TransparentColor = System.Drawing.Color.Transparent;
			this.slotImages.Images.SetKeyName(0, "red-t.png");
			this.slotImages.Images.SetKeyName(1, "blue-t.png");
			this.slotImages.Images.SetKeyName(2, "green-t.png");
			this.slotImages.Images.SetKeyName(3, "drawn-owl.png");
			this.slotImages.Images.SetKeyName(4, "stella-owl.png");
			// 
			// btnScores
			// 
			this.btnScores.Location = new System.Drawing.Point(25, 574);
			this.btnScores.Name = "btnScores";
			this.btnScores.Size = new System.Drawing.Size(177, 38);
			this.btnScores.TabIndex = 11;
			this.btnScores.Text = "Winning Combinations";
			this.btnScores.UseVisualStyleBackColor = true;
			this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
			// 
			// frmSlots
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SlotMachine.Properties.Resources.formbg;
			this.ClientSize = new System.Drawing.Size(1266, 661);
			this.Controls.Add(this.btnScores);
			this.Controls.Add(this.btnPayout);
			this.Controls.Add(this.lblBet);
			this.Controls.Add(this.txtBet);
			this.Controls.Add(this.lblWinnings);
			this.Controls.Add(this.txtWinnings);
			this.Controls.Add(this.lblBalance);
			this.Controls.Add(this.txtBalance);
			this.Controls.Add(this.pbReel3);
			this.Controls.Add(this.pbReel2);
			this.Controls.Add(this.pbReel1);
			this.Controls.Add(this.lblGameControls);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSlots";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Get Money, Big Money Slots ";
			this.Load += new System.EventHandler(this.frmSlots_Load);
			this.lblGameControls.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbReel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbReel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbReel3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblGameControls;
        private System.Windows.Forms.Button btnMaxBet;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.PictureBox pbReel1;
        private System.Windows.Forms.PictureBox pbReel2;
        private System.Windows.Forms.PictureBox pbReel3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtWinnings;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.ImageList slotImages;
		private System.Windows.Forms.Button btnScores;
	}
}