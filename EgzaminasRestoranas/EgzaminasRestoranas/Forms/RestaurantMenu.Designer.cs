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
            this.label1 = new System.Windows.Forms.Label();
            this.dishDelete = new System.Windows.Forms.Button();
            this.dishUpdate = new System.Windows.Forms.Button();
            this.dishComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drinkDelete = new System.Windows.Forms.Button();
            this.drinkUpdate = new System.Windows.Forms.Button();
            this.drinkComboBox = new System.Windows.Forms.ComboBox();
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
            this.addDrink.Location = new System.Drawing.Point(538, 523);
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
            this.addFood.Location = new System.Drawing.Point(135, 523);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Pasirinkite darbuotoją ir norima veiksma";
            // 
            // dishDelete
            // 
            this.dishDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishDelete.Location = new System.Drawing.Point(230, 442);
            this.dishDelete.Name = "dishDelete";
            this.dishDelete.Size = new System.Drawing.Size(162, 49);
            this.dishDelete.TabIndex = 49;
            this.dishDelete.Text = "Ištrinti pateikalą";
            this.dishDelete.UseVisualStyleBackColor = true;
            this.dishDelete.Click += new System.EventHandler(this.dishDelete_Click);
            // 
            // dishUpdate
            // 
            this.dishUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishUpdate.Location = new System.Drawing.Point(36, 442);
            this.dishUpdate.Name = "dishUpdate";
            this.dishUpdate.Size = new System.Drawing.Size(171, 49);
            this.dishUpdate.TabIndex = 48;
            this.dishUpdate.Text = "Atnaujinti patiekalą";
            this.dishUpdate.UseVisualStyleBackColor = true;
            this.dishUpdate.Click += new System.EventHandler(this.dishUpdate_Click);
            // 
            // dishComboBox
            // 
            this.dishComboBox.FormattingEnabled = true;
            this.dishComboBox.Location = new System.Drawing.Point(36, 415);
            this.dishComboBox.Name = "dishComboBox";
            this.dishComboBox.Size = new System.Drawing.Size(216, 21);
            this.dishComboBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pasirinkite darbuotoją ir norima veiksma";
            // 
            // drinkDelete
            // 
            this.drinkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkDelete.Location = new System.Drawing.Point(611, 442);
            this.drinkDelete.Name = "drinkDelete";
            this.drinkDelete.Size = new System.Drawing.Size(162, 49);
            this.drinkDelete.TabIndex = 53;
            this.drinkDelete.Text = "Ištrinti gėrimą";
            this.drinkDelete.UseVisualStyleBackColor = true;
            this.drinkDelete.Click += new System.EventHandler(this.drinkDelete_Click);
            // 
            // drinkUpdate
            // 
            this.drinkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkUpdate.Location = new System.Drawing.Point(417, 442);
            this.drinkUpdate.Name = "drinkUpdate";
            this.drinkUpdate.Size = new System.Drawing.Size(171, 49);
            this.drinkUpdate.TabIndex = 52;
            this.drinkUpdate.Text = "Atnaujinti gėrimą";
            this.drinkUpdate.UseVisualStyleBackColor = true;
            this.drinkUpdate.Click += new System.EventHandler(this.drinkUpdate_Click);
            // 
            // drinkComboBox
            // 
            this.drinkComboBox.FormattingEnabled = true;
            this.drinkComboBox.Location = new System.Drawing.Point(417, 415);
            this.drinkComboBox.Name = "drinkComboBox";
            this.drinkComboBox.Size = new System.Drawing.Size(216, 21);
            this.drinkComboBox.TabIndex = 51;
            // 
            // RestaurantMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drinkDelete);
            this.Controls.Add(this.drinkUpdate);
            this.Controls.Add(this.drinkComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishDelete);
            this.Controls.Add(this.dishUpdate);
            this.Controls.Add(this.dishComboBox);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dishDelete;
        private System.Windows.Forms.Button dishUpdate;
        private System.Windows.Forms.ComboBox dishComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button drinkDelete;
        private System.Windows.Forms.Button drinkUpdate;
        private System.Windows.Forms.ComboBox drinkComboBox;
    }
}