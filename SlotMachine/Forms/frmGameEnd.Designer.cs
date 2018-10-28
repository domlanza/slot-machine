namespace SlotMachine.Forms
{
    partial class frmGameEnd
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
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnViewScores = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblEndingMessage = new System.Windows.Forms.Label();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(43, 163);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(113, 44);
            this.btnPlayAgain.TabIndex = 0;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            // 
            // btnViewScores
            // 
            this.btnViewScores.Location = new System.Drawing.Point(199, 163);
            this.btnViewScores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(113, 44);
            this.btnViewScores.TabIndex = 1;
            this.btnViewScores.Text = "View Scoreboard";
            this.btnViewScores.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(139, 233);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 28);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Exit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblEndingMessage
            // 
            this.lblEndingMessage.AutoSize = true;
            this.lblEndingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndingMessage.Location = new System.Drawing.Point(80, 47);
            this.lblEndingMessage.Name = "lblEndingMessage";
            this.lblEndingMessage.Size = new System.Drawing.Size(211, 20);
            this.lblEndingMessage.TabIndex = 3;
            this.lblEndingMessage.Text = "Congratulations, you won";
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Malgun Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.Location = new System.Drawing.Point(132, 81);
            this.lblWinnings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(86, 41);
            this.lblWinnings.TabIndex = 4;
            this.lblWinnings.Text = "$650";
            this.lblWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGameEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 281);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.lblEndingMessage);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnViewScores);
            this.Controls.Add(this.btnPlayAgain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnViewScores;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblEndingMessage;
        private System.Windows.Forms.Label lblWinnings;
    }
}