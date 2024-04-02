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
            dt.Columns.Add("Uye No : ");
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

        private void emanetIslemleriDuzenlemeButton_Click(object sender, EventArgs e)
        {
            EmanetIslemleri emanetIslemleri = new EmanetIslemleri();
            emanetIslemleri.KitapNo = emanetIslmeleriKitapNoTextBox.Text;
            emanetIslemleri.UyeNo = emanetIslemleriUyeNoTextBox.Text;

            emanetIslemleri.Duzenle(dt);
            emanetler.Add(emanetIslemleri);

            emanetIslemleriUyeNoTextBox.Text = "";
            emanetIslmeleriKitapNoTextBox.Text = "";
        }

        private void emanetVermeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                emanetIslmeleriKitapNoTextBox.Text = emanetVermeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                emanetIslemleriUyeNoTextBox.Text = emanetVermeDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex) { }

        }

        private void emanetVermeSilButton_Click(object sender, EventArgs e)
        {
            if (emanetVermeDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in emanetVermeDataGridView.SelectedRows)
                {
                    emanetVermeDataGridView.Rows.Remove(row);
                }

            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
            emanetIslemleriUyeNoTextBox.Text = "";
            emanetIslmeleriKitapNoTextBox.Text = "";
        }
    }
}
