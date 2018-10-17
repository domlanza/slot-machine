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
			this.SuspendLayout();
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(83, 61);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(357, 22);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "Welcome to the Fantastic Slot Machine!";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(83, 141);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(226, 20);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Please enter your name to begin:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(340, 141);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 2;
			// 
			// btnEnterName
			// 
			this.btnEnterName.Location = new System.Drawing.Point(352, 196);
			this.btnEnterName.Name = "btnEnterName";
			this.btnEnterName.Size = new System.Drawing.Size(75, 23);
			this.btnEnterName.TabIndex = 3;
			this.btnEnterName.Text = "Enter";
			this.btnEnterName.UseVisualStyleBackColor = true;
			// 
			// frmGameEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 332);
			this.Controls.Add(this.btnEnterName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblWelcome);
			this.Name = "frmGameEntry";
			this.Text = "frmGameEntry";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnEnterName;
	}
}