﻿namespace Vize_Odev_1
{
    partial class EmanetVerme
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
            label1 = new Label();
            label2 = new Label();
            emanetIslemleriUyeNoTextBox = new TextBox();
            emanetIslmeleriKitapNoTextBox = new TextBox();
            emanetIslemleriEmanetAlButton = new Button();
            emanetVermeDataGridView = new DataGridView();
            emanetIslemleriDosyayaKaydetButton = new Button();
            emanetIslemleriDuzenlemeButton = new Button();
            emanetVermeSilButton = new Button();
            ((System.ComponentModel.ISupportInitialize)emanetVermeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 83);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Uye No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 35);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap No";
            // 
            // emanetIslemleriUyeNoTextBox
            // 
            emanetIslemleriUyeNoTextBox.Location = new Point(146, 80);
            emanetIslemleriUyeNoTextBox.Name = "emanetIslemleriUyeNoTextBox";
            emanetIslemleriUyeNoTextBox.Size = new Size(197, 27);
            emanetIslemleriUyeNoTextBox.TabIndex = 2;
            // 
            // emanetIslmeleriKitapNoTextBox
            // 
            emanetIslmeleriKitapNoTextBox.Location = new Point(146, 35);
            emanetIslmeleriKitapNoTextBox.Name = "emanetIslmeleriKitapNoTextBox";
            emanetIslmeleriKitapNoTextBox.Size = new Size(197, 27);
            emanetIslmeleriKitapNoTextBox.TabIndex = 1;
            // 
            // emanetIslemleriEmanetAlButton
            // 
            emanetIslemleriEmanetAlButton.Location = new Point(81, 180);
            emanetIslemleriEmanetAlButton.Name = "emanetIslemleriEmanetAlButton";
            emanetIslemleriEmanetAlButton.Size = new Size(152, 51);
            emanetIslemleriEmanetAlButton.TabIndex = 3;
            emanetIslemleriEmanetAlButton.Text = "Emanet Al";
            emanetIslemleriEmanetAlButton.UseVisualStyleBackColor = true;
            emanetIslemleriEmanetAlButton.Click += emanetIslemleriEmanetAlButton_Click;
            // 
            // emanetVermeDataGridView
            // 
            emanetVermeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emanetVermeDataGridView.Location = new Point(419, 47);
            emanetVermeDataGridView.Name = "emanetVermeDataGridView";
            emanetVermeDataGridView.RowHeadersWidth = 51;
            emanetVermeDataGridView.Size = new Size(370, 318);
            emanetVermeDataGridView.TabIndex = 5;
            emanetVermeDataGridView.SelectionChanged += emanetVermeDataGridView_SelectionChanged;
            // 
            // emanetIslemleriDosyayaKaydetButton
            // 
            emanetIslemleriDosyayaKaydetButton.Location = new Point(239, 180);
            emanetIslemleriDosyayaKaydetButton.Name = "emanetIslemleriDosyayaKaydetButton";
            emanetIslemleriDosyayaKaydetButton.Size = new Size(152, 51);
            emanetIslemleriDosyayaKaydetButton.TabIndex = 4;
            emanetIslemleriDosyayaKaydetButton.Text = "Dosyaya Kaydet";
            emanetIslemleriDosyayaKaydetButton.UseVisualStyleBackColor = true;
            emanetIslemleriDosyayaKaydetButton.Click += emanetIslemleriDosyayaKaydetButton_Click;
            // 
            // emanetIslemleriDuzenlemeButton
            // 
            emanetIslemleriDuzenlemeButton.Location = new Point(81, 248);
            emanetIslemleriDuzenlemeButton.Name = "emanetIslemleriDuzenlemeButton";
            emanetIslemleriDuzenlemeButton.Size = new Size(152, 51);
            emanetIslemleriDuzenlemeButton.TabIndex = 5;
            emanetIslemleriDuzenlemeButton.Text = "Düzenleme";
            emanetIslemleriDuzenlemeButton.UseVisualStyleBackColor = true;
            emanetIslemleriDuzenlemeButton.Click += emanetIslemleriDuzenlemeButton_Click;
            // 
            // emanetVermeSilButton
            // 
            emanetVermeSilButton.Location = new Point(242, 248);
            emanetVermeSilButton.Name = "emanetVermeSilButton";
            emanetVermeSilButton.Size = new Size(149, 51);
            emanetVermeSilButton.TabIndex = 10;
            emanetVermeSilButton.Text = "Sil";
            emanetVermeSilButton.UseVisualStyleBackColor = true;
            emanetVermeSilButton.Click += emanetVermeSilButton_Click;
            // 
            // EmanetVerme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 403);
            Controls.Add(emanetVermeSilButton);
            Controls.Add(emanetIslemleriDuzenlemeButton);
            Controls.Add(emanetIslemleriDosyayaKaydetButton);
            Controls.Add(emanetVermeDataGridView);
            Controls.Add(emanetIslemleriEmanetAlButton);
            Controls.Add(emanetIslmeleriKitapNoTextBox);
            Controls.Add(emanetIslemleriUyeNoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmanetVerme";
            Text = "EmanetIslemeleri";
            ((System.ComponentModel.ISupportInitialize)emanetVermeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emanetIslemleriUyeNoTextBox;
        private TextBox emanetIslmeleriKitapNoTextBox;
        private Button emanetIslemleriEmanetAlButton;
        private DataGridView emanetVermeDataGridView;
        private Button emanetIslemleriDosyayaKaydetButton;
        private Button emanetIslemleriDuzenlemeButton;
        private Button emanetVermeSilButton;
    }
}