namespace EgzaminasRestoranas.Forms
{
    partial class Statistics
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
            this.totalProfit = new System.Windows.Forms.Button();
            this.TodayAddedToMenu = new System.Windows.Forms.Button();
            this.waiterStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(248, 48);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 5;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(248, 12);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 4;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 31;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // totalProfit
            // 
            this.totalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProfit.Location = new System.Drawing.Point(39, 120);
            this.totalProfit.Name = "totalProfit";
            this.totalProfit.Size = new System.Drawing.Size(155, 69);
            this.totalProfit.TabIndex = 32;
            this.totalProfit.Text = " Šiandienos orderių total profit";
            this.totalProfit.UseVisualStyleBackColor = true;
            this.totalProfit.Click += new System.EventHandler(this.totalProfit_Click);
            // 
            // TodayAddedToMenu
            // 
            this.TodayAddedToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayAddedToMenu.Location = new System.Drawing.Point(215, 120);
            this.TodayAddedToMenu.Name = "TodayAddedToMenu";
            this.TodayAddedToMenu.Size = new System.Drawing.Size(155, 69);
            this.TodayAddedToMenu.TabIndex = 33;
            this.TodayAddedToMenu.Text = " Šiandieną pridėtų produktų sąrašą";
            this.TodayAddedToMenu.UseVisualStyleBackColor = true;
            this.TodayAddedToMenu.Click += new System.EventHandler(this.TodayAddedToMenu_Click);
            // 
            // waiterStatistics
            // 
            this.waiterStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterStatistics.Location = new System.Drawing.Point(119, 195);
            this.waiterStatistics.Name = "waiterStatistics";
            this.waiterStatistics.Size = new System.Drawing.Size(155, 69);
            this.waiterStatistics.TabIndex = 34;
            this.waiterStatistics.Text = " Padavėjų statistika";
            this.waiterStatistics.UseVisualStyleBackColor = true;
            this.waiterStatistics.Click += new System.EventHandler(this.waiterStatistics_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 306);
            this.Controls.Add(this.waiterStatistics);
            this.Controls.Add(this.TodayAddedToMenu);
            this.Controls.Add(this.totalProfit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button totalProfit;
        private System.Windows.Forms.Button TodayAddedToMenu;
        private System.Windows.Forms.Button waiterStatistics;
    }
}