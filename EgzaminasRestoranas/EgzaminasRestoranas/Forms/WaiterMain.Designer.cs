namespace EgzaminasRestoranas.Forms
{
    partial class WaiterMain
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
            this.ShowMenu = new System.Windows.Forms.Button();
            this.Tables = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(650, 45);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 5;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(650, 9);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 4;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMenu.Location = new System.Drawing.Point(298, 146);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(160, 53);
            this.ShowMenu.TabIndex = 15;
            this.ShowMenu.Text = "Pėržiuti meniu";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // Tables
            // 
            this.Tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables.Location = new System.Drawing.Point(83, 146);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(160, 53);
            this.Tables.TabIndex = 12;
            this.Tables.Text = "Staliukai";
            this.Tables.UseVisualStyleBackColor = true;
            this.Tables.Click += new System.EventHandler(this.Tables_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(628, 385);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(160, 53);
            this.Logout.TabIndex = 16;
            this.Logout.Text = "Atsijungti";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // WaiterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ShowMenu);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Name = "WaiterMain";
            this.Text = "WaiterMain";
            this.Load += new System.EventHandler(this.WaiterMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.Button Tables;
        private System.Windows.Forms.Button Logout;
    }
}