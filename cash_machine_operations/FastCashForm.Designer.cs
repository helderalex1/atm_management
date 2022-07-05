namespace atm.cash_machine_operations
{
    partial class FastCashForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tenFastCashBtn = new System.Windows.Forms.Button();
            this.twentyFastCashBtn = new System.Windows.Forms.Button();
            this.fortyFastCashBtn = new System.Windows.Forms.Button();
            this.sixtyFastCashBtn = new System.Windows.Forms.Button();
            this.eightyFastCashBtn = new System.Windows.Forms.Button();
            this.oneHundredFastCashBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 100);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "CASH MACHINE - FAST CASH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenFastCashBtn
            // 
            this.tenFastCashBtn.Location = new System.Drawing.Point(130, 110);
            this.tenFastCashBtn.Name = "tenFastCashBtn";
            this.tenFastCashBtn.Size = new System.Drawing.Size(90, 40);
            this.tenFastCashBtn.TabIndex = 12;
            this.tenFastCashBtn.Text = "10€";
            this.tenFastCashBtn.UseVisualStyleBackColor = true;
            this.tenFastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // twentyFastCashBtn
            // 
            this.twentyFastCashBtn.Location = new System.Drawing.Point(130, 170);
            this.twentyFastCashBtn.Name = "twentyFastCashBtn";
            this.twentyFastCashBtn.Size = new System.Drawing.Size(90, 40);
            this.twentyFastCashBtn.TabIndex = 13;
            this.twentyFastCashBtn.Text = "20€";
            this.twentyFastCashBtn.UseVisualStyleBackColor = true;
            this.twentyFastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // fortyFastCashBtn
            // 
            this.fortyFastCashBtn.Location = new System.Drawing.Point(130, 230);
            this.fortyFastCashBtn.Name = "fortyFastCashBtn";
            this.fortyFastCashBtn.Size = new System.Drawing.Size(90, 40);
            this.fortyFastCashBtn.TabIndex = 14;
            this.fortyFastCashBtn.Text = "40€";
            this.fortyFastCashBtn.UseVisualStyleBackColor = true;
            this.fortyFastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // sixtyFastCashBtn
            // 
            this.sixtyFastCashBtn.Location = new System.Drawing.Point(320, 110);
            this.sixtyFastCashBtn.Name = "sixtyFastCashBtn";
            this.sixtyFastCashBtn.Size = new System.Drawing.Size(90, 40);
            this.sixtyFastCashBtn.TabIndex = 15;
            this.sixtyFastCashBtn.Text = "60€";
            this.sixtyFastCashBtn.UseVisualStyleBackColor = true;
            this.sixtyFastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // eightyFastCashBtn
            // 
            this.eightyFastCashBtn.Location = new System.Drawing.Point(320, 170);
            this.eightyFastCashBtn.Name = "eightyFastCashBtn";
            this.eightyFastCashBtn.Size = new System.Drawing.Size(90, 40);
            this.eightyFastCashBtn.TabIndex = 16;
            this.eightyFastCashBtn.Text = "80€";
            this.eightyFastCashBtn.UseVisualStyleBackColor = true;
            this.eightyFastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // oneHundredFastCashBtn
            // 
            this.oneHundredFastCashBtn.Location = new System.Drawing.Point(320, 230);
            this.oneHundredFastCashBtn.Name = "oneHundredFastCashBtn";
            this.oneHundredFastCashBtn.Size = new System.Drawing.Size(90, 40);
            this.oneHundredFastCashBtn.TabIndex = 17;
            this.oneHundredFastCashBtn.Text = "100€";
            this.oneHundredFastCashBtn.UseVisualStyleBackColor = true;
            this.oneHundredFastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(229, 285);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // FastCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.oneHundredFastCashBtn);
            this.Controls.Add(this.eightyFastCashBtn);
            this.Controls.Add(this.sixtyFastCashBtn);
            this.Controls.Add(this.fortyFastCashBtn);
            this.Controls.Add(this.twentyFastCashBtn);
            this.Controls.Add(this.tenFastCashBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastCashForm";
            this.Text = "FastCash";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tenFastCashBtn;
        private System.Windows.Forms.Button twentyFastCashBtn;
        private System.Windows.Forms.Button fortyFastCashBtn;
        private System.Windows.Forms.Button sixtyFastCashBtn;
        private System.Windows.Forms.Button eightyFastCashBtn;
        private System.Windows.Forms.Button oneHundredFastCashBtn;
        private System.Windows.Forms.Button backBtn;
    }
}