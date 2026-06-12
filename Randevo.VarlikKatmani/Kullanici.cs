using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Kullanici
    {
        public int Id { get; set; }

        public string AdSoyad { get; set; }

        public string Eposta { get; set; }

        public string Sifre { get; set; }

        public string Telefon { get; set; }

        public string Rol { get; set; }

        public DateTime KayitTarihi { get; set; }
    }
}
