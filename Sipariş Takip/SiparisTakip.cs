using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Takip
{
    public class SiparisTakip
    {
        public int SiparisId { get; set; }
        public string SirketAdi { get; set; }
        public int SiparisAdet { get; set; }
        public int HazirlananAdet { get; set; }
        public int KalanAdet
        {
            get
            {
                return SiparisAdet - HazirlananAdet;
            }
        }
        public string MusteriTelefon { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string UrunKodu { get; set; }
        public string TeslimDurumu { get; set; }

        public void SetTeslimDurumu(string teslimDurumu)
        {
            if (teslimDurumu == "Edildi" || teslimDurumu == "Edilmedi")
            {
                TeslimDurumu = teslimDurumu;
            }
            else
            {
                throw new ArgumentException("Teslim durumu yalnızca 'Edildi' veya 'Edilmedi' olabilir.");
            }
        }
    }
}
