namespace GoldenGrain
{
    partial class MainForm
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
            this.Exiete = new System.Windows.Forms.Button();
            this.YouAuthLabel = new System.Windows.Forms.Label();
            this.ProdMass = new System.Windows.Forms.TextBox();
            this.ProdTypeLab = new System.Windows.Forms.Label();
            this.ProductType = new System.Windows.Forms.ComboBox();
            this.ProductVolume = new System.Windows.Forms.Label();
            this.NewOrderBut = new System.Windows.Forms.Button();
            this.PCDate = new System.Windows.Forms.TextBox();
            this.PCTime = new System.Windows.Forms.TextBox();
            this.TimeLab = new System.Windows.Forms.Label();
            this.DataLab = new System.Windows.Forms.Label();
            this.EnterOrderLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exiete
            // 
            this.Exiete.Location = new System.Drawing.Point(639, 415);
            this.Exiete.Name = "Exiete";
            this.Exiete.Size = new System.Drawing.Size(149, 23);
            this.Exiete.TabIndex = 0;
            this.Exiete.Text = "Выйти из приложения";
            this.Exiete.UseVisualStyleBackColor = true;
            this.Exiete.Click += new System.EventHandler(this.Exiete_Click);
            // 
            // YouAuthLabel
            // 
            this.YouAuthLabel.AutoSize = true;
            this.YouAuthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YouAuthLabel.Location = new System.Drawing.Point(12, 9);
            this.YouAuthLabel.Name = "YouAuthLabel";
            this.YouAuthLabel.Size = new System.Drawing.Size(165, 15);
            this.YouAuthLabel.TabIndex = 1;
            this.YouAuthLabel.Text = "Вы авторизованны как:";
            // 
            // ProdMass
            // 
            this.ProdMass.Location = new System.Drawing.Point(66, 236);
            this.ProdMass.Name = "ProdMass";
            this.ProdMass.Size = new System.Drawing.Size(215, 20);
            this.ProdMass.TabIndex = 3;
            // 
            // ProdTypeLab
            // 
            this.ProdTypeLab.AutoSize = true;
            this.ProdTypeLab.Location = new System.Drawing.Point(63, 160);
            this.ProdTypeLab.Name = "ProdTypeLab";
            this.ProdTypeLab.Size = new System.Drawing.Size(75, 13);
            this.ProdTypeLab.TabIndex = 5;
            this.ProdTypeLab.Text = "Вид продукта";
            // 
            // ProductType
            // 
            this.ProductType.FormattingEnabled = true;
            this.ProductType.Location = new System.Drawing.Point(66, 176);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(215, 21);
            this.ProductType.TabIndex = 6;
            // 
            // ProductVolume
            // 
            this.ProductVolume.AutoSize = true;
            this.ProductVolume.Location = new System.Drawing.Point(63, 220);
            this.ProductVolume.Name = "ProductVolume";
            this.ProductVolume.Size = new System.Drawing.Size(137, 13);
            this.ProductVolume.TabIndex = 7;
            this.ProductVolume.Text = "Масса продукта (Тоннаж)";
            // 
            // NewOrderBut
            // 
            this.NewOrderBut.Location = new System.Drawing.Point(112, 287);
            this.NewOrderBut.Name = "NewOrderBut";
            this.NewOrderBut.Size = new System.Drawing.Size(116, 23);
            this.NewOrderBut.TabIndex = 8;
            this.NewOrderBut.Text = "Подать заявку";
            this.NewOrderBut.UseVisualStyleBackColor = true;
            this.NewOrderBut.Click += new System.EventHandler(this.NewOrderBut_Click);
            // 
            // PCDate
            // 
            this.PCDate.Location = new System.Drawing.Point(366, 236);
            this.PCDate.Name = "PCDate";
            this.PCDate.ReadOnly = true;
            this.PCDate.Size = new System.Drawing.Size(155, 20);
            this.PCDate.TabIndex = 9;
            // 
            // PCTime
            // 
            this.PCTime.Location = new System.Drawing.Point(366, 177);
            this.PCTime.Name = "PCTime";
            this.PCTime.ReadOnly = true;
            this.PCTime.Size = new System.Drawing.Size(155, 20);
            this.PCTime.TabIndex = 10;
            // 
            // TimeLab
            // 
            this.TimeLab.AutoSize = true;
            this.TimeLab.Location = new System.Drawing.Point(363, 160);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(40, 13);
            this.TimeLab.TabIndex = 11;
            this.TimeLab.Text = "Время";
            // 
            // DataLab
            // 
            this.DataLab.AutoSize = true;
            this.DataLab.Location = new System.Drawing.Point(363, 220);
            this.DataLab.Name = "DataLab";
            this.DataLab.Size = new System.Drawing.Size(33, 13);
            this.DataLab.TabIndex = 12;
            this.DataLab.Text = "Дата";
            // 
            // EnterOrderLab
            // 
            this.EnterOrderLab.AutoSize = true;
            this.EnterOrderLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterOrderLab.Location = new System.Drawing.Point(12, 415);
            this.EnterOrderLab.Name = "EnterOrderLab";
            this.EnterOrderLab.Size = new System.Drawing.Size(415, 13);
            this.EnterOrderLab.TabIndex = 13;
            this.EnterOrderLab.Text = "Заказ на вид товара * в объёме * тонн оформлен! Ожидайте ответа";
            this.EnterOrderLab.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterOrderLab);
            this.Controls.Add(this.DataLab);
            this.Controls.Add(this.TimeLab);
            this.Controls.Add(this.PCTime);
            this.Controls.Add(this.PCDate);
            this.Controls.Add(this.NewOrderBut);
            this.Controls.Add(this.ProductVolume);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.ProdTypeLab);
            this.Controls.Add(this.ProdMass);
            this.Controls.Add(this.YouAuthLabel);
            this.Controls.Add(this.Exiete);
            this.Name = "MainForm";
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exiete;
        private System.Windows.Forms.Label YouAuthLabel;
        private System.Windows.Forms.TextBox ProdMass;
        private System.Windows.Forms.Label ProdTypeLab;
        private System.Windows.Forms.ComboBox ProductType;
        private System.Windows.Forms.Label ProductVolume;
        private System.Windows.Forms.Button NewOrderBut;
        private System.Windows.Forms.TextBox PCDate;
        private System.Windows.Forms.TextBox PCTime;
        private System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.Label DataLab;
        private System.Windows.Forms.Label EnterOrderLab;
    }
}