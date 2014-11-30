namespace MoneyV2._0
{
    partial class SearchForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PeriodCB = new System.Windows.Forms.CheckBox();
            this.CategoryCB = new System.Windows.Forms.CheckBox();
            this.AimCB = new System.Windows.Forms.CheckBox();
            this.AmountCB = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CategoryTB = new System.Windows.Forms.TextBox();
            this.AimTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(39, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PeriodCB
            // 
            this.PeriodCB.AutoSize = true;
            this.PeriodCB.Location = new System.Drawing.Point(69, 45);
            this.PeriodCB.Name = "PeriodCB";
            this.PeriodCB.Size = new System.Drawing.Size(64, 17);
            this.PeriodCB.TabIndex = 1;
            this.PeriodCB.Text = "Период";
            this.PeriodCB.UseVisualStyleBackColor = true;
            // 
            // CategoryCB
            // 
            this.CategoryCB.AutoSize = true;
            this.CategoryCB.Location = new System.Drawing.Point(297, 45);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(79, 17);
            this.CategoryCB.TabIndex = 2;
            this.CategoryCB.Text = "Категория";
            this.CategoryCB.UseVisualStyleBackColor = true;
            // 
            // AimCB
            // 
            this.AimCB.AutoSize = true;
            this.AimCB.Location = new System.Drawing.Point(462, 45);
            this.AimCB.Name = "AimCB";
            this.AimCB.Size = new System.Drawing.Size(46, 17);
            this.AimCB.TabIndex = 3;
            this.AimCB.Text = "Цел";
            this.AimCB.UseVisualStyleBackColor = true;
            // 
            // AmountCB
            // 
            this.AmountCB.AutoSize = true;
            this.AmountCB.Location = new System.Drawing.Point(651, 45);
            this.AmountCB.Name = "AmountCB";
            this.AmountCB.Size = new System.Drawing.Size(52, 17);
            this.AmountCB.TabIndex = 4;
            this.AmountCB.Text = "Сума";
            this.AmountCB.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CategoryTB
            // 
            this.CategoryTB.Location = new System.Drawing.Point(297, 81);
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(100, 20);
            this.CategoryTB.TabIndex = 7;
            this.CategoryTB.Text = "razhod";
            // 
            // AimTB
            // 
            this.AimTB.Location = new System.Drawing.Point(462, 81);
            this.AimTB.Name = "AimTB";
            this.AimTB.Size = new System.Drawing.Size(100, 20);
            this.AimTB.TabIndex = 8;
            this.AimTB.Text = "-";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(651, 81);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(100, 20);
            this.AmountTB.TabIndex = 9;
            this.AmountTB.Text = "1000";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(822, 46);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(87, 55);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Търси";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 448);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.AimTB);
            this.Controls.Add(this.CategoryTB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AmountCB);
            this.Controls.Add(this.AimCB);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.PeriodCB);
            this.Controls.Add(this.listView1);
            this.Name = "SearchForm";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox PeriodCB;
        private System.Windows.Forms.CheckBox CategoryCB;
        private System.Windows.Forms.CheckBox AimCB;
        private System.Windows.Forms.CheckBox AmountCB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CategoryTB;
        private System.Windows.Forms.TextBox AimTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Button SearchBtn;

        
    }
}