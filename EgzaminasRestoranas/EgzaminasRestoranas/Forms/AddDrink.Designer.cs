namespace EgzaminasRestoranas.Forms
{
    partial class AddDrink
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
            this.addDrinkToMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.drinkPriceLabel = new System.Windows.Forms.Label();
            this.drinkNameLabel = new System.Windows.Forms.Label();
            this.drinkPrice = new System.Windows.Forms.TextBox();
            this.drinkName = new System.Windows.Forms.TextBox();
            this.workerRole = new System.Windows.Forms.Label();
            this.workerName = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDrinkToMenu
            // 
            this.addDrinkToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDrinkToMenu.Location = new System.Drawing.Point(354, 270);
            this.addDrinkToMenu.Name = "addDrinkToMenu";
            this.addDrinkToMenu.Size = new System.Drawing.Size(137, 43);
            this.addDrinkToMenu.TabIndex = 38;
            this.addDrinkToMenu.Text = "Pridėti gėrimą";
            this.addDrinkToMenu.UseVisualStyleBackColor = true;
            this.addDrinkToMenu.Click += new System.EventHandler(this.addDrinkToMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Įveskite duomenys";
            // 
            // drinkPriceLabel
            // 
            this.drinkPriceLabel.AutoSize = true;
            this.drinkPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkPriceLabel.Location = new System.Drawing.Point(120, 209);
            this.drinkPriceLabel.Name = "drinkPriceLabel";
            this.drinkPriceLabel.Size = new System.Drawing.Size(90, 20);
            this.drinkPriceLabel.TabIndex = 36;
            this.drinkPriceLabel.Text = "Kaina (eur.)";
            // 
            // drinkNameLabel
            // 
            this.drinkNameLabel.AutoSize = true;
            this.drinkNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkNameLabel.Location = new System.Drawing.Point(120, 154);
            this.drinkNameLabel.Name = "drinkNameLabel";
            this.drinkNameLabel.Size = new System.Drawing.Size(98, 20);
            this.drinkNameLabel.TabIndex = 35;
            this.drinkNameLabel.Text = "Pavadinimas";
            // 
            // drinkPrice
            // 
            this.drinkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkPrice.Location = new System.Drawing.Point(218, 203);
            this.drinkPrice.Name = "drinkPrice";
            this.drinkPrice.Size = new System.Drawing.Size(273, 26);
            this.drinkPrice.TabIndex = 34;
            // 
            // drinkName
            // 
            this.drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkName.Location = new System.Drawing.Point(218, 151);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(273, 26);
            this.drinkName.TabIndex = 33;
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(422, 66);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 32;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(422, 30);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 31;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 30;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 377);
            this.Controls.Add(this.addDrinkToMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drinkPriceLabel);
            this.Controls.Add(this.drinkNameLabel);
            this.Controls.Add(this.drinkPrice);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.Back);
            this.Name = "AddDrink";
            this.Text = "AddDrink";
            this.Load += new System.EventHandler(this.AddDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDrinkToMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label drinkPriceLabel;
        private System.Windows.Forms.Label drinkNameLabel;
        private System.Windows.Forms.TextBox drinkPrice;
        private System.Windows.Forms.TextBox drinkName;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button Back;
    }
}