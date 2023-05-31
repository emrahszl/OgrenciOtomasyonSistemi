using OgrenciVeri.Koleksiyonlar;
using OkulVeri.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulVeri.Siniflar
{
    public class Donem
    {
        private static int _donemNo;

        public Donem()
        {
            _donemNo++;
            DonemAdi = $"{_donemNo}. Dönem";
        }

        public string DonemAdi { get; set; }

        public Dersler Dersler { get; set; } = new();

        public double DonemNotOrtalamasi { get; set; }

        public int DonemKredisi { get; set; }

        public override string ToString()
        {
            return $"{DonemAdi}";
        }
    }
}
