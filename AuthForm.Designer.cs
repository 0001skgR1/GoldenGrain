namespace GoldenGrain
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthButton = new System.Windows.Forms.Button();
            this.insertLogin = new System.Windows.Forms.TextBox();
            this.insertPass = new System.Windows.Forms.TextBox();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(201, 258);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(103, 23);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Авторизоваться";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // insertLogin
            // 
            this.insertLogin.Location = new System.Drawing.Point(98, 147);
            this.insertLogin.Name = "insertLogin";
            this.insertLogin.Size = new System.Drawing.Size(206, 20);
            this.insertLogin.TabIndex = 1;
            // 
            // insertPass
            // 
            this.insertPass.Location = new System.Drawing.Point(98, 200);
            this.insertPass.Name = "insertPass";
            this.insertPass.Size = new System.Drawing.Size(206, 20);
            this.insertPass.TabIndex = 2;
            // 
            // AuthLabel
            // 
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.Location = new System.Drawing.Point(95, 131);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthLabel.TabIndex = 3;
            this.AuthLabel.Text = "Логин";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(95, 184);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(45, 13);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Пароль";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 335);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.AuthLabel);
            this.Controls.Add(this.insertPass);
            this.Controls.Add(this.insertLogin);
            this.Controls.Add(this.AuthButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox insertLogin;
        private System.Windows.Forms.TextBox insertPass;
        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Label PassLabel;
    }
}

