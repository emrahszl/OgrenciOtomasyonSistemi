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
        public Ders(string dersKodu, string dersAdi, int kredi)
        {
            DersKodu = dersKodu;
            DersAdi = dersAdi;
            Kredi = kredi;
        }

        public string DersKodu { get; set; }

        public string DersAdi { get; set; }

        public int Kredi { get; set; }

        public double VizeNotu { get; set; }

        public double FinalNotu { get; set; }

        private double _dersNotu;

        public double DersNotu
        {
            get { return _dersNotu; }
            set { _dersNotu = value; }
        }


        private HarfNotu _harfNotu;

        public HarfNotu HarfNotu
        {
            get { return _harfNotu; }
            set { _harfNotu = value; }
        }


        public override string ToString()
        {
            return $"{DersKodu} {DersAdi} {Kredi}";
        }
    }
}
