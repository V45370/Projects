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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.OpenSearchForm = new System.Windows.Forms.Button();
            this.OpenMoneyFormBtn = new System.Windows.Forms.Button();
            this.CashDeskListView = new System.Windows.Forms.ListView();
            this.Qty100Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty50Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty20Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty10Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty5Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SessionView = new System.Windows.Forms.ListView();
            this.NumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AimColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NextDateBtn = new System.Windows.Forms.Button();
            this.PreviusDateBtn = new System.Windows.Forms.Button();
            this.ThisComputerCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenSearchForm
            // 
            this.OpenSearchForm.BackgroundImage = global::MoneyV2._0.Properties.Resources.search_icon;
            this.OpenSearchForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenSearchForm.Location = new System.Drawing.Point(779, 194);
            this.OpenSearchForm.Name = "OpenSearchForm";
            this.OpenSearchForm.Size = new System.Drawing.Size(74, 70);
            this.OpenSearchForm.TabIndex = 1;
            this.OpenSearchForm.Text = "Справка";
            this.OpenSearchForm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.OpenSearchForm.UseVisualStyleBackColor = true;
            this.OpenSearchForm.Click += new System.EventHandler(this.OpenSearchForm_Click);
            // 
            // OpenMoneyFormBtn
            // 
            this.OpenMoneyFormBtn.BackColor = System.Drawing.SystemColors.Window;
            this.OpenMoneyFormBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenMoneyFormBtn.BackgroundImage")));
            this.OpenMoneyFormBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenMoneyFormBtn.Location = new System.Drawing.Point(779, 115);
            this.OpenMoneyFormBtn.Name = "OpenMoneyFormBtn";
            this.OpenMoneyFormBtn.Size = new System.Drawing.Size(74, 73);
            this.OpenMoneyFormBtn.TabIndex = 2;
            this.OpenMoneyFormBtn.Text = "Пари";
            this.OpenMoneyFormBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OpenMoneyFormBtn.UseVisualStyleBackColor = false;
            this.OpenMoneyFormBtn.Click += new System.EventHandler(this.OpenMoneyFormBtn_Click);
            // 
            // CashDeskListView
            // 
            this.CashDeskListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CashDeskListView.BackColor = System.Drawing.Color.PapayaWhip;
            this.CashDeskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Qty100Column,
            this.Qty50Column,
            this.Qty20Column,
            this.Qty10Column,
            this.Qty5Column,
            this.Qty2Column,
            this.Qty1Column,
            this.Total});
            this.CashDeskListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashDeskListView.Location = new System.Drawing.Point(32, 464);
            this.CashDeskListView.Name = "CashDeskListView";
            this.CashDeskListView.Size = new System.Drawing.Size(505, 101);
            this.CashDeskListView.TabIndex = 3;
            this.CashDeskListView.UseCompatibleStateImageBehavior = false;
            this.CashDeskListView.View = System.Windows.Forms.View.Details;
            // 
            // Qty100Column
            // 
            this.Qty100Column.Text = "x 100";
            // 
            // Qty50Column
            // 
            this.Qty50Column.Text = "x 50";
            this.Qty50Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty20Column
            // 
            this.Qty20Column.Text = "x 20";
            this.Qty20Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty10Column
            // 
            this.Qty10Column.Text = "x 10";
            this.Qty10Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty5Column
            // 
            this.Qty5Column.Text = "x 5";
            this.Qty5Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty2Column
            // 
            this.Qty2Column.Text = "x 2";
            this.Qty2Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty1Column
            // 
            this.Qty1Column.Text = "x 1";
            this.Qty1Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total
            // 
            this.Total.Text = "Общо";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SessionView
            // 
            this.SessionView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionView.BackColor = System.Drawing.Color.LightCyan;
            this.SessionView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumn,
            this.DateColumn,
            this.CategoryColumn,
            this.AimColumn,
            this.AmountColumn,
            this.OwnerColumn,
            this.NoteColumn});
            this.SessionView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionView.FullRowSelect = true;
            this.SessionView.GridLines = true;
            this.SessionView.Location = new System.Drawing.Point(32, 115);
            this.SessionView.Name = "SessionView";
            this.SessionView.Size = new System.Drawing.Size(726, 330);
            this.SessionView.TabIndex = 4;
            this.SessionView.UseCompatibleStateImageBehavior = false;
            this.SessionView.View = System.Windows.Forms.View.Details;
            // 
            // NumberColumn
            // 
            this.NumberColumn.Text = "№";
            this.NumberColumn.Width = 43;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "За Дата";
            this.DateColumn.Width = 110;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.Text = "Категория";
            this.CategoryColumn.Width = 100;
            // 
            // AimColumn
            // 
            this.AimColumn.Text = "Цел";
            this.AimColumn.Width = 100;
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "Сума";
            // 
            // OwnerColumn
            // 
            this.OwnerColumn.Text = "От Компютър";
            this.OwnerColumn.Width = 100;
            // 
            // NoteColumn
            // 
            this.NoteColumn.Text = "Бележка";
            this.NoteColumn.Width = 200;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(139, 64);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // NextDateBtn
            // 
            this.NextDateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextDateBtn.BackgroundImage")));
            this.NextDateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextDateBtn.Location = new System.Drawing.Point(304, 48);
            this.NextDateBtn.Name = "NextDateBtn";
            this.NextDateBtn.Size = new System.Drawing.Size(43, 44);
            this.NextDateBtn.TabIndex = 33;
            this.NextDateBtn.UseVisualStyleBackColor = true;
            this.NextDateBtn.Click += new System.EventHandler(this.NextDateBtn_Click);
            // 
            // PreviusDateBtn
            // 
            this.PreviusDateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviusDateBtn.BackgroundImage")));
            this.PreviusDateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviusDateBtn.Location = new System.Drawing.Point(78, 48);
            this.PreviusDateBtn.Name = "PreviusDateBtn";
            this.PreviusDateBtn.Size = new System.Drawing.Size(43, 44);
            this.PreviusDateBtn.TabIndex = 34;
            this.PreviusDateBtn.UseVisualStyleBackColor = true;
            this.PreviusDateBtn.Click += new System.EventHandler(this.PreviusDateBtn_Click);
            // 
            // ThisComputerCheckBox
            // 
            this.ThisComputerCheckBox.AutoSize = true;
            this.ThisComputerCheckBox.Location = new System.Drawing.Point(395, 77);
            this.ThisComputerCheckBox.Name = "ThisComputerCheckBox";
            this.ThisComputerCheckBox.Size = new System.Drawing.Size(190, 17);
            this.ThisComputerCheckBox.TabIndex = 35;
            this.ThisComputerCheckBox.Text = "Покажи само от този компютър";
            this.ThisComputerCheckBox.UseVisualStyleBackColor = true;
            this.ThisComputerCheckBox.CheckedChanged += new System.EventHandler(this.ThisComputerCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Дата на сесия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Каса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Днес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Тук";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThisComputerCheckBox);
            this.Controls.Add(this.PreviusDateBtn);
            this.Controls.Add(this.NextDateBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.SessionView);
            this.Controls.Add(this.CashDeskListView);
            this.Controls.Add(this.OpenMoneyFormBtn);
            this.Controls.Add(this.OpenSearchForm);
            this.Name = "Menu";
            this.Text = "Money Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenSearchForm;
        private System.Windows.Forms.Button OpenMoneyFormBtn;
        private System.Windows.Forms.ListView CashDeskListView;
        private System.Windows.Forms.ListView SessionView;
        private System.Windows.Forms.ColumnHeader Qty100Column;
        private System.Windows.Forms.ColumnHeader Qty50Column;
        private System.Windows.Forms.ColumnHeader Qty20Column;
        private System.Windows.Forms.ColumnHeader Qty10Column;
        private System.Windows.Forms.ColumnHeader Qty5Column;
        private System.Windows.Forms.ColumnHeader Qty2Column;
        private System.Windows.Forms.ColumnHeader Qty1Column;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader NumberColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader CategoryColumn;
        private System.Windows.Forms.ColumnHeader AimColumn;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.ColumnHeader OwnerColumn;
        private System.Windows.Forms.ColumnHeader NoteColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button NextDateBtn;
        private System.Windows.Forms.Button PreviusDateBtn;
        private System.Windows.Forms.CheckBox ThisComputerCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

