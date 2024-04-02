using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Odev_1
{
    public partial class KitapEkleme : Form
    {
        private DataTable dt;
        public static List<KitapIslemleri> kitaplar;

        public KitapEkleme()
        {
            InitializeComponent();
            KitapEkleme.kitaplar = new List<KitapIslemleri>();
            dt = new DataTable();
            dt.Columns.Add("Kitap No : ");
            dt.Columns.Add("Kitap Adı : ");
            dt.Columns.Add("Kitap Yazar : ");


            kitapEklemeDataGridView.DataSource = dt;
        }

        private void kitapEklemeEkleButton_Click(object sender, EventArgs e)
        {

            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            kitapIslemleri.KitapNo = kitapEklemeKitapNoTextBox.Text;
            kitapIslemleri.KitapYazar = kitapEklemeKitapYazarTextBox.Text;
            kitapIslemleri.KitapAdi = kitapEklemeKitapAdıTextBox.Text;

            kitapIslemleri.TabloyaEkle(dt);
            kitaplar.Add(kitapIslemleri);

            kitapEklemeKitapAdıTextBox.Text = "";
            kitapEklemeKitapNoTextBox.Text = "";
            kitapEklemeKitapYazarTextBox.Text = "";

        }

        private void kitapEklemeDosyadanYukleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                kitaplar = JsonSerializer.Deserialize<List<KitapIslemleri>>(data);

                foreach (KitapIslemleri kitaplar in kitaplar)
                {
                    kitaplar.TabloyaEkle(dt);
                }
            }
        }

        private void kitapIslmeleriDosyaKaydetButton_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<KitapIslemleri>>(kitaplar);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void kitapEklemeDuzenleButton_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            kitapIslemleri.KitapNo = kitapEklemeKitapNoTextBox.Text;
            kitapIslemleri.KitapYazar = kitapEklemeKitapYazarTextBox.Text;
            kitapIslemleri.KitapAdi = kitapEklemeKitapAdıTextBox.Text;

            kitapIslemleri.Duzenle(dt);
            kitaplar.Add(kitapIslemleri);

            kitapEklemeKitapAdıTextBox.Text = "";
            kitapEklemeKitapNoTextBox.Text = "";
            kitapEklemeKitapYazarTextBox.Text = "";


        }

        private void kitapEklemeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                kitapEklemeKitapNoTextBox.Text = kitapEklemeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                kitapEklemeKitapAdıTextBox.Text = kitapEklemeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                kitapEklemeKitapYazarTextBox.Text = kitapEklemeDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            }
            catch (Exception ex) { }
        }


        private void kitapEklemeSilButton_Click_1(object sender, EventArgs e)
        {
            if (kitapEklemeDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in kitapEklemeDataGridView.SelectedRows)
                {
                    kitapEklemeDataGridView.Rows.Remove(row);
                }

            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
            kitapEklemeKitapAdıTextBox.Text = "";
            kitapEklemeKitapNoTextBox.Text = "";
            kitapEklemeKitapYazarTextBox.Text = "";
        }
    }
}
