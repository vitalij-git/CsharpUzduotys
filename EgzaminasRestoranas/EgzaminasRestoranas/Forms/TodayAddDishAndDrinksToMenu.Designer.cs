namespace EgzaminasRestoranas.Forms
{
    partial class TodayAddDishAndDrinksToMenu
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.workerRole = new System.Windows.Forms.Label();
            this.workerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(72, 107);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(410, 262);
            this.TextBox.TabIndex = 39;
            this.TextBox.Text = "";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(72, 107);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(410, 262);
            this.panel.TabIndex = 43;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(72, 29);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 42;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(374, 65);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 41;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(374, 29);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 40;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // TodayAddDishAndDrinksToMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 427);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Name = "TodayAddDishAndDrinksToMenu";
            this.Text = "TodayAddDishAndDrinksToMenu";
            this.Load += new System.EventHandler(this.TodayAddDishAndDrinksToMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
    }
}