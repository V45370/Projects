namespace MoneyV2._0
{
    partial class CategoryForm
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
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutcomeRB = new System.Windows.Forms.RadioButton();
            this.IncomeRB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AddCategoryBtn.Location = new System.Drawing.Point(63, 93);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(105, 28);
            this.AddCategoryBtn.TabIndex = 0;
            this.AddCategoryBtn.Text = "Добави";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            this.AddCategoryBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OutcomeRB);
            this.panel1.Controls.Add(this.IncomeRB);
            this.panel1.Location = new System.Drawing.Point(45, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 49);
            this.panel1.TabIndex = 1;
            // 
            // OutcomeRB
            // 
            this.OutcomeRB.AutoSize = true;
            this.OutcomeRB.Location = new System.Drawing.Point(38, 27);
            this.OutcomeRB.Name = "OutcomeRB";
            this.OutcomeRB.Size = new System.Drawing.Size(61, 17);
            this.OutcomeRB.TabIndex = 1;
            this.OutcomeRB.TabStop = true;
            this.OutcomeRB.Text = "Разход";
            this.OutcomeRB.UseVisualStyleBackColor = true;
            // 
            // IncomeRB
            // 
            this.IncomeRB.AutoSize = true;
            this.IncomeRB.Location = new System.Drawing.Point(38, 3);
            this.IncomeRB.Name = "IncomeRB";
            this.IncomeRB.Size = new System.Drawing.Size(62, 17);
            this.IncomeRB.TabIndex = 0;
            this.IncomeRB.TabStop = true;
            this.IncomeRB.Text = "Приход";
            this.IncomeRB.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 133);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddCategoryBtn);
            this.Name = "CategoryForm";
            this.Text = "Приход или Разход";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCategoryBtn;
        public MoneyForm parent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OutcomeRB;
        private System.Windows.Forms.RadioButton IncomeRB;
    }
}