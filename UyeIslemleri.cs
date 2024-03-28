using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Odev_1
{
    public class UyeIslemleri
    {
        private string? _ad;
        private string? _soyAd;
        private string? _numara;

        public string Ad { get { return _ad; } set { _ad = value; } }
        public string SoyAd { get { return _soyAd; } set { _soyAd = value; } }
        public string Numara { get { return _numara; } set { _numara = value;} }

        public void TabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {this.Ad,
                                         this.SoyAd,
                                         this.Numara});
        }
    }
}
