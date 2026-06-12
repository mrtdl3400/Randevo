using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Bildirim
    {
        public int Id { get; set; }

        public string Baslik { get; set; }

        public string Mesaj { get; set; }

        public bool OkunduMu { get; set; }

        public DateTime GonderimTarihi { get; set; }

        public int KullaniciId { get; set; }
    }
}
