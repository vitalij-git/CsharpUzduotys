namespace EgzaminasRestoranas.Forms
{
    partial class OrderReceipt
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
            this.receiptPrint = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // receiptPrint
            // 
            this.receiptPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptPrint.Location = new System.Drawing.Point(144, 306);
            this.receiptPrint.Name = "receiptPrint";
            this.receiptPrint.Size = new System.Drawing.Size(137, 43);
            this.receiptPrint.TabIndex = 28;
            this.receiptPrint.Text = "Spausdinti kvita";
            this.receiptPrint.UseVisualStyleBackColor = true;
            this.receiptPrint.Click += new System.EventHandler(this.receiptPrint_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.TextBox);
            this.panel.Location = new System.Drawing.Point(52, 15);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(321, 285);
            this.panel.TabIndex = 38;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(321, 285);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // OrderReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 387);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.receiptPrint);
            this.Name = "OrderReceipt";
            this.Text = "OrderReceipt";
            this.Load += new System.EventHandler(this.OrderReceipt_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button receiptPrint;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}