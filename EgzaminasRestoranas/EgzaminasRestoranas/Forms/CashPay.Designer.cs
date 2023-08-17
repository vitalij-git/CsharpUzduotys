namespace EgzaminasRestoranas.Forms
{
    partial class CashPay
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
            this.PayWithoutReceipt = new System.Windows.Forms.Button();
            this.PayWithReceipt = new System.Windows.Forms.Button();
            this.MoneySum = new System.Windows.Forms.TextBox();
            this.MoneyTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(36, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 43);
            this.Back.TabIndex = 22;
            this.Back.Text = "Grįžti";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PayWithoutReceipt
            // 
            this.PayWithoutReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayWithoutReceipt.Location = new System.Drawing.Point(46, 202);
            this.PayWithoutReceipt.Name = "PayWithoutReceipt";
            this.PayWithoutReceipt.Size = new System.Drawing.Size(152, 53);
            this.PayWithoutReceipt.TabIndex = 23;
            this.PayWithoutReceipt.Text = "Priimti mokėjimą, be čekio";
            this.PayWithoutReceipt.UseVisualStyleBackColor = true;
            this.PayWithoutReceipt.Click += new System.EventHandler(this.PayWithoutReceipt_Click);
            // 
            // PayWithReceipt
            // 
            this.PayWithReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayWithReceipt.Location = new System.Drawing.Point(250, 202);
            this.PayWithReceipt.Name = "PayWithReceipt";
            this.PayWithReceipt.Size = new System.Drawing.Size(148, 53);
            this.PayWithReceipt.TabIndex = 24;
            this.PayWithReceipt.Text = "Priimti mokėjimą, su čekių";
            this.PayWithReceipt.UseVisualStyleBackColor = true;
            // 
            // MoneySum
            // 
            this.MoneySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneySum.Location = new System.Drawing.Point(81, 149);
            this.MoneySum.Name = "MoneySum";
            this.MoneySum.Size = new System.Drawing.Size(273, 26);
            this.MoneySum.TabIndex = 25;
            // 
            // MoneyTitle
            // 
            this.MoneyTitle.AutoSize = true;
            this.MoneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyTitle.Location = new System.Drawing.Point(120, 126);
            this.MoneyTitle.Name = "MoneyTitle";
            this.MoneyTitle.Size = new System.Drawing.Size(201, 20);
            this.MoneyTitle.TabIndex = 26;
            this.MoneyTitle.Text = "Įveskite duoda pinigų suma";
            // 
            // CashPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 326);
            this.Controls.Add(this.MoneyTitle);
            this.Controls.Add(this.MoneySum);
            this.Controls.Add(this.PayWithReceipt);
            this.Controls.Add(this.PayWithoutReceipt);
            this.Controls.Add(this.Back);
            this.Name = "CashPay";
            this.Text = "CashPay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button PayWithoutReceipt;
        private System.Windows.Forms.Button PayWithReceipt;
        private System.Windows.Forms.TextBox MoneySum;
        private System.Windows.Forms.Label MoneyTitle;
    }
}