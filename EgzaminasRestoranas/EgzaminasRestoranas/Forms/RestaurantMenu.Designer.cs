namespace EgzaminasRestoranas.Forms
{
    partial class RestaurantMenu
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
            this.Back = new System.Windows.Forms.Button();
            this.workerRole = new System.Windows.Forms.Label();
            this.workerName = new System.Windows.Forms.Label();
            this.addDrink = new System.Windows.Forms.Button();
            this.addFood = new System.Windows.Forms.Button();
            this.dishPanel = new System.Windows.Forms.Panel();
            this.dishTextBox = new System.Windows.Forms.RichTextBox();
            this.drinkPanel = new System.Windows.Forms.Panel();
            this.drinkTextBox = new System.Windows.Forms.RichTextBox();
            this.dishPanel.SuspendLayout();
            this.drinkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(25, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 18;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(616, 48);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 20;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(616, 12);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 19;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // addDrink
            // 
            this.addDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDrink.Location = new System.Drawing.Point(525, 458);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(149, 52);
            this.addDrink.TabIndex = 21;
            this.addDrink.Text = "Papildydi gerimo meniu";
            this.addDrink.UseVisualStyleBackColor = true;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // addFood
            // 
            this.addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFood.Location = new System.Drawing.Point(90, 458);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(157, 52);
            this.addFood.TabIndex = 22;
            this.addFood.Text = "Papildyti patiekalo meniu";
            this.addFood.UseVisualStyleBackColor = true;
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // dishPanel
            // 
            this.dishPanel.Controls.Add(this.dishTextBox);
            this.dishPanel.Location = new System.Drawing.Point(25, 81);
            this.dishPanel.Name = "dishPanel";
            this.dishPanel.Size = new System.Drawing.Size(321, 285);
            this.dishPanel.TabIndex = 39;
            // 
            // dishTextBox
            // 
            this.dishTextBox.Location = new System.Drawing.Point(0, 0);
            this.dishTextBox.Name = "dishTextBox";
            this.dishTextBox.ReadOnly = true;
            this.dishTextBox.Size = new System.Drawing.Size(318, 285);
            this.dishTextBox.TabIndex = 0;
            this.dishTextBox.Text = "";
            // 
            // drinkPanel
            // 
            this.drinkPanel.Controls.Add(this.drinkTextBox);
            this.drinkPanel.Location = new System.Drawing.Point(417, 81);
            this.drinkPanel.Name = "drinkPanel";
            this.drinkPanel.Size = new System.Drawing.Size(321, 285);
            this.drinkPanel.TabIndex = 40;
            // 
            // drinkTextBox
            // 
            this.drinkTextBox.Location = new System.Drawing.Point(0, 0);
            this.drinkTextBox.Name = "drinkTextBox";
            this.drinkTextBox.ReadOnly = true;
            this.drinkTextBox.Size = new System.Drawing.Size(318, 285);
            this.drinkTextBox.TabIndex = 0;
            this.drinkTextBox.Text = "";
            // 
            // RestaurantMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 534);
            this.Controls.Add(this.drinkPanel);
            this.Controls.Add(this.dishPanel);
            this.Controls.Add(this.addFood);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.Back);
            this.Name = "RestaurantMenu";
            this.Text = "RestaurantMenu";
            this.Load += new System.EventHandler(this.RestaurantMenu_Load);
            this.dishPanel.ResumeLayout(false);
            this.drinkPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button addDrink;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.Panel dishPanel;
        private System.Windows.Forms.RichTextBox dishTextBox;
        private System.Windows.Forms.Panel drinkPanel;
        private System.Windows.Forms.RichTextBox drinkTextBox;
    }
}