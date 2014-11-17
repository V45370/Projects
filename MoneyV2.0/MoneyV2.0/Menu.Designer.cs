namespace MoneyV2._0
{
    partial class Menu
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
            this.OpenHistoryForm = new System.Windows.Forms.Button();
            this.OpenMoneyFormBtn = new System.Windows.Forms.Button();
            this.CashDeskListView = new System.Windows.Forms.ListView();
            this.SessionView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // OpenHistoryForm
            // 
            this.OpenHistoryForm.Location = new System.Drawing.Point(36, 159);
            this.OpenHistoryForm.Name = "OpenHistoryForm";
            this.OpenHistoryForm.Size = new System.Drawing.Size(126, 41);
            this.OpenHistoryForm.TabIndex = 1;
            this.OpenHistoryForm.Text = "Паричен поток";
            this.OpenHistoryForm.UseVisualStyleBackColor = true;
            this.OpenHistoryForm.Click += new System.EventHandler(this.OpenHistoryForm_Click);
            // 
            // OpenMoneyFormBtn
            // 
            this.OpenMoneyFormBtn.Location = new System.Drawing.Point(36, 100);
            this.OpenMoneyFormBtn.Name = "OpenMoneyFormBtn";
            this.OpenMoneyFormBtn.Size = new System.Drawing.Size(126, 41);
            this.OpenMoneyFormBtn.TabIndex = 2;
            this.OpenMoneyFormBtn.Text = "Пари";
            this.OpenMoneyFormBtn.UseVisualStyleBackColor = true;
            this.OpenMoneyFormBtn.Click += new System.EventHandler(this.OpenMoneyFormBtn_Click);
            // 
            // CashDeskListView
            // 
            this.CashDeskListView.Location = new System.Drawing.Point(194, 529);
            this.CashDeskListView.Name = "CashDeskListView";
            this.CashDeskListView.Size = new System.Drawing.Size(689, 57);
            this.CashDeskListView.TabIndex = 3;
            this.CashDeskListView.UseCompatibleStateImageBehavior = false;
            this.CashDeskListView.View = System.Windows.Forms.View.Details;
            // 
            // SessionView
            // 
            this.SessionView.Location = new System.Drawing.Point(279, 100);
            this.SessionView.Name = "SessionView";
            this.SessionView.Size = new System.Drawing.Size(604, 415);
            this.SessionView.TabIndex = 4;
            this.SessionView.UseCompatibleStateImageBehavior = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 598);
            this.Controls.Add(this.SessionView);
            this.Controls.Add(this.CashDeskListView);
            this.Controls.Add(this.OpenMoneyFormBtn);
            this.Controls.Add(this.OpenHistoryForm);
            this.Name = "Menu";
            this.Text = "Money Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenHistoryForm;
        private System.Windows.Forms.Button OpenMoneyFormBtn;
        private System.Windows.Forms.ListView CashDeskListView;
        private System.Windows.Forms.ListView SessionView;
    }
}

