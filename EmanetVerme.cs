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

    public partial class EmanetVerme : Form
    {
        private DataTable dt;
        public static List<EmanetIslemleri> emanetler;


        public EmanetVerme()
        {
            InitializeComponent();
            EmanetVerme.emanetler = new List<EmanetIslemleri>();
            dt = new DataTable();
            dt.Columns.Add("Kitap No : ");
            dt.Columns.Add("Kullanıcı No : ");
            emanetVermeDataGridView.DataSource = dt;
        }

        private void emanetIslemleriEmanetAlButton_Click(object sender, EventArgs e)
        {
            EmanetIslemleri emanetIslemleri = new EmanetIslemleri();
            emanetIslemleri.KitapNo = emanetIslmeleriKitapNoTextBox.Text;
            emanetIslemleri.UyeNo = emanetIslemleriUyeNoTextBox.Text;

            emanetIslemleri.TabloyaEkle(dt);
            emanetler.Add(emanetIslemleri);

            emanetIslemleriUyeNoTextBox.Text = "";
            emanetIslmeleriKitapNoTextBox.Text = "";

        }

        private void emanetIslemleriDosyayaKaydetButton_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<EmanetIslemleri>>(emanetler);

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
