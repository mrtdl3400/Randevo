using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevo.VarlikKatmani
{
    public class Odeme
    {
        public int Id { get; set; }

        public decimal Tutar { get; set; }

        public string OdemeDurumu { get; set; }

        public string OdemeYontemi { get; set; }

        public DateTime OdemeTarihi { get; set; }

        public int RandevuId { get; set; }

        public int IsletmeId { get; set; }
    }
}
