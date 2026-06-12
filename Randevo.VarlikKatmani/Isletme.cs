using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Isletme
    {
        public int Id { get; set; }

        public string IsletmeAdi { get; set; }

        public string YetkiliAdi { get; set; }

        public string Telefon { get; set; }

        public string Eposta { get; set; }

        public string Adres { get; set; }

        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }

        public bool AktifMi { get; set; }
    }
}
