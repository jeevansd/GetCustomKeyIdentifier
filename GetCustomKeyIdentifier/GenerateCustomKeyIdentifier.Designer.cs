namespace GetCustomKeyIdentifier
{
    partial class GenerateCustomKeyIdentifier
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
            this.lblSha256ThumbPrint = new System.Windows.Forms.Label();
            this.txtSha256ThumbPrint = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCustomKeyIdentifier = new System.Windows.Forms.Label();
            this.txtCustomKeyIdentifier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSha256ThumbPrint
            // 
            this.lblSha256ThumbPrint.AutoSize = true;
            this.lblSha256ThumbPrint.Location = new System.Drawing.Point(50, 59);
            this.lblSha256ThumbPrint.Name = "lblSha256ThumbPrint";
            this.lblSha256ThumbPrint.Size = new System.Drawing.Size(100, 13);
            this.lblSha256ThumbPrint.TabIndex = 0;
            this.lblSha256ThumbPrint.Text = "Sha256 Thumbprint";
            // 
            // txtSha256ThumbPrint
            // 
            this.txtSha256ThumbPrint.Location = new System.Drawing.Point(156, 56);
            this.txtSha256ThumbPrint.Multiline = true;
            this.txtSha256ThumbPrint.Name = "txtSha256ThumbPrint";
            this.txtSha256ThumbPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSha256ThumbPrint.Size = new System.Drawing.Size(504, 73);
            this.txtSha256ThumbPrint.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(156, 147);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCustomKeyIdentifier
            // 
            this.lblCustomKeyIdentifier.AutoSize = true;
            this.lblCustomKeyIdentifier.Location = new System.Drawing.Point(50, 209);
            this.lblCustomKeyIdentifier.Name = "lblCustomKeyIdentifier";
            this.lblCustomKeyIdentifier.Size = new System.Drawing.Size(106, 13);
            this.lblCustomKeyIdentifier.TabIndex = 3;
            this.lblCustomKeyIdentifier.Text = "Custom Key Identifier";
            // 
            // txtCustomKeyIdentifier
            // 
            this.txtCustomKeyIdentifier.Location = new System.Drawing.Point(156, 206);
            this.txtCustomKeyIdentifier.Multiline = true;
            this.txtCustomKeyIdentifier.Name = "txtCustomKeyIdentifier";
            this.txtCustomKeyIdentifier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomKeyIdentifier.Size = new System.Drawing.Size(504, 57);
            this.txtCustomKeyIdentifier.TabIndex = 4;
            // 
            // GenerateCustomKeyIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 303);
            this.Controls.Add(this.txtCustomKeyIdentifier);
            this.Controls.Add(this.lblCustomKeyIdentifier);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSha256ThumbPrint);
            this.Controls.Add(this.lblSha256ThumbPrint);
            this.Name = "GenerateCustomKeyIdentifier";
            this.Text = "Generate CustomKeyIdentifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSha256ThumbPrint;
        private System.Windows.Forms.TextBox txtSha256ThumbPrint;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCustomKeyIdentifier;
        private System.Windows.Forms.TextBox txtCustomKeyIdentifier;
    }
}

