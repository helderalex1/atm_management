namespace atm
{
    partial class RegisterPage
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
            this.RegistNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistAccountBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistEmailTextBox = new System.Windows.Forms.TextBox();
            this.RegistPinTextBox = new System.Windows.Forms.TextBox();
            this.LoginPageBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistNameTextBox
            // 
            this.RegistNameTextBox.Location = new System.Drawing.Point(81, 66);
            this.RegistNameTextBox.Name = "RegistNameTextBox";
            this.RegistNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegistNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // RegistAccountBtn
            // 
            this.RegistAccountBtn.Location = new System.Drawing.Point(94, 255);
            this.RegistAccountBtn.Name = "RegistAccountBtn";
            this.RegistAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistAccountBtn.TabIndex = 2;
            this.RegistAccountBtn.Text = "Regist";
            this.RegistAccountBtn.UseVisualStyleBackColor = true;
            this.RegistAccountBtn.Click += new System.EventHandler(this.RegistAccountBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pin";
            // 
            // RegistEmailTextBox
            // 
            this.RegistEmailTextBox.Location = new System.Drawing.Point(81, 139);
            this.RegistEmailTextBox.Name = "RegistEmailTextBox";
            this.RegistEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegistEmailTextBox.TabIndex = 5;
            // 
            // RegistPinTextBox
            // 
            this.RegistPinTextBox.Location = new System.Drawing.Point(81, 209);
            this.RegistPinTextBox.Name = "RegistPinTextBox";
            this.RegistPinTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegistPinTextBox.TabIndex = 6;
            // 
            // LoginPageBtn
            // 
            this.LoginPageBtn.Location = new System.Drawing.Point(410, 103);
            this.LoginPageBtn.Name = "LoginPageBtn";
            this.LoginPageBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginPageBtn.TabIndex = 7;
            this.LoginPageBtn.Text = "Go to Login";
            this.LoginPageBtn.UseVisualStyleBackColor = true;
            this.LoginPageBtn.Click += new System.EventHandler(this.LoginPageBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Informação de registo";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginPageBtn);
            this.Controls.Add(this.RegistPinTextBox);
            this.Controls.Add(this.RegistEmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistAccountBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegistNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistAccountBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegistEmailTextBox;
        private System.Windows.Forms.TextBox RegistPinTextBox;
        private System.Windows.Forms.Button LoginPageBtn;
        private System.Windows.Forms.Label label4;
    }
}