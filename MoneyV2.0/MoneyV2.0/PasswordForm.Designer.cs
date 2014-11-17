namespace MoneyV2._0
{
    partial class PasswordForm
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.EnterMoneyMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 41);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(51, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Парола :";
            // 
            // PasswordTB
            // 
            this.PasswordTB.HideSelection = false;
            this.PasswordTB.Location = new System.Drawing.Point(94, 38);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 1;
            this.PasswordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // EnterMoneyMenuBtn
            // 
            this.EnterMoneyMenuBtn.Location = new System.Drawing.Point(119, 79);
            this.EnterMoneyMenuBtn.Name = "EnterMoneyMenuBtn";
            this.EnterMoneyMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterMoneyMenuBtn.TabIndex = 2;
            this.EnterMoneyMenuBtn.Text = "Влез";
            this.EnterMoneyMenuBtn.UseVisualStyleBackColor = true;
            this.EnterMoneyMenuBtn.Click += new System.EventHandler(this.EnterMoneyMenuBtn_Click);
            this.EnterMoneyMenuBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 114);
            this.Controls.Add(this.EnterMoneyMenuBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "PasswordForm";
            this.Text = "Вход";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button EnterMoneyMenuBtn;
    }
}