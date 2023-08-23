namespace EgzaminasRestoranas.Forms
{
    partial class AdministratorMain
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
            this.workerName = new System.Windows.Forms.Label();
            this.workerRole = new System.Windows.Forms.Label();
            this.AddNewWorker = new System.Windows.Forms.Button();
            this.ShowWorkers = new System.Windows.Forms.Button();
            this.Statisctics = new System.Windows.Forms.Button();
            this.ShowMenu = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(635, 9);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 2;
            this.workerName.Text = "Vardas Pavarde";
            this.workerName.Click += new System.EventHandler(this.workerName_Click);
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(635, 45);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 3;
            this.workerRole.Text = "Pareigos";
            // 
            // AddNewWorker
            // 
            this.AddNewWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewWorker.Location = new System.Drawing.Point(56, 144);
            this.AddNewWorker.Name = "AddNewWorker";
            this.AddNewWorker.Size = new System.Drawing.Size(160, 53);
            this.AddNewWorker.TabIndex = 7;
            this.AddNewWorker.Text = "Pridėti nauja darbuotoja";
            this.AddNewWorker.UseVisualStyleBackColor = true;
            this.AddNewWorker.Click += new System.EventHandler(this.AddNewWorker_Click);
            // 
            // ShowWorkers
            // 
            this.ShowWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowWorkers.Location = new System.Drawing.Point(56, 229);
            this.ShowWorkers.Name = "ShowWorkers";
            this.ShowWorkers.Size = new System.Drawing.Size(160, 53);
            this.ShowWorkers.TabIndex = 8;
            this.ShowWorkers.Text = "Peržiūrėti darbuotojus";
            this.ShowWorkers.UseVisualStyleBackColor = true;
            this.ShowWorkers.Click += new System.EventHandler(this.ShowWorkers_Click);
            // 
            // Statisctics
            // 
            this.Statisctics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statisctics.Location = new System.Drawing.Point(271, 229);
            this.Statisctics.Name = "Statisctics";
            this.Statisctics.Size = new System.Drawing.Size(160, 53);
            this.Statisctics.TabIndex = 9;
            this.Statisctics.Text = "Statistika";
            this.Statisctics.UseVisualStyleBackColor = true;
            this.Statisctics.Click += new System.EventHandler(this.Statisctics_Click);
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMenu.Location = new System.Drawing.Point(271, 144);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(160, 53);
            this.ShowMenu.TabIndex = 10;
            this.ShowMenu.Text = "Pėržiuti meniu";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(628, 385);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(160, 53);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Atsijungti";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdministratorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ShowMenu);
            this.Controls.Add(this.Statisctics);
            this.Controls.Add(this.ShowWorkers);
            this.Controls.Add(this.AddNewWorker);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Name = "AdministratorMain";
            this.Text = "AdministratorMain";
            this.Load += new System.EventHandler(this.AdministratorMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Button AddNewWorker;
        private System.Windows.Forms.Button ShowWorkers;
        private System.Windows.Forms.Button Statisctics;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.Button Logout;
    }
}