﻿namespace Vize_Odev_1
{
    partial class UyeEkleme
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
            uyeEklemeUyeNoTextBox = new TextBox();
            uyeEklemeUyeSoyIsimTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            uyeEklemeUyeIsimTextBox = new TextBox();
            label1 = new Label();
            uyeEklemeDataGridView = new DataGridView();
            uyeEklemeEkleButton = new Button();
            uyeEklemeDosyayaKaydetButton = new Button();
            uyeEklemeDosyadanYukleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)uyeEklemeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // uyeEklemeUyeNoTextBox
            // 
            uyeEklemeUyeNoTextBox.Location = new Point(121, 131);
            uyeEklemeUyeNoTextBox.Name = "uyeEklemeUyeNoTextBox";
            uyeEklemeUyeNoTextBox.Size = new Size(228, 27);
            uyeEklemeUyeNoTextBox.TabIndex = 3;
            // 
            // uyeEklemeUyeSoyIsimTextBox
            // 
            uyeEklemeUyeSoyIsimTextBox.Location = new Point(121, 78);
            uyeEklemeUyeSoyIsimTextBox.Name = "uyeEklemeUyeSoyIsimTextBox";
            uyeEklemeUyeSoyIsimTextBox.Size = new Size(228, 27);
            uyeEklemeUyeSoyIsimTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 81);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "Uye Soyisim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 131);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Uye No";
            // 
            // uyeEklemeUyeIsimTextBox
            // 
            uyeEklemeUyeIsimTextBox.Location = new Point(121, 21);
            uyeEklemeUyeIsimTextBox.Name = "uyeEklemeUyeIsimTextBox";
            uyeEklemeUyeIsimTextBox.Size = new Size(228, 27);
            uyeEklemeUyeIsimTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Uye Isim";
            // 
            // uyeEklemeDataGridView
            // 
            uyeEklemeDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uyeEklemeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uyeEklemeDataGridView.Location = new Point(420, 36);
            uyeEklemeDataGridView.Name = "uyeEklemeDataGridView";
            uyeEklemeDataGridView.RowHeadersWidth = 51;
            uyeEklemeDataGridView.Size = new Size(436, 308);
            uyeEklemeDataGridView.TabIndex = 10;
            // 
            // uyeEklemeEkleButton
            // 
            uyeEklemeEkleButton.Location = new Point(129, 206);
            uyeEklemeEkleButton.Name = "uyeEklemeEkleButton";
            uyeEklemeEkleButton.Size = new Size(149, 43);
            uyeEklemeEkleButton.TabIndex = 4;
            uyeEklemeEkleButton.Text = "Ekle";
            uyeEklemeEkleButton.UseVisualStyleBackColor = true;
            uyeEklemeEkleButton.Click += uyeEklemeEkleButton_Click;
            // 
            // uyeEklemeDosyayaKaydetButton
            // 
            uyeEklemeDosyayaKaydetButton.Location = new Point(229, 280);
            uyeEklemeDosyayaKaydetButton.Name = "uyeEklemeDosyayaKaydetButton";
            uyeEklemeDosyayaKaydetButton.Size = new Size(149, 43);
            uyeEklemeDosyayaKaydetButton.TabIndex = 6;
            uyeEklemeDosyayaKaydetButton.Text = "Dosyaya Kaydet";
            uyeEklemeDosyayaKaydetButton.UseVisualStyleBackColor = true;
            uyeEklemeDosyayaKaydetButton.Click += uyeEklemeDosyayaKaydetButton_Click;
            // 
            // uyeEklemeDosyadanYukleButton
            // 
            uyeEklemeDosyadanYukleButton.Location = new Point(39, 279);
            uyeEklemeDosyadanYukleButton.Name = "uyeEklemeDosyadanYukleButton";
            uyeEklemeDosyadanYukleButton.Size = new Size(149, 43);
            uyeEklemeDosyadanYukleButton.TabIndex = 5;
            uyeEklemeDosyadanYukleButton.Text = "Dosyadan Yukle";
            uyeEklemeDosyadanYukleButton.UseVisualStyleBackColor = true;
            uyeEklemeDosyadanYukleButton.Click += uyeEklemeDosyadanYukleButton_Click;
            // 
            // UyeEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 434);
            Controls.Add(uyeEklemeDosyadanYukleButton);
            Controls.Add(uyeEklemeDosyayaKaydetButton);
            Controls.Add(uyeEklemeEkleButton);
            Controls.Add(uyeEklemeDataGridView);
            Controls.Add(uyeEklemeUyeNoTextBox);
            Controls.Add(uyeEklemeUyeSoyIsimTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(uyeEklemeUyeIsimTextBox);
            Controls.Add(label1);
            Name = "UyeEkleme";
            Text = "UyeEkleme";
            ((System.ComponentModel.ISupportInitialize)uyeEklemeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uyeEklemeUyeNoTextBox;
        private TextBox uyeEklemeUyeSoyIsimTextBox;
        private Label label3;
        private Label label2;
        private TextBox uyeEklemeUyeIsimTextBox;
        private Label label1;
        private DataGridView uyeEklemeDataGridView;
        private Button uyeEklemeEkleButton;
        private Button uyeEklemeDosyayaKaydetButton;
        private Button uyeEklemeDosyadanYukleButton;
    }
}