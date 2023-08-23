namespace EgzaminasRestoranas.Forms
{
    partial class Workers
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.workersComboBox = new System.Windows.Forms.ComboBox();
            this.workerUpdate = new System.Windows.Forms.Button();
            this.workerDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(391, 45);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 23;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(391, 9);
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
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(56, 116);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(410, 210);
            this.TextBox.TabIndex = 41;
            this.TextBox.Text = "";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(56, 116);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(410, 210);
            this.panel.TabIndex = 42;
            // 
            // workersComboBox
            // 
            this.workersComboBox.FormattingEnabled = true;
            this.workersComboBox.Location = new System.Drawing.Point(56, 389);
            this.workersComboBox.Name = "workersComboBox";
            this.workersComboBox.Size = new System.Drawing.Size(216, 21);
            this.workersComboBox.TabIndex = 43;
            // 
            // workerUpdate
            // 
            this.workerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerUpdate.Location = new System.Drawing.Point(56, 416);
            this.workerUpdate.Name = "workerUpdate";
            this.workerUpdate.Size = new System.Drawing.Size(171, 49);
            this.workerUpdate.TabIndex = 44;
            this.workerUpdate.Text = "Atnaujinti darbuotojo duomenys";
            this.workerUpdate.UseVisualStyleBackColor = true;
            this.workerUpdate.Click += new System.EventHandler(this.workerUpdate_Click);
            // 
            // workerDelete
            // 
            this.workerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerDelete.Location = new System.Drawing.Point(250, 416);
            this.workerDelete.Name = "workerDelete";
            this.workerDelete.Size = new System.Drawing.Size(162, 49);
            this.workerDelete.TabIndex = 45;
            this.workerDelete.Text = "Ištrinti darbuotoją";
            this.workerDelete.UseVisualStyleBackColor = true;
            this.workerDelete.Click += new System.EventHandler(this.workerDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pasirinkite darbuotoją ir norima veiksma";
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workerDelete);
            this.Controls.Add(this.workerUpdate);
            this.Controls.Add(this.workersComboBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.Back);
            this.Name = "Workers";
            this.Text = "Workers";
            this.Load += new System.EventHandler(this.Workers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox workersComboBox;
        private System.Windows.Forms.Button workerUpdate;
        private System.Windows.Forms.Button workerDelete;
        private System.Windows.Forms.Label label1;
    }
}