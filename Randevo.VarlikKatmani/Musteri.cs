using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Musteri
    {
        public int Id { get; set; }

        public string AdSoyad { get; set; }

        public string Telefon { get; set; }

        public string Eposta { get; set; }

        public DateTime KayitTarihi { get; set; }

        public bool AktifMi { get; set; }

        public int IsletmeId { get; set; }
    }
}