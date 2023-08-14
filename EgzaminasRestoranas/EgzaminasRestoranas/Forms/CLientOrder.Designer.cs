namespace EgzaminasRestoranas.Forms
{
    partial class CLientOrder
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
            this.workerRole = new System.Windows.Forms.Label();
            this.workerName = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dish = new System.Windows.Forms.Label();
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.AddDishToOrder = new System.Windows.Forms.Button();
            this.AddDrinkToOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(401, 56);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 23;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(401, 20);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 22;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(37, 20);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 21;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pridėkite patiekalus ar gėrimus, kurio užsakė klientas";
            // 
            // Dish
            // 
            this.Dish.AutoSize = true;
            this.Dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dish.Location = new System.Drawing.Point(33, 171);
            this.Dish.Name = "Dish";
            this.Dish.Size = new System.Drawing.Size(216, 20);
            this.Dish.TabIndex = 25;
            this.Dish.Text = "Pasirinkite patiekalą iš sąrašo";
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(255, 170);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(254, 21);
            this.comboBoxDish.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pasirinkite gėrimą iš sąrašo";
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(255, 254);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(254, 21);
            this.comboBoxDrink.TabIndex = 28;
            // 
            // AddDishToOrder
            // 
            this.AddDishToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDishToOrder.Location = new System.Drawing.Point(372, 197);
            this.AddDishToOrder.Name = "AddDishToOrder";
            this.AddDishToOrder.Size = new System.Drawing.Size(137, 43);
            this.AddDishToOrder.TabIndex = 29;
            this.AddDishToOrder.Text = "Pridėti";
            this.AddDishToOrder.UseVisualStyleBackColor = true;
            this.AddDishToOrder.Click += new System.EventHandler(this.AddDishToOrder_Click);
            // 
            // AddDrinkToOrder
            // 
            this.AddDrinkToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDrinkToOrder.Location = new System.Drawing.Point(372, 281);
            this.AddDrinkToOrder.Name = "AddDrinkToOrder";
            this.AddDrinkToOrder.Size = new System.Drawing.Size(137, 43);
            this.AddDrinkToOrder.TabIndex = 30;
            this.AddDrinkToOrder.Text = "Pridėti";
            this.AddDrinkToOrder.UseVisualStyleBackColor = true;
            this.AddDrinkToOrder.Click += new System.EventHandler(this.AddDrinkToOrder_Click);
            // 
            // CLientOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 362);
            this.Controls.Add(this.AddDrinkToOrder);
            this.Controls.Add(this.AddDishToOrder);
            this.Controls.Add(this.comboBoxDrink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDish);
            this.Controls.Add(this.Dish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.Back);
            this.Name = "CLientOrder";
            this.Text = "CLientOrder";
            this.Load += new System.EventHandler(this.CLientOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dish;
        private System.Windows.Forms.ComboBox comboBoxDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.Button AddDishToOrder;
        private System.Windows.Forms.Button AddDrinkToOrder;
    }
}