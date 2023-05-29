using OkulVeri.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulVeri.Siniflar
{
    public class Ders
    {
        public Ders(string dersKodu, string dersAdi)
        {
            DersKodu = dersKodu;
            DersAdi = dersAdi;
        }

        public string DersKodu { get; set; }

        public string DersAdi { get; set; }

        public int Kredi { get; set; }

        public double VizeNotu { get; set; }

        public double FinalNotu { get; set; }

        public HarfNotu HarfNotu { get; }
    }
}
