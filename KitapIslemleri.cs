using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Odev_1
{
    public class KitapIslemleri
    {
        private string? _kitapAdi;
        private string? _kitapNo;
        private string? _kitapYazar;
        private List<KitapIslemleri> kitaplar;

        public KitapIslemleri()
        {
        }

        public KitapIslemleri(List<KitapIslemleri> kitaplar)
        {
            this.kitaplar = kitaplar;
        }

        public string? KitapAdi { get { return _kitapAdi; } set { _kitapAdi = value; } }
        public string? KitapNo { get { return _kitapNo; } set { _kitapNo = value; } }
        public string? KitapYazar { get { return _kitapYazar; } set { _kitapYazar = value; } }


        public void TabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {this.KitapNo,
                                         this.KitapAdi,
                                         this.KitapYazar});
        }
        public void Duzenle (DataTable tablo)
        { 
            tablo.Rows.Clear(); 
            tablo.Rows.Add(new object[] {this.KitapNo,
                                         this.KitapAdi,
                                         this.KitapYazar});
        }
       
    }
}
