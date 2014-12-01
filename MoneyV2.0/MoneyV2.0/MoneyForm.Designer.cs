using MoneyV2._0.Interfaces;

namespace MoneyV2._0
{
    partial class MoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyForm));
            this.AmountLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AimComboBox = new System.Windows.Forms.ComboBox();
            this.BanknotiAmountTB = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AimLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.MoneyFormSaveBtn = new System.Windows.Forms.Button();
            this.Qty100TB = new System.Windows.Forms.TextBox();
            this.Qty50TB = new System.Windows.Forms.TextBox();
            this.Qty20TB = new System.Windows.Forms.TextBox();
            this.Qty10TB = new System.Windows.Forms.TextBox();
            this.Qty5TB = new System.Windows.Forms.TextBox();
            this.Qty2TB = new System.Windows.Forms.TextBox();
            this.Qty1TB = new System.Windows.Forms.TextBox();
            this.Qty100Label = new System.Windows.Forms.Label();
            this.Qty50Label = new System.Windows.Forms.Label();
            this.Qty20Label = new System.Windows.Forms.Label();
            this.Qty10Label = new System.Windows.Forms.Label();
            this.Qty5Label = new System.Windows.Forms.Label();
            this.Qty2Label = new System.Windows.Forms.Label();
            this.Qty1Label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NextDateBtn = new System.Windows.Forms.Button();
            this.PreviusDateBtn = new System.Windows.Forms.Button();
            this.AdditiveListView = new System.Windows.Forms.ListView();
            this.CategoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AimColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdditiveAmountLabel = new System.Windows.Forms.Label();
            this.AdditiveAmountTB = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.AdditiveOutcomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(577, 226);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(77, 13);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "По банкноти :";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(44, 187);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(70, 13);
            this.NoteLabel.TabIndex = 3;
            this.NoteLabel.Text = "Забележка :";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(108, 87);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 0;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // AimComboBox
            // 
            this.AimComboBox.FormattingEnabled = true;
            this.AimComboBox.Location = new System.Drawing.Point(108, 137);
            this.AimComboBox.Name = "AimComboBox";
            this.AimComboBox.Size = new System.Drawing.Size(121, 21);
            this.AimComboBox.TabIndex = 1;
            this.AimComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // BanknotiAmountTB
            // 
            this.BanknotiAmountTB.Location = new System.Drawing.Point(660, 223);
            this.BanknotiAmountTB.Name = "BanknotiAmountTB";
            this.BanknotiAmountTB.ReadOnly = true;
            this.BanknotiAmountTB.Size = new System.Drawing.Size(76, 20);
            this.BanknotiAmountTB.TabIndex = 10;
            this.BanknotiAmountTB.TabStop = false;
            this.BanknotiAmountTB.Text = "0";
            this.BanknotiAmountTB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.BanknotiAmountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(36, 90);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(66, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Категория :";
            // 
            // AimLabel
            // 
            this.AimLabel.AutoSize = true;
            this.AimLabel.Location = new System.Drawing.Point(69, 139);
            this.AimLabel.Name = "AimLabel";
            this.AimLabel.Size = new System.Drawing.Size(33, 13);
            this.AimLabel.TabIndex = 9;
            this.AimLabel.Text = "Цел :";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(48, 203);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(253, 143);
            this.NoteTextBox.TabIndex = 50;
            this.NoteTextBox.TabStop = false;
            this.NoteTextBox.Text = "";
            // 
            // MoneyFormSaveBtn
            // 
            this.MoneyFormSaveBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.MoneyFormSaveBtn.Location = new System.Drawing.Point(678, 362);
            this.MoneyFormSaveBtn.Name = "MoneyFormSaveBtn";
            this.MoneyFormSaveBtn.Size = new System.Drawing.Size(76, 54);
            this.MoneyFormSaveBtn.TabIndex = 11;
            this.MoneyFormSaveBtn.Text = "Запис";
            this.MoneyFormSaveBtn.UseVisualStyleBackColor = false;
            this.MoneyFormSaveBtn.Click += new System.EventHandler(this.MoneyFormSaveBtn_Click);
            // 
            // Qty100TB
            // 
            this.Qty100TB.Location = new System.Drawing.Point(660, 30);
            this.Qty100TB.Name = "Qty100TB";
            this.Qty100TB.Size = new System.Drawing.Size(35, 20);
            this.Qty100TB.TabIndex = 3;
            this.Qty100TB.Text = "0";
            this.Qty100TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty100TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty50TB
            // 
            this.Qty50TB.Location = new System.Drawing.Point(660, 57);
            this.Qty50TB.Name = "Qty50TB";
            this.Qty50TB.Size = new System.Drawing.Size(35, 20);
            this.Qty50TB.TabIndex = 4;
            this.Qty50TB.Text = "0";
            this.Qty50TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty50TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty20TB
            // 
            this.Qty20TB.Location = new System.Drawing.Point(660, 84);
            this.Qty20TB.Name = "Qty20TB";
            this.Qty20TB.Size = new System.Drawing.Size(35, 20);
            this.Qty20TB.TabIndex = 5;
            this.Qty20TB.Text = "0";
            this.Qty20TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty20TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty10TB
            // 
            this.Qty10TB.Location = new System.Drawing.Point(660, 110);
            this.Qty10TB.Name = "Qty10TB";
            this.Qty10TB.Size = new System.Drawing.Size(35, 20);
            this.Qty10TB.TabIndex = 6;
            this.Qty10TB.Text = "0";
            this.Qty10TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty10TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty5TB
            // 
            this.Qty5TB.Location = new System.Drawing.Point(660, 136);
            this.Qty5TB.Name = "Qty5TB";
            this.Qty5TB.Size = new System.Drawing.Size(35, 20);
            this.Qty5TB.TabIndex = 7;
            this.Qty5TB.Text = "0";
            this.Qty5TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty5TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty2TB
            // 
            this.Qty2TB.Location = new System.Drawing.Point(660, 162);
            this.Qty2TB.Name = "Qty2TB";
            this.Qty2TB.Size = new System.Drawing.Size(35, 20);
            this.Qty2TB.TabIndex = 8;
            this.Qty2TB.Text = "0";
            this.Qty2TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty2TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty1TB
            // 
            this.Qty1TB.Location = new System.Drawing.Point(660, 188);
            this.Qty1TB.Name = "Qty1TB";
            this.Qty1TB.Size = new System.Drawing.Size(35, 20);
            this.Qty1TB.TabIndex = 9;
            this.Qty1TB.Text = "0";
            this.Qty1TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty1TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty100Label
            // 
            this.Qty100Label.AutoSize = true;
            this.Qty100Label.Location = new System.Drawing.Point(701, 35);
            this.Qty100Label.Name = "Qty100Label";
            this.Qty100Label.Size = new System.Drawing.Size(33, 13);
            this.Qty100Label.TabIndex = 22;
            this.Qty100Label.Text = "x 100";
            // 
            // Qty50Label
            // 
            this.Qty50Label.AutoSize = true;
            this.Qty50Label.Location = new System.Drawing.Point(701, 60);
            this.Qty50Label.Name = "Qty50Label";
            this.Qty50Label.Size = new System.Drawing.Size(27, 13);
            this.Qty50Label.TabIndex = 23;
            this.Qty50Label.Text = "x 50";
            // 
            // Qty20Label
            // 
            this.Qty20Label.AutoSize = true;
            this.Qty20Label.Location = new System.Drawing.Point(701, 87);
            this.Qty20Label.Name = "Qty20Label";
            this.Qty20Label.Size = new System.Drawing.Size(27, 13);
            this.Qty20Label.TabIndex = 24;
            this.Qty20Label.Text = "x 20";
            // 
            // Qty10Label
            // 
            this.Qty10Label.AutoSize = true;
            this.Qty10Label.Location = new System.Drawing.Point(701, 113);
            this.Qty10Label.Name = "Qty10Label";
            this.Qty10Label.Size = new System.Drawing.Size(27, 13);
            this.Qty10Label.TabIndex = 25;
            this.Qty10Label.Text = "x 10";
            // 
            // Qty5Label
            // 
            this.Qty5Label.AutoSize = true;
            this.Qty5Label.Location = new System.Drawing.Point(701, 139);
            this.Qty5Label.Name = "Qty5Label";
            this.Qty5Label.Size = new System.Drawing.Size(21, 13);
            this.Qty5Label.TabIndex = 26;
            this.Qty5Label.Text = "x 5";
            // 
            // Qty2Label
            // 
            this.Qty2Label.AutoSize = true;
            this.Qty2Label.Location = new System.Drawing.Point(701, 165);
            this.Qty2Label.Name = "Qty2Label";
            this.Qty2Label.Size = new System.Drawing.Size(21, 13);
            this.Qty2Label.TabIndex = 27;
            this.Qty2Label.Text = "x 2";
            // 
            // Qty1Label
            // 
            this.Qty1Label.AutoSize = true;
            this.Qty1Label.Location = new System.Drawing.Point(701, 191);
            this.Qty1Label.Name = "Qty1Label";
            this.Qty1Label.Size = new System.Drawing.Size(21, 13);
            this.Qty1Label.TabIndex = 28;
            this.Qty1Label.Text = "x 1";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(108, 35);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker.TabIndex = 20;
            this.dateTimePicker.TabStop = false;
            // 
            // NextDateBtn
            // 
            this.NextDateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextDateBtn.BackgroundImage")));
            this.NextDateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextDateBtn.Location = new System.Drawing.Point(282, 28);
            this.NextDateBtn.Name = "NextDateBtn";
            this.NextDateBtn.Size = new System.Drawing.Size(30, 31);
            this.NextDateBtn.TabIndex = 32;
            this.NextDateBtn.UseVisualStyleBackColor = true;
            this.NextDateBtn.Click += new System.EventHandler(this.NextDateBtn_Click);
            // 
            // PreviusDateBtn
            // 
            this.PreviusDateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviusDateBtn.BackgroundImage")));
            this.PreviusDateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviusDateBtn.Location = new System.Drawing.Point(57, 28);
            this.PreviusDateBtn.Name = "PreviusDateBtn";
            this.PreviusDateBtn.Size = new System.Drawing.Size(30, 31);
            this.PreviusDateBtn.TabIndex = 33;
            this.PreviusDateBtn.UseVisualStyleBackColor = true;
            this.PreviusDateBtn.Click += new System.EventHandler(this.PreviusDateBtn_Click);
            // 
            // AdditiveListView
            // 
            this.AdditiveListView.BackColor = System.Drawing.Color.LightCyan;
            this.AdditiveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryColumn,
            this.AimColumn,
            this.AmountColumn});
            this.AdditiveListView.Location = new System.Drawing.Point(319, 57);
            this.AdditiveListView.Name = "AdditiveListView";
            this.AdditiveListView.Size = new System.Drawing.Size(207, 236);
            this.AdditiveListView.TabIndex = 51;
            this.AdditiveListView.UseCompatibleStateImageBehavior = false;
            this.AdditiveListView.View = System.Windows.Forms.View.Details;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.Text = "Вид";
            this.CategoryColumn.Width = 80;
            // 
            // AimColumn
            // 
            this.AimColumn.Text = "Цел";
            this.AimColumn.Width = 80;
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "Сума";
            this.AmountColumn.Width = 40;
            // 
            // AdditiveAmountLabel
            // 
            this.AdditiveAmountLabel.AutoSize = true;
            this.AdditiveAmountLabel.Location = new System.Drawing.Point(538, 262);
            this.AdditiveAmountLabel.Name = "AdditiveAmountLabel";
            this.AdditiveAmountLabel.Size = new System.Drawing.Size(116, 13);
            this.AdditiveAmountLabel.TabIndex = 52;
            this.AdditiveAmountLabel.Text = "Допълнителна сума :";
            // 
            // AdditiveAmountTB
            // 
            this.AdditiveAmountTB.Location = new System.Drawing.Point(662, 259);
            this.AdditiveAmountTB.Name = "AdditiveAmountTB";
            this.AdditiveAmountTB.ReadOnly = true;
            this.AdditiveAmountTB.Size = new System.Drawing.Size(74, 20);
            this.AdditiveAmountTB.TabIndex = 53;
            this.AdditiveAmountTB.TabStop = false;
            this.AdditiveAmountTB.Text = "0";
            this.AdditiveAmountTB.TextChanged += new System.EventHandler(this.AdditiveAmountTB_TextChanged);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(614, 304);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(42, 13);
            this.TotalLabel.TabIndex = 54;
            this.TotalLabel.Text = "Общо :";
            // 
            // TotalTB
            // 
            this.TotalTB.Location = new System.Drawing.Point(662, 301);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.ReadOnly = true;
            this.TotalTB.Size = new System.Drawing.Size(74, 20);
            this.TotalTB.TabIndex = 55;
            this.TotalTB.TabStop = false;
            this.TotalTB.Text = "0";
            // 
            // AdditiveOutcomeBtn
            // 
            this.AdditiveOutcomeBtn.Location = new System.Drawing.Point(319, 296);
            this.AdditiveOutcomeBtn.Name = "AdditiveOutcomeBtn";
            this.AdditiveOutcomeBtn.Size = new System.Drawing.Size(207, 50);
            this.AdditiveOutcomeBtn.TabIndex = 56;
            this.AdditiveOutcomeBtn.Text = "Допълнителна сума";
            this.AdditiveOutcomeBtn.UseVisualStyleBackColor = true;
            this.AdditiveOutcomeBtn.Click += new System.EventHandler(this.AdditiveOutcomeBtn_Click);
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 440);
            this.Controls.Add(this.AdditiveOutcomeBtn);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AdditiveAmountTB);
            this.Controls.Add(this.AdditiveAmountLabel);
            this.Controls.Add(this.AdditiveListView);
            this.Controls.Add(this.PreviusDateBtn);
            this.Controls.Add(this.NextDateBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Qty1Label);
            this.Controls.Add(this.Qty2Label);
            this.Controls.Add(this.Qty5Label);
            this.Controls.Add(this.Qty10Label);
            this.Controls.Add(this.Qty20Label);
            this.Controls.Add(this.Qty50Label);
            this.Controls.Add(this.Qty100Label);
            this.Controls.Add(this.Qty1TB);
            this.Controls.Add(this.Qty2TB);
            this.Controls.Add(this.Qty5TB);
            this.Controls.Add(this.Qty10TB);
            this.Controls.Add(this.Qty20TB);
            this.Controls.Add(this.Qty50TB);
            this.Controls.Add(this.Qty100TB);
            this.Controls.Add(this.MoneyFormSaveBtn);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.AimLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.BanknotiAmountTB);
            this.Controls.Add(this.AimComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.AmountLabel);
            this.Name = "MoneyForm";
            this.Text = "Приход/Разход";
            this.Load += new System.EventHandler(this.MoneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox AimComboBox;
        private System.Windows.Forms.TextBox BanknotiAmountTB;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AimLabel;
        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.Button MoneyFormSaveBtn;
        private System.Windows.Forms.TextBox Qty100TB;
        private System.Windows.Forms.TextBox Qty50TB;
        private System.Windows.Forms.TextBox Qty20TB;
        private System.Windows.Forms.TextBox Qty10TB;
        private System.Windows.Forms.TextBox Qty5TB;
        private System.Windows.Forms.TextBox Qty2TB;
        private System.Windows.Forms.TextBox Qty1TB;
        private System.Windows.Forms.Label Qty100Label;
        private System.Windows.Forms.Label Qty50Label;
        private System.Windows.Forms.Label Qty20Label;
        private System.Windows.Forms.Label Qty10Label;
        private System.Windows.Forms.Label Qty5Label;
        private System.Windows.Forms.Label Qty2Label;
        private System.Windows.Forms.Label Qty1Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button NextDateBtn;
        private System.Windows.Forms.Button PreviusDateBtn;
        private System.Windows.Forms.ColumnHeader CategoryColumn;
        private System.Windows.Forms.ColumnHeader AimColumn;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.Label AdditiveAmountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Button AdditiveOutcomeBtn;
        public System.Windows.Forms.ListView AdditiveListView;
        public System.Windows.Forms.TextBox AdditiveAmountTB;
    }
}