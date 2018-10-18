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
            this.lblGameControls = new System.Windows.Forms.Panel();
            this.btnMaxCoins = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnAddCoin = new System.Windows.Forms.Button();
            this.pbReel1 = new System.Windows.Forms.PictureBox();
            this.pbReel2 = new System.Windows.Forms.PictureBox();
            this.pbReel3 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtWinnings = new System.Windows.Forms.TextBox();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.lblCoinsToPlay = new System.Windows.Forms.Label();
            this.txtCoinsToPlay = new System.Windows.Forms.TextBox();
            this.btnPayout = new System.Windows.Forms.Button();
            this.lblGameControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameControls
            // 
            this.lblGameControls.Controls.Add(this.btnMaxCoins);
            this.lblGameControls.Controls.Add(this.btnSpin);
            this.lblGameControls.Controls.Add(this.btnAddCoin);
            this.lblGameControls.Location = new System.Drawing.Point(261, 389);
            this.lblGameControls.Margin = new System.Windows.Forms.Padding(2);
            this.lblGameControls.Name = "lblGameControls";
            this.lblGameControls.Size = new System.Drawing.Size(440, 68);
            this.lblGameControls.TabIndex = 0;
            // 
            // btnMaxCoins
            // 
            this.btnMaxCoins.Location = new System.Drawing.Point(146, 16);
            this.btnMaxCoins.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxCoins.Name = "btnMaxCoins";
            this.btnMaxCoins.Size = new System.Drawing.Size(113, 38);
            this.btnMaxCoins.TabIndex = 2;
            this.btnMaxCoins.Text = "Add Max Coins";
            this.btnMaxCoins.UseVisualStyleBackColor = true;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(279, 16);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(152, 38);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            // 
            // btnAddCoin
            // 
            this.btnAddCoin.Location = new System.Drawing.Point(11, 16);
            this.btnAddCoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCoin.Name = "btnAddCoin";
            this.btnAddCoin.Size = new System.Drawing.Size(113, 38);
            this.btnAddCoin.TabIndex = 0;
            this.btnAddCoin.Text = "Add Coin";
            this.btnAddCoin.UseVisualStyleBackColor = true;
            // 
            // pbReel1
            // 
            this.pbReel1.Location = new System.Drawing.Point(147, 40);
            this.pbReel1.Margin = new System.Windows.Forms.Padding(2);
            this.pbReel1.Name = "pbReel1";
            this.pbReel1.Size = new System.Drawing.Size(206, 241);
            this.pbReel1.TabIndex = 1;
            this.pbReel1.TabStop = false;
            // 
            // pbReel2
            // 
            this.pbReel2.Location = new System.Drawing.Point(378, 40);
            this.pbReel2.Margin = new System.Windows.Forms.Padding(2);
            this.pbReel2.Name = "pbReel2";
            this.pbReel2.Size = new System.Drawing.Size(206, 241);
            this.pbReel2.TabIndex = 2;
            this.pbReel2.TabStop = false;
            // 
            // pbReel3
            // 
            this.pbReel3.Location = new System.Drawing.Point(607, 40);
            this.pbReel3.Margin = new System.Windows.Forms.Padding(2);
            this.pbReel3.Name = "pbReel3";
            this.pbReel3.Size = new System.Drawing.Size(206, 241);
            this.pbReel3.TabIndex = 3;
            this.pbReel3.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(388, 301);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(206, 62);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "246";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(306, 322);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "SCORE";
            // 
            // txtWinnings
            // 
            this.txtWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinnings.Location = new System.Drawing.Point(189, 301);
            this.txtWinnings.Margin = new System.Windows.Forms.Padding(2);
            this.txtWinnings.Name = "txtWinnings";
            this.txtWinnings.Size = new System.Drawing.Size(79, 62);
            this.txtWinnings.TabIndex = 6;
            this.txtWinnings.Text = "15";
            this.txtWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.Location = new System.Drawing.Point(75, 322);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(99, 20);
            this.lblWinnings.TabIndex = 7;
            this.lblWinnings.Text = "WINNINGS";
            // 
            // lblCoinsToPlay
            // 
            this.lblCoinsToPlay.AutoSize = true;
            this.lblCoinsToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinsToPlay.Location = new System.Drawing.Point(629, 322);
            this.lblCoinsToPlay.Name = "lblCoinsToPlay";
            this.lblCoinsToPlay.Size = new System.Drawing.Size(142, 20);
            this.lblCoinsToPlay.TabIndex = 9;
            this.lblCoinsToPlay.Text = "COINS TO PLAY";
            // 
            // txtCoinsToPlay
            // 
            this.txtCoinsToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoinsToPlay.Location = new System.Drawing.Point(776, 301);
            this.txtCoinsToPlay.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoinsToPlay.Name = "txtCoinsToPlay";
            this.txtCoinsToPlay.Size = new System.Drawing.Size(79, 62);
            this.txtCoinsToPlay.TabIndex = 8;
            this.txtCoinsToPlay.Text = "3";
            this.txtCoinsToPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayout
            // 
            this.btnPayout.Location = new System.Drawing.Point(832, 481);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(89, 31);
            this.btnPayout.TabIndex = 10;
            this.btnPayout.Text = "Pay out";
            this.btnPayout.UseVisualStyleBackColor = true;
            // 
            // frmSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 537);
            this.Controls.Add(this.btnPayout);
            this.Controls.Add(this.lblCoinsToPlay);
            this.Controls.Add(this.txtCoinsToPlay);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.txtWinnings);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pbReel3);
            this.Controls.Add(this.pbReel2);
            this.Controls.Add(this.pbReel1);
            this.Controls.Add(this.lblGameControls);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSlots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.lblGameControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblGameControls;
        private System.Windows.Forms.Button btnMaxCoins;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnAddCoin;
        private System.Windows.Forms.PictureBox pbReel1;
        private System.Windows.Forms.PictureBox pbReel2;
        private System.Windows.Forms.PictureBox pbReel3;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtWinnings;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Label lblCoinsToPlay;
        private System.Windows.Forms.TextBox txtCoinsToPlay;
        private System.Windows.Forms.Button btnPayout;
    }
}