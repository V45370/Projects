﻿namespace MoneyV2._0
{
    partial class AdditiveOutcomeForm
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
            this.AimLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AimComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.MoneyFormSaveBtn = new System.Windows.Forms.Button();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AimLabel
            // 
            this.AimLabel.AutoSize = true;
            this.AimLabel.Location = new System.Drawing.Point(31, 84);
            this.AimLabel.Name = "AimLabel";
            this.AimLabel.Size = new System.Drawing.Size(33, 13);
            this.AimLabel.TabIndex = 13;
            this.AimLabel.Text = "Цел :";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(32, 34);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(32, 13);
            this.CategoryLabel.TabIndex = 12;
            this.CategoryLabel.Text = "Вид :";
            // 
            // AimComboBox
            // 
            this.AimComboBox.FormattingEnabled = true;
            this.AimComboBox.Location = new System.Drawing.Point(95, 81);
            this.AimComboBox.Name = "AimComboBox";
            this.AimComboBox.Size = new System.Drawing.Size(121, 21);
            this.AimComboBox.TabIndex = 11;
            this.AimComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(95, 31);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 10;
            this.CategoryComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // MoneyFormSaveBtn
            // 
            this.MoneyFormSaveBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.MoneyFormSaveBtn.Location = new System.Drawing.Point(258, 137);
            this.MoneyFormSaveBtn.Name = "MoneyFormSaveBtn";
            this.MoneyFormSaveBtn.Size = new System.Drawing.Size(76, 54);
            this.MoneyFormSaveBtn.TabIndex = 14;
            this.MoneyFormSaveBtn.Text = "Запис";
            this.MoneyFormSaveBtn.UseVisualStyleBackColor = false;
            this.MoneyFormSaveBtn.Click += new System.EventHandler(this.MoneyFormSaveBtn_Click);
            this.MoneyFormSaveBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(95, 137);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(92, 20);
            this.AmountTB.TabIndex = 15;
            this.AmountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Сума :";
            // 
            // AdditiveOutcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.MoneyFormSaveBtn);
            this.Controls.Add(this.AimLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.AimComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Name = "AdditiveOutcomeForm";
            this.Text = "Допълнителна сума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AimLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox AimComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button MoneyFormSaveBtn;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label1;
    }
}