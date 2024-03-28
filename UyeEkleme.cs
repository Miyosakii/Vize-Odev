using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Odev_1
{
    public partial class UyeEkleme : Form
    {
        private DataTable dt;
        public List<UyeIslemleri> uyeler;
        public UyeEkleme()
        {
            InitializeComponent();
            uyeler = new List<UyeIslemleri>();
            dt = new DataTable();
            dt.Columns.Add("Uye No : ");
            dt.Columns.Add("Uye Isim : ");
            dt.Columns.Add("Uye Soyisim : ");

            uyeEklemeDataGridView.DataSource = dt;
        }

        private void uyeEklemeEkleButton_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyeislemleri = new UyeIslemleri();
            uyeislemleri.Numara = uyeEklemeUyeNoTextBox.Text;
            uyeislemleri.Ad = uyeEklemeUyeIsimTextBox.Text;
            uyeislemleri.SoyAd = uyeEklemeUyeSoyIsimTextBox.Text;

            uyeislemleri.TabloyaEkle(dt);
            uyeler.Add(uyeislemleri);

            uyeEklemeUyeIsimTextBox.Text = "";
            uyeEklemeUyeNoTextBox.Text = "";
            uyeEklemeUyeSoyIsimTextBox.Text = "";
        }

        private void uyeEklemeDosyadanYukleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                uyeler = JsonSerializer.Deserialize<List<UyeIslemleri>>(data);

                foreach (UyeIslemleri uyeler in uyeler)
                {
                    uyeler.TabloyaEkle(dt);
                }
            }
        }

        private void uyeEklemeDosyayaKaydetButton_Click(object sender, EventArgs e)
        {

            string yazilacak = JsonSerializer.Serialize<List<UyeIslemleri>>(uyeler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }
    }
}
