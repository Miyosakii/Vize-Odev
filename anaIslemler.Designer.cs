namespace Vize_Odev_1
{
    partial class anaIslemler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UyeEklemeButton = new Button();
            KitapEklemeButton = new Button();
            EmanetIslemleriButton = new Button();
            SuspendLayout();
            // 
            // UyeEklemeButton
            // 
            UyeEklemeButton.Location = new Point(594, 103);
            UyeEklemeButton.Name = "UyeEklemeButton";
            UyeEklemeButton.Size = new Size(135, 74);
            UyeEklemeButton.TabIndex = 0;
            UyeEklemeButton.Text = "Uye Ekleme";
            UyeEklemeButton.UseVisualStyleBackColor = true;
            UyeEklemeButton.Click += UyeEklemeButton_Click;
            // 
            // KitapEklemeButton
            // 
            KitapEklemeButton.Location = new Point(384, 103);
            KitapEklemeButton.Name = "KitapEklemeButton";
            KitapEklemeButton.Size = new Size(135, 74);
            KitapEklemeButton.TabIndex = 1;
            KitapEklemeButton.Text = "Kitap Ekleme";
            KitapEklemeButton.UseVisualStyleBackColor = true;
            KitapEklemeButton.Click += KitapEklemeButton_Click;
            // 
            // EmanetIslemleriButton
            // 
            EmanetIslemleriButton.Location = new Point(194, 103);
            EmanetIslemleriButton.Name = "EmanetIslemleriButton";
            EmanetIslemleriButton.Size = new Size(135, 74);
            EmanetIslemleriButton.TabIndex = 2;
            EmanetIslemleriButton.Text = "Emanet Islemleri";
            EmanetIslemleriButton.UseVisualStyleBackColor = true;
            EmanetIslemleriButton.Click += EmanetIslemleriButton_Click;
            // 
            // anaIslemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 496);
            Controls.Add(EmanetIslemleriButton);
            Controls.Add(KitapEklemeButton);
            Controls.Add(UyeEklemeButton);
            Name = "anaIslemler";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button UyeEklemeButton;
        private Button KitapEklemeButton;
        private Button EmanetIslemleriButton;
    }
}
