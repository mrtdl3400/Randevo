using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Hizmet
    {
        public int Id { get; set; }

        public string HizmetAdi { get; set; }

        public string Aciklama { get; set; }

        public decimal Ucret { get; set; }

        public int SureDakika { get; set; }

        public bool AktifMi { get; set; }

        public int IsletmeId { get; set; }
    }
}
