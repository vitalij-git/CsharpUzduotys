namespace EgzaminasRestoranas.Forms
{
    partial class TableReserve
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
            this.confirmReserve = new System.Windows.Forms.Button();
            this.clientName = new System.Windows.Forms.TextBox();
            this.workerRole = new System.Windows.Forms.Label();
            this.workerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(27, 32);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 17;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // confirmReserve
            // 
            this.confirmReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmReserve.Location = new System.Drawing.Point(163, 243);
            this.confirmReserve.Name = "confirmReserve";
            this.confirmReserve.Size = new System.Drawing.Size(137, 43);
            this.confirmReserve.TabIndex = 18;
            this.confirmReserve.Text = "Patvirtinti";
            this.confirmReserve.UseVisualStyleBackColor = true;
            this.confirmReserve.Click += new System.EventHandler(this.confirmReserve_Click);
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(102, 128);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(273, 26);
            this.clientName.TabIndex = 19;
            // 
            // workerRole
            // 
            this.workerRole.AutoSize = true;
            this.workerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerRole.Location = new System.Drawing.Point(309, 68);
            this.workerRole.Name = "workerRole";
            this.workerRole.Size = new System.Drawing.Size(71, 20);
            this.workerRole.TabIndex = 22;
            this.workerRole.Text = "Pareigos";
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(309, 32);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(122, 20);
            this.workerName.TabIndex = 21;
            this.workerName.Text = "Vardas Pavarde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kliento rezervacijos vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pasirinkite rezervacijos laika";
            // 
            // panelBox
            // 
            this.panelBox.Location = new System.Drawing.Point(157, 190);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(143, 30);
            this.panelBox.TabIndex = 25;
            // 
            // TableReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 322);
            this.Controls.Add(this.panelBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workerRole);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.confirmReserve);
            this.Controls.Add(this.Back);
            this.Name = "TableReserve";
            this.Text = "TableReserve";
            this.Load += new System.EventHandler(this.TableReserve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button confirmReserve;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label workerRole;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBox;
    }
}