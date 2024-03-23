namespace Vize_Odev_1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void UyeEklemeButton_Click(object sender, EventArgs e)
        {
            UyeEkleme uyeEkleme = new UyeEkleme();
            uyeEkleme.Show();
        }

        private void KitapEklemeButton_Click(object sender, EventArgs e)
        {
            KitapEkleme kitapEkleme = new KitapEkleme();
            kitapEkleme.Show();
        }

        private void EmanetIslemleriButton_Click(object sender, EventArgs e)
        {
            EmanetIslemeleri emanetIslemleri = new EmanetIslemeleri();
            emanetIslemleri.Show();
        }
    }
}
