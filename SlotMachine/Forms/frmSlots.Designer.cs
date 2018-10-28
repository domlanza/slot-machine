﻿namespace SlotMachine.Forms
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
            this.test1 = new System.Windows.Forms.Label();
            this.test2 = new System.Windows.Forms.Label();
            this.test3 = new System.Windows.Forms.Label();
            this.lblGameControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReel3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameControls
            // 
            this.lblGameControls.Controls.Add(this.btnMaxBet);
            this.lblGameControls.Controls.Add(this.btnSpin);
            this.lblGameControls.Controls.Add(this.btnPlaceBet);
            this.lblGameControls.Location = new System.Drawing.Point(261, 389);
            this.lblGameControls.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lblGameControls.Name = "lblGameControls";
            this.lblGameControls.Size = new System.Drawing.Size(440, 68);
            this.lblGameControls.TabIndex = 0;
            // 
            // btnMaxBet
            // 
            this.btnMaxBet.Location = new System.Drawing.Point(146, 16);
            this.btnMaxBet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMaxBet.Name = "btnMaxBet";
            this.btnMaxBet.Size = new System.Drawing.Size(113, 38);
            this.btnMaxBet.TabIndex = 2;
            this.btnMaxBet.Text = "Place Max Bet";
            this.btnMaxBet.UseVisualStyleBackColor = true;
            this.btnMaxBet.Click += new System.EventHandler(this.btnMaxCoins_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Enabled = false;
            this.btnSpin.Location = new System.Drawing.Point(279, 16);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(152, 38);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Location = new System.Drawing.Point(11, 16);
            this.btnPlaceBet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(113, 38);
            this.btnPlaceBet.TabIndex = 0;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnAddCoin_Click);
            // 
            // pbReel1
            // 
            this.pbReel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReel1.Location = new System.Drawing.Point(147, 40);
            this.pbReel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbReel1.Name = "pbReel1";
            this.pbReel1.Size = new System.Drawing.Size(206, 241);
            this.pbReel1.TabIndex = 1;
            this.pbReel1.TabStop = false;
            // 
            // pbReel2
            // 
            this.pbReel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReel2.Location = new System.Drawing.Point(378, 40);
            this.pbReel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbReel2.Name = "pbReel2";
            this.pbReel2.Size = new System.Drawing.Size(206, 241);
            this.pbReel2.TabIndex = 2;
            this.pbReel2.TabStop = false;
            // 
            // pbReel3
            // 
            this.pbReel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReel3.Location = new System.Drawing.Point(607, 40);
            this.pbReel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbReel3.Name = "pbReel3";
            this.pbReel3.Size = new System.Drawing.Size(206, 241);
            this.pbReel3.TabIndex = 3;
            this.pbReel3.TabStop = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(454, 300);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(206, 62);
            this.txtBalance.TabIndex = 4;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(355, 322);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 20);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "BALANCE";
            // 
            // txtWinnings
            // 
            this.txtWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinnings.Location = new System.Drawing.Point(189, 300);
            this.txtWinnings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtWinnings.Name = "txtWinnings";
            this.txtWinnings.ReadOnly = true;
            this.txtWinnings.Size = new System.Drawing.Size(119, 62);
            this.txtWinnings.TabIndex = 6;
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
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(723, 322);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(43, 20);
            this.lblBet.TabIndex = 9;
            this.lblBet.Text = "BET";
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(776, 300);
            this.txtBet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBet.Name = "txtBet";
            this.txtBet.ReadOnly = true;
            this.txtBet.Size = new System.Drawing.Size(79, 62);
            this.txtBet.TabIndex = 8;
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayout
            // 
            this.btnPayout.Location = new System.Drawing.Point(832, 481);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(89, 31);
            this.btnPayout.TabIndex = 10;
            this.btnPayout.Text = "Pay out";
            this.btnPayout.UseVisualStyleBackColor = true;
            this.btnPayout.Click += new System.EventHandler(this.btnPayout_Click);
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(147, 8);
            this.test1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(38, 13);
            this.test1.TabIndex = 11;
            this.test1.Text = "Reel 1";
            // 
            // test2
            // 
            this.test2.AutoSize = true;
            this.test2.Location = new System.Drawing.Point(378, 8);
            this.test2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(38, 13);
            this.test2.TabIndex = 12;
            this.test2.Text = "Reel 2";
            // 
            // test3
            // 
            this.test3.AutoSize = true;
            this.test3.Location = new System.Drawing.Point(607, 8);
            this.test3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(38, 13);
            this.test3.TabIndex = 13;
            this.test3.Text = "Reel 3";
            // 
            // frmSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 537);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Label test1;
        private System.Windows.Forms.Label test2;
        private System.Windows.Forms.Label test3;
    }
}