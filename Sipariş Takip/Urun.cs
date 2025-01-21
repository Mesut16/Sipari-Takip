using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Takip
{
    public class Urun
    {
        public int urun_id {  get; set; }
        public string urun_kodu { get; set; }
        public string urun_adi { get; set; }
        public int kategori_id { get; set; }
    }
}
