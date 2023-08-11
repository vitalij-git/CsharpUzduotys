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
            this.SuspendLayout();
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(635, 9);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(144, 20);
            this.workerName.TabIndex = 2;
            this.workerName.Text = "Prisijungimo vardas";
            this.workerName.Click += new System.EventHandler(this.workerName_Click);
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(635, 42);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(41, 20);
            this.workerRole.TabIndex = 3;
            this.workerRole.Text = "nera";
            // 
            // AdministratorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.WorkerFullName = "AdministratorMain";
            this.Text = "AdministratorMain";
            this.Load += new System.EventHandler(this.AdministratorMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Label workerRole;
    }
}