namespace EgzaminasRestoranas.Forms
{
    partial class TodayTotalProfit
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
            this.panel = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(39, 22);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 34;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(341, 58);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 33;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(341, 22);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 32;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(39, 100);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(410, 262);
            this.panel.TabIndex = 38;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(39, 100);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(410, 262);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // TodayTotalProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 431);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Name = "TodayTotalProfit";
            this.Text = "TodayTotalProfit";
            this.Load += new System.EventHandler(this.TodayTotalProfit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}