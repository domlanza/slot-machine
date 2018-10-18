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
            this.btnEnterName = new System.Windows.Forms.Button();
            this.btnEnterGame = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(212, 57);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(357, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Fantastic Slot Machine!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(157, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Please enter your name to begin:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(414, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 22);
            this.txtName.TabIndex = 2;
            // 
            // btnEnterName
            // 
            this.btnEnterName.Location = new System.Drawing.Point(563, 110);
            this.btnEnterName.Name = "btnEnterName";
            this.btnEnterName.Size = new System.Drawing.Size(75, 23);
            this.btnEnterName.TabIndex = 3;
            this.btnEnterName.Text = "Enter";
            this.btnEnterName.UseVisualStyleBackColor = true;
            this.btnEnterName.Click += new System.EventHandler(this.btnEnterName_Click);
            // 
            // btnEnterGame
            // 
            this.btnEnterGame.Enabled = false;
            this.btnEnterGame.Location = new System.Drawing.Point(330, 318);
            this.btnEnterGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnterGame.Name = "btnEnterGame";
            this.btnEnterGame.Size = new System.Drawing.Size(161, 51);
            this.btnEnterGame.TabIndex = 4;
            this.btnEnterGame.Text = "Play";
            this.btnEnterGame.UseVisualStyleBackColor = true;
            this.btnEnterGame.Click += new System.EventHandler(this.btnEnterGame_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(162, 182);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(212, 17);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Instructions and tips will go here!";
            // 
            // frmGameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 486);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnEnterGame);
            this.Controls.Add(this.btnEnterName);
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
		private System.Windows.Forms.Button btnEnterName;
        private System.Windows.Forms.Button btnEnterGame;
        private System.Windows.Forms.Label lblInstructions;
    }
}