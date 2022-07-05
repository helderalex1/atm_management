namespace atm
{
    partial class OperationsForm
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
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.fastcashBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(227, 129);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(140, 60);
            this.depositBtn.TabIndex = 0;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(439, 129);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(140, 60);
            this.withdrawBtn.TabIndex = 1;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // fastcashBtn
            // 
            this.fastcashBtn.Location = new System.Drawing.Point(227, 224);
            this.fastcashBtn.Name = "fastcashBtn";
            this.fastcashBtn.Size = new System.Drawing.Size(140, 60);
            this.fastcashBtn.TabIndex = 3;
            this.fastcashBtn.Text = "FASTCASH";
            this.fastcashBtn.UseVisualStyleBackColor = true;
            this.fastcashBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(439, 224);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(140, 60);
            this.transactionBtn.TabIndex = 4;
            this.transactionBtn.Text = "TRANSACTIONS";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(227, 324);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(140, 60);
            this.transferBtn.TabIndex = 5;
            this.transferBtn.Text = "TRANSFER";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.Location = new System.Drawing.Point(439, 324);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(140, 60);
            this.balanceBtn.TabIndex = 6;
            this.balanceBtn.Text = "BALANCE";
            this.balanceBtn.UseVisualStyleBackColor = true;
            this.balanceBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "CASH MACHINE - OPERATIONS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(366, 415);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logout_Click);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.fastcashBtn);
            this.Controls.Add(this.depositBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperationsForm";
            this.Text = "SelectForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button fastcashBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
    }
}