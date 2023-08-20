namespace EgzaminasRestoranas.Forms
{
    partial class WaiterStatistics
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.chosedWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showWorkerStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(35, 19);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 37;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(405, 55);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 36;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(405, 19);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 35;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(80, 163);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(410, 210);
            this.TextBox.TabIndex = 39;
            this.TextBox.Text = "";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(80, 163);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(410, 210);
            this.panel.TabIndex = 40;
            // 
            // chosedWorker
            // 
            this.chosedWorker.FormattingEnabled = true;
            this.chosedWorker.Location = new System.Drawing.Point(268, 88);
            this.chosedWorker.Name = "chosedWorker";
            this.chosedWorker.Size = new System.Drawing.Size(222, 21);
            this.chosedWorker.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Pasirinkite darbuotoją";
            // 
            // showWorkerStatistics
            // 
            this.showWorkerStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showWorkerStatistics.Location = new System.Drawing.Point(325, 114);
            this.showWorkerStatistics.Name = "showWorkerStatistics";
            this.showWorkerStatistics.Size = new System.Drawing.Size(154, 43);
            this.showWorkerStatistics.TabIndex = 43;
            this.showWorkerStatistics.Text = "Parodyti statistika";
            this.showWorkerStatistics.UseVisualStyleBackColor = true;
            this.showWorkerStatistics.Click += new System.EventHandler(this.showWorkerStatistics_Click);
            // 
            // WaiterStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 401);
            this.Controls.Add(this.showWorkerStatistics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chosedWorker);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Name = "WaiterStatistics";
            this.Text = "WaiterStatistics";
            this.Load += new System.EventHandler(this.WaiterStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox chosedWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showWorkerStatistics;
    }
}