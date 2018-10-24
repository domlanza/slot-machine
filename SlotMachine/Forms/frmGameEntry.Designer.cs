namespace SlotMachine.Forms
{
    partial class frmGameEntry
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnterGame = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblEnterMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(238, 71);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(433, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Fantastic Slot Machine!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(177, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(272, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Please enter your name to begin:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(465, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 26);
            this.txtName.TabIndex = 2;
            // 
            // btnEnterGame
            // 
            this.btnEnterGame.Enabled = false;
            this.btnEnterGame.Location = new System.Drawing.Point(382, 406);
            this.btnEnterGame.Name = "btnEnterGame";
            this.btnEnterGame.Size = new System.Drawing.Size(182, 63);
            this.btnEnterGame.TabIndex = 4;
            this.btnEnterGame.Text = "Play";
            this.btnEnterGame.UseVisualStyleBackColor = true;
            this.btnEnterGame.Click += new System.EventHandler(this.btnEnterGame_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(178, 297);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(238, 20);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Instructions and tips will go here!";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(465, 227);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(99, 37);
            this.btnReady.TabIndex = 8;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(465, 186);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(140, 26);
            this.txtMoney.TabIndex = 7;
            // 
            // lblEnterMoney
            // 
            this.lblEnterMoney.AutoSize = true;
            this.lblEnterMoney.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterMoney.Location = new System.Drawing.Point(177, 186);
            this.lblEnterMoney.Name = "lblEnterMoney";
            this.lblEnterMoney.Size = new System.Drawing.Size(276, 25);
            this.lblEnterMoney.TabIndex = 6;
            this.lblEnterMoney.Text = "Please enter your starting money:";
            // 
            // frmGameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 608);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblEnterMoney);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnEnterGame);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Slots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEnterGame;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblEnterMoney;
    }
}