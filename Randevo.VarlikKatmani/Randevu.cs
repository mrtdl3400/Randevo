using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Randevu
    {
        public int Id { get; set; }

        public DateTime RandevuTarihi { get; set; }

        public string Durum { get; set; }

        public string Notlar { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

        public int IsletmeId { get; set; }

        public int MusteriId { get; set; }

        public int PersonelId { get; set; }

        public int HizmetId { get; set; }
    }
}
