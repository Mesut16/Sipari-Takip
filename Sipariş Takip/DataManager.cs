using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Takip
{
    public class DataManager
    {
        public List<UrunKategori> GetUrunKategoriList()
        {
            Urunler urunlerClass = new Urunler();
            Kategoriler kategorilerClass = new Kategoriler();

            List<Urun> urunler = urunlerClass.GetAll();
            List<Kategori> kategoriler = kategorilerClass.GetAll();

            var urunKategoriList = from urun in urunler
                                   join kategori in kategoriler
                                   on urun.kategori_id equals kategori.kategori_id
                                   select new UrunKategori
                                   {
                                       urun_kodu = urun.urun_kodu,
                                       urun_adi = urun.urun_adi,
                                       kategori_adi = kategori.kategori_adi
                                   };

            return urunKategoriList.ToList();
        }
    }

}


