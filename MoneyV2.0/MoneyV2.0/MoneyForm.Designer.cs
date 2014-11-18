﻿using MoneyV2._0.Interfaces;

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
            this.OutcomeAmount = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AimComboBox = new System.Windows.Forms.ComboBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
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
            this.dateTimePickerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutcomeAmount
            // 
            this.OutcomeAmount.AutoSize = true;
            this.OutcomeAmount.Location = new System.Drawing.Point(88, 237);
            this.OutcomeAmount.Name = "OutcomeAmount";
            this.OutcomeAmount.Size = new System.Drawing.Size(89, 13);
            this.OutcomeAmount.TabIndex = 2;
            this.OutcomeAmount.Text = "Разходна сума :";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(233, 224);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(70, 13);
            this.NoteLabel.TabIndex = 3;
            this.NoteLabel.Text = "Забележка :";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(309, 108);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 8;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // AimComboBox
            // 
            this.AimComboBox.FormattingEnabled = true;
            this.AimComboBox.Location = new System.Drawing.Point(309, 155);
            this.AimComboBox.Name = "AimComboBox";
            this.AimComboBox.Size = new System.Drawing.Size(121, 21);
            this.AimComboBox.TabIndex = 9;
            this.AimComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(91, 253);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.ReadOnly = true;
            this.AmountTB.Size = new System.Drawing.Size(100, 20);
            this.AmountTB.TabIndex = 6;
            this.AmountTB.TabStop = false;
            this.AmountTB.Text = "0";
            this.AmountTB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.AmountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(271, 111);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(32, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Вид :";
            // 
            // AimLabel
            // 
            this.AimLabel.AutoSize = true;
            this.AimLabel.Location = new System.Drawing.Point(232, 158);
            this.AimLabel.Name = "AimLabel";
            this.AimLabel.Size = new System.Drawing.Size(71, 13);
            this.AimLabel.TabIndex = 9;
            this.AimLabel.Text = "Крайна цел :";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(318, 224);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(228, 92);
            this.NoteTextBox.TabIndex = 10;
            this.NoteTextBox.TabStop = false;
            this.NoteTextBox.Text = "";
            // 
            // MoneyFormSaveBtn
            // 
            this.MoneyFormSaveBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.MoneyFormSaveBtn.Location = new System.Drawing.Point(470, 322);
            this.MoneyFormSaveBtn.Name = "MoneyFormSaveBtn";
            this.MoneyFormSaveBtn.Size = new System.Drawing.Size(76, 54);
            this.MoneyFormSaveBtn.TabIndex = 10;
            this.MoneyFormSaveBtn.Text = "Запис";
            this.MoneyFormSaveBtn.UseVisualStyleBackColor = false;
            this.MoneyFormSaveBtn.Click += new System.EventHandler(this.MoneyFormSaveBtn_Click);
            // 
            // Qty100TB
            // 
            this.Qty100TB.Location = new System.Drawing.Point(89, 25);
            this.Qty100TB.Name = "Qty100TB";
            this.Qty100TB.Size = new System.Drawing.Size(75, 20);
            this.Qty100TB.TabIndex = 0;
            this.Qty100TB.Text = "0";
            this.Qty100TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty100TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty50TB
            // 
            this.Qty50TB.Location = new System.Drawing.Point(89, 52);
            this.Qty50TB.Name = "Qty50TB";
            this.Qty50TB.Size = new System.Drawing.Size(75, 20);
            this.Qty50TB.TabIndex = 1;
            this.Qty50TB.Text = "0";
            this.Qty50TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty50TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty20TB
            // 
            this.Qty20TB.Location = new System.Drawing.Point(89, 79);
            this.Qty20TB.Name = "Qty20TB";
            this.Qty20TB.Size = new System.Drawing.Size(75, 20);
            this.Qty20TB.TabIndex = 2;
            this.Qty20TB.Text = "0";
            this.Qty20TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty20TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty10TB
            // 
            this.Qty10TB.Location = new System.Drawing.Point(89, 105);
            this.Qty10TB.Name = "Qty10TB";
            this.Qty10TB.Size = new System.Drawing.Size(75, 20);
            this.Qty10TB.TabIndex = 3;
            this.Qty10TB.Text = "0";
            this.Qty10TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty10TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty5TB
            // 
            this.Qty5TB.Location = new System.Drawing.Point(89, 131);
            this.Qty5TB.Name = "Qty5TB";
            this.Qty5TB.Size = new System.Drawing.Size(75, 20);
            this.Qty5TB.TabIndex = 4;
            this.Qty5TB.Text = "0";
            this.Qty5TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty5TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty2TB
            // 
            this.Qty2TB.Location = new System.Drawing.Point(89, 157);
            this.Qty2TB.Name = "Qty2TB";
            this.Qty2TB.Size = new System.Drawing.Size(75, 20);
            this.Qty2TB.TabIndex = 5;
            this.Qty2TB.Text = "0";
            this.Qty2TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty2TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty1TB
            // 
            this.Qty1TB.Location = new System.Drawing.Point(89, 183);
            this.Qty1TB.Name = "Qty1TB";
            this.Qty1TB.Size = new System.Drawing.Size(75, 20);
            this.Qty1TB.TabIndex = 6;
            this.Qty1TB.Text = "0";
            this.Qty1TB.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.Qty1TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // Qty100Label
            // 
            this.Qty100Label.AutoSize = true;
            this.Qty100Label.Location = new System.Drawing.Point(170, 30);
            this.Qty100Label.Name = "Qty100Label";
            this.Qty100Label.Size = new System.Drawing.Size(33, 13);
            this.Qty100Label.TabIndex = 22;
            this.Qty100Label.Text = "x 100";
            // 
            // Qty50Label
            // 
            this.Qty50Label.AutoSize = true;
            this.Qty50Label.Location = new System.Drawing.Point(170, 55);
            this.Qty50Label.Name = "Qty50Label";
            this.Qty50Label.Size = new System.Drawing.Size(27, 13);
            this.Qty50Label.TabIndex = 23;
            this.Qty50Label.Text = "x 50";
            // 
            // Qty20Label
            // 
            this.Qty20Label.AutoSize = true;
            this.Qty20Label.Location = new System.Drawing.Point(170, 82);
            this.Qty20Label.Name = "Qty20Label";
            this.Qty20Label.Size = new System.Drawing.Size(27, 13);
            this.Qty20Label.TabIndex = 24;
            this.Qty20Label.Text = "x 20";
            // 
            // Qty10Label
            // 
            this.Qty10Label.AutoSize = true;
            this.Qty10Label.Location = new System.Drawing.Point(170, 108);
            this.Qty10Label.Name = "Qty10Label";
            this.Qty10Label.Size = new System.Drawing.Size(27, 13);
            this.Qty10Label.TabIndex = 25;
            this.Qty10Label.Text = "x 10";
            // 
            // Qty5Label
            // 
            this.Qty5Label.AutoSize = true;
            this.Qty5Label.Location = new System.Drawing.Point(170, 134);
            this.Qty5Label.Name = "Qty5Label";
            this.Qty5Label.Size = new System.Drawing.Size(21, 13);
            this.Qty5Label.TabIndex = 26;
            this.Qty5Label.Text = "x 5";
            // 
            // Qty2Label
            // 
            this.Qty2Label.AutoSize = true;
            this.Qty2Label.Location = new System.Drawing.Point(170, 160);
            this.Qty2Label.Name = "Qty2Label";
            this.Qty2Label.Size = new System.Drawing.Size(21, 13);
            this.Qty2Label.TabIndex = 27;
            this.Qty2Label.Text = "x 2";
            // 
            // Qty1Label
            // 
            this.Qty1Label.AutoSize = true;
            this.Qty1Label.Location = new System.Drawing.Point(170, 186);
            this.Qty1Label.Name = "Qty1Label";
            this.Qty1Label.Size = new System.Drawing.Size(21, 13);
            this.Qty1Label.TabIndex = 28;
            this.Qty1Label.Text = "x 1";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(309, 55);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.TabStop = false;
            // 
            // dateTimePickerLabel
            // 
            this.dateTimePickerLabel.AutoSize = true;
            this.dateTimePickerLabel.Location = new System.Drawing.Point(264, 59);
            this.dateTimePickerLabel.Name = "dateTimePickerLabel";
            this.dateTimePickerLabel.Size = new System.Drawing.Size(39, 13);
            this.dateTimePickerLabel.TabIndex = 31;
            this.dateTimePickerLabel.Text = "Дата :";
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 388);
            this.Controls.Add(this.dateTimePickerLabel);
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
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.AimComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.OutcomeAmount);
            this.Name = "MoneyForm";
            this.Text = "Пари";
            this.Load += new System.EventHandler(this.MoneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutcomeAmount;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox AimComboBox;
        private System.Windows.Forms.TextBox AmountTB;
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
        private System.Windows.Forms.Label dateTimePickerLabel;
    }
}