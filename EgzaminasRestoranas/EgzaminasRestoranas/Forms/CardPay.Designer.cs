namespace EgzaminasRestoranas.Forms
{
    partial class CardPay
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
            this.CardProces = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.withReceipt = new System.Windows.Forms.Button();
            this.withoutReceipt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardProces
            // 
            this.CardProces.AutoSize = true;
            this.CardProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardProces.Location = new System.Drawing.Point(116, 109);
            this.CardProces.Name = "CardProces";
            this.CardProces.Size = new System.Drawing.Size(269, 20);
            this.CardProces.TabIndex = 27;
            this.CardProces.Text = "Vyksta kortėles mokėjimo procesas...";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(22, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 28;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // withReceipt
            // 
            this.withReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withReceipt.Location = new System.Drawing.Point(269, 203);
            this.withReceipt.Name = "withReceipt";
            this.withReceipt.Size = new System.Drawing.Size(137, 43);
            this.withReceipt.TabIndex = 29;
            this.withReceipt.Text = "Su čekiu";
            this.withReceipt.UseVisualStyleBackColor = true;
            this.withReceipt.Click += new System.EventHandler(this.withReceipt_Click);
            // 
            // withoutReceipt
            // 
            this.withoutReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withoutReceipt.Location = new System.Drawing.Point(110, 203);
            this.withoutReceipt.Name = "withoutReceipt";
            this.withoutReceipt.Size = new System.Drawing.Size(137, 43);
            this.withoutReceipt.TabIndex = 30;
            this.withoutReceipt.Text = "Be čekio";
            this.withoutReceipt.UseVisualStyleBackColor = true;
            this.withoutReceipt.Click += new System.EventHandler(this.withoutReceipt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pasirinkite patvirtinimo procesa, su čekiu atsispausinimui ar be";
            // 
            // CardPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withoutReceipt);
            this.Controls.Add(this.withReceipt);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CardProces);
            this.Name = "CardPay";
            this.Text = "CardPay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardProces;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button withReceipt;
        private System.Windows.Forms.Button withoutReceipt;
        private System.Windows.Forms.Label label1;
    }
}