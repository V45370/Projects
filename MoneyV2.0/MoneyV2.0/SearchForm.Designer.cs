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
            this.SearchListView = new System.Windows.Forms.ListView();
            this.numberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aimColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ownerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.AimCheckBox = new System.Windows.Forms.CheckBox();
            this.AmountCheckBox = new System.Windows.Forms.CheckBox();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromAmountTB = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToAmountTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AimCB = new System.Windows.Forms.ComboBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchListView
            // 
            this.SearchListView.BackColor = System.Drawing.Color.LightCyan;
            this.SearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberColumn,
            this.dateColumn,
            this.categoryColumn,
            this.aimColumn,
            this.amountColumn,
            this.ownerColumn,
            this.noteColumn});
            this.SearchListView.Location = new System.Drawing.Point(12, 139);
            this.SearchListView.Name = "SearchListView";
            this.SearchListView.Size = new System.Drawing.Size(809, 356);
            this.SearchListView.TabIndex = 14;
            this.SearchListView.UseCompatibleStateImageBehavior = false;
            this.SearchListView.View = System.Windows.Forms.View.Details;
            // 
            // numberColumn
            // 
            this.numberColumn.Text = "№";
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "За Дата";
            this.dateColumn.Width = 92;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Категория";
            this.categoryColumn.Width = 121;
            // 
            // aimColumn
            // 
            this.aimColumn.Text = "Цел";
            this.aimColumn.Width = 97;
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Сума";
            this.amountColumn.Width = 73;
            // 
            // ownerColumn
            // 
            this.ownerColumn.Text = "От Компютър";
            this.ownerColumn.Width = 113;
            // 
            // noteColumn
            // 
            this.noteColumn.Text = "Бележка";
            this.noteColumn.Width = 224;
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Location = new System.Drawing.Point(93, 24);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(64, 17);
            this.DateCheckBox.TabIndex = 10;
            this.DateCheckBox.Text = "Период";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            this.DateCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // CategoryCheckBox
            // 
            this.CategoryCheckBox.AutoSize = true;
            this.CategoryCheckBox.Location = new System.Drawing.Point(275, 24);
            this.CategoryCheckBox.Name = "CategoryCheckBox";
            this.CategoryCheckBox.Size = new System.Drawing.Size(79, 17);
            this.CategoryCheckBox.TabIndex = 11;
            this.CategoryCheckBox.Text = "Категория";
            this.CategoryCheckBox.UseVisualStyleBackColor = true;
            this.CategoryCheckBox.CheckedChanged += new System.EventHandler(this.CategoryCheckBox_CheckedChanged);
            this.CategoryCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // AimCheckBox
            // 
            this.AimCheckBox.AutoSize = true;
            this.AimCheckBox.Location = new System.Drawing.Point(438, 24);
            this.AimCheckBox.Name = "AimCheckBox";
            this.AimCheckBox.Size = new System.Drawing.Size(46, 17);
            this.AimCheckBox.TabIndex = 12;
            this.AimCheckBox.Text = "Цел";
            this.AimCheckBox.UseVisualStyleBackColor = true;
            this.AimCheckBox.CheckedChanged += new System.EventHandler(this.AimCheckBox_CheckedChanged);
            this.AimCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // AmountCheckBox
            // 
            this.AmountCheckBox.AutoSize = true;
            this.AmountCheckBox.Location = new System.Drawing.Point(596, 24);
            this.AmountCheckBox.Name = "AmountCheckBox";
            this.AmountCheckBox.Size = new System.Drawing.Size(52, 17);
            this.AmountCheckBox.TabIndex = 13;
            this.AmountCheckBox.Text = "Сума";
            this.AmountCheckBox.UseVisualStyleBackColor = true;
            this.AmountCheckBox.CheckedChanged += new System.EventHandler(this.AmountCheckBox_CheckedChanged);
            this.AmountCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Enabled = false;
            this.FromDateTimePicker.Location = new System.Drawing.Point(68, 59);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.FromDateTimePicker.TabIndex = 6;
            this.FromDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // FromAmountTB
            // 
            this.FromAmountTB.Enabled = false;
            this.FromAmountTB.Location = new System.Drawing.Point(589, 59);
            this.FromAmountTB.Name = "FromAmountTB";
            this.FromAmountTB.Size = new System.Drawing.Size(59, 20);
            this.FromAmountTB.TabIndex = 3;
            this.FromAmountTB.Text = "0";
            this.FromAmountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(696, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(87, 55);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Търси";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            this.SearchBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Enabled = false;
            this.ToDateTimePicker.Location = new System.Drawing.Point(68, 101);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.ToDateTimePicker.TabIndex = 7;
            this.ToDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // ToAmountTB
            // 
            this.ToAmountTB.Enabled = false;
            this.ToAmountTB.Location = new System.Drawing.Point(589, 99);
            this.ToAmountTB.Name = "ToAmountTB";
            this.ToAmountTB.Size = new System.Drawing.Size(59, 20);
            this.ToAmountTB.TabIndex = 4;
            this.ToAmountTB.Text = "0";
            this.ToAmountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "от";
            // 
            // AimCB
            // 
            this.AimCB.Enabled = false;
            this.AimCB.FormattingEnabled = true;
            this.AimCB.Location = new System.Drawing.Point(415, 59);
            this.AimCB.Name = "AimCB";
            this.AimCB.Size = new System.Drawing.Size(97, 21);
            this.AimCB.TabIndex = 2;
            this.AimCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // CategoryCB
            // 
            this.CategoryCB.Enabled = false;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(258, 59);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(108, 21);
            this.CategoryCB.TabIndex = 1;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            this.CategoryCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.CloseBtn.Location = new System.Drawing.Point(849, 437);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(85, 58);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Затвори";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 518);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AimCB);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToAmountTB);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.FromAmountTB);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.AmountCheckBox);
            this.Controls.Add(this.AimCheckBox);
            this.Controls.Add(this.CategoryCheckBox);
            this.Controls.Add(this.DateCheckBox);
            this.Controls.Add(this.SearchListView);
            this.Name = "SearchForm";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SearchListView;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.CheckBox CategoryCheckBox;
        private System.Windows.Forms.CheckBox AimCheckBox;
        private System.Windows.Forms.CheckBox AmountCheckBox;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.TextBox FromAmountTB;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.TextBox ToAmountTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AimCB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ColumnHeader numberColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader aimColumn;
        private System.Windows.Forms.ColumnHeader amountColumn;
        private System.Windows.Forms.ColumnHeader ownerColumn;
        private System.Windows.Forms.ColumnHeader noteColumn;

        
    }
}