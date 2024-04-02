using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Odev_1
{
    public class EmanetIslemleri
    {

        private string? _uyeNo;
        private string? _kitapNo;
        private List<EmanetIslemleri> emanetler;

        public string? UyeNo { get { return _uyeNo; } set { _uyeNo = value; } }
        public string? KitapNo { get { return _kitapNo; } set { _kitapNo = value; } }

        public EmanetIslemleri(List<EmanetIslemleri>emanetler) 
        {
            this.emanetler = emanetler;
        }

        public EmanetIslemleri()
        {
        }

        public void TabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {this.KitapNo,
                                         this.UyeNo});
        }

        public void Duzenle(DataTable tablo)
        {
            tablo.Rows.Clear();
            tablo.Rows.Add(new object[] {this.KitapNo,
                                         this.UyeNo});

        }
    }
}
