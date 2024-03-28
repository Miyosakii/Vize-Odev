namespace Vize_Odev_1
{
    partial class KitapEkleme
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
            kitapEklemeKitapNotextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            kitapEklemeKitapAdıTextBox = new TextBox();
            kitapEklemeKitapYazarTextBox = new TextBox();
            kitapEklemeEkleButton = new Button();
            kitapEklemeDataGridView = new DataGridView();
            kitapEklemeDosyadanYukleButton = new Button();
            kitapIslmeleriDosyaKaydetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)kitapEklemeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap No";
            // 
            // kitapEklemeKitapNotextBox
            // 
            kitapEklemeKitapNotextBox.Location = new Point(129, 19);
            kitapEklemeKitapNotextBox.Name = "kitapEklemeKitapNotextBox";
            kitapEklemeKitapNotextBox.Size = new Size(228, 27);
            kitapEklemeKitapNotextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 141);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Kitap Yazar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 81);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Kitap Adı";
            // 
            // kitapEklemeKitapAdıTextBox
            // 
            kitapEklemeKitapAdıTextBox.Location = new Point(129, 78);
            kitapEklemeKitapAdıTextBox.Name = "kitapEklemeKitapAdıTextBox";
            kitapEklemeKitapAdıTextBox.Size = new Size(228, 27);
            kitapEklemeKitapAdıTextBox.TabIndex = 2;
            // 
            // kitapEklemeKitapYazarTextBox
            // 
            kitapEklemeKitapYazarTextBox.Location = new Point(129, 134);
            kitapEklemeKitapYazarTextBox.Name = "kitapEklemeKitapYazarTextBox";
            kitapEklemeKitapYazarTextBox.Size = new Size(228, 27);
            kitapEklemeKitapYazarTextBox.TabIndex = 3;
            // 
            // kitapEklemeEkleButton
            // 
            kitapEklemeEkleButton.Location = new Point(129, 206);
            kitapEklemeEkleButton.Name = "kitapEklemeEkleButton";
            kitapEklemeEkleButton.Size = new Size(149, 43);
            kitapEklemeEkleButton.TabIndex = 4;
            kitapEklemeEkleButton.Text = "Ekle";
            kitapEklemeEkleButton.UseVisualStyleBackColor = true;
            kitapEklemeEkleButton.Click += kitapEklemeEkleButton_Click;
            // 
            // kitapEklemeDataGridView
            // 
            kitapEklemeDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kitapEklemeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitapEklemeDataGridView.Location = new Point(420, 36);
            kitapEklemeDataGridView.Name = "kitapEklemeDataGridView";
            kitapEklemeDataGridView.RowHeadersWidth = 51;
            kitapEklemeDataGridView.Size = new Size(436, 308);
            kitapEklemeDataGridView.TabIndex = 7;
            // 
            // kitapEklemeDosyadanYukleButton
            // 
            kitapEklemeDosyadanYukleButton.Location = new Point(39, 279);
            kitapEklemeDosyadanYukleButton.Name = "kitapEklemeDosyadanYukleButton";
            kitapEklemeDosyadanYukleButton.Size = new Size(149, 43);
            kitapEklemeDosyadanYukleButton.TabIndex = 5;
            kitapEklemeDosyadanYukleButton.Text = "Dosyadan Yükle";
            kitapEklemeDosyadanYukleButton.UseVisualStyleBackColor = true;
            kitapEklemeDosyadanYukleButton.Click += kitapEklemeDosyadanYukleButton_Click;
            // 
            // kitapIslmeleriDosyaKaydetButton
            // 
            kitapIslmeleriDosyaKaydetButton.Location = new Point(229, 280);
            kitapIslmeleriDosyaKaydetButton.Name = "kitapIslmeleriDosyaKaydetButton";
            kitapIslmeleriDosyaKaydetButton.Size = new Size(149, 40);
            kitapIslmeleriDosyaKaydetButton.TabIndex = 6;
            kitapIslmeleriDosyaKaydetButton.Text = "Dosyaya Kaydet";
            kitapIslmeleriDosyaKaydetButton.UseVisualStyleBackColor = true;
            kitapIslmeleriDosyaKaydetButton.Click += kitapIslmeleriDosyaKaydetButton_Click;
            // 
            // KitapEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 434);
            Controls.Add(kitapIslmeleriDosyaKaydetButton);
            Controls.Add(kitapEklemeDosyadanYukleButton);
            Controls.Add(kitapEklemeDataGridView);
            Controls.Add(kitapEklemeEkleButton);
            Controls.Add(kitapEklemeKitapYazarTextBox);
            Controls.Add(kitapEklemeKitapAdıTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kitapEklemeKitapNotextBox);
            Controls.Add(label1);
            Name = "KitapEkleme";
            Text = "KitapEkleme";
            ((System.ComponentModel.ISupportInitialize)kitapEklemeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox kitapEklemeKitapNotextBox;
        private Label label2;
        private Label label3;
        private TextBox kitapEklemeKitapAdıTextBox;
        private TextBox kitapEklemeKitapYazarTextBox;
        private Button kitapEklemeEkleButton;
        private DataGridView kitapEklemeDataGridView;
        private Button kitapEklemeDosyadanYukleButton;
        private Button kitapIslmeleriDosyaKaydetButton;
    }
}