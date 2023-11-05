namespace GoldenGrain
{
	partial class RegForm
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
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.insertPass = new System.Windows.Forms.TextBox();
            this.insertLogin = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.PassCheckLab = new System.Windows.Forms.Label();
            this.PassChecker = new System.Windows.Forms.TextBox();
            this.CoopBox = new System.Windows.Forms.TextBox();
            this.CoopLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(99, 101);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(45, 13);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(99, 48);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "Логин";
            // 
            // insertPass
            // 
            this.insertPass.Location = new System.Drawing.Point(102, 117);
            this.insertPass.Name = "insertPass";
            this.insertPass.Size = new System.Drawing.Size(206, 20);
            this.insertPass.TabIndex = 7;
            // 
            // insertLogin
            // 
            this.insertLogin.Location = new System.Drawing.Point(102, 64);
            this.insertLogin.Name = "insertLogin";
            this.insertLogin.Size = new System.Drawing.Size(206, 20);
            this.insertLogin.TabIndex = 6;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(205, 269);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(103, 23);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // PassCheckLab
            // 
            this.PassCheckLab.AutoSize = true;
            this.PassCheckLab.Location = new System.Drawing.Point(99, 150);
            this.PassCheckLab.Name = "PassCheckLab";
            this.PassCheckLab.Size = new System.Drawing.Size(127, 13);
            this.PassCheckLab.TabIndex = 10;
            this.PassCheckLab.Text = "Подтверждение пароля";
            // 
            // PassChecker
            // 
            this.PassChecker.Location = new System.Drawing.Point(102, 166);
            this.PassChecker.Name = "PassChecker";
            this.PassChecker.Size = new System.Drawing.Size(206, 20);
            this.PassChecker.TabIndex = 11;
            // 
            // CoopBox
            // 
            this.CoopBox.Location = new System.Drawing.Point(102, 222);
            this.CoopBox.Name = "CoopBox";
            this.CoopBox.Size = new System.Drawing.Size(206, 20);
            this.CoopBox.TabIndex = 12;
            // 
            // CoopLab
            // 
            this.CoopLab.AutoSize = true;
            this.CoopLab.Location = new System.Drawing.Point(99, 206);
            this.CoopLab.Name = "CoopLab";
            this.CoopLab.Size = new System.Drawing.Size(119, 13);
            this.CoopLab.TabIndex = 13;
            this.CoopLab.Text = "Организация (Кратко)";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 335);
            this.Controls.Add(this.CoopLab);
            this.Controls.Add(this.CoopBox);
            this.Controls.Add(this.PassChecker);
            this.Controls.Add(this.PassCheckLab);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.insertPass);
            this.Controls.Add(this.insertLogin);
            this.Controls.Add(this.RegButton);
            this.MaximizeBox = false;
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label PassLabel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.TextBox insertPass;
		private System.Windows.Forms.TextBox insertLogin;
		private System.Windows.Forms.Button RegButton;
		private System.Windows.Forms.Label PassCheckLab;
		private System.Windows.Forms.TextBox PassChecker;
        private System.Windows.Forms.TextBox CoopBox;
        private System.Windows.Forms.Label CoopLab;
    }
}