using OkulVeri.Koleksiyonlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulVeri.Siniflar
{
    public class Ogrenci
    {
        private string _yilNo;

        private int _bolumNo = 100;

        private static int _sayacNo;

        private string _ogrenciNo;

        public Ogrenci(string ogrenciAd, string ogrenciSoyad)
        {
            OgrenciAd = ogrenciAd;
            OgrenciSoyad = ogrenciSoyad;
            KayitTarihi = Convert.ToDateTime(DateTime.Now.ToString("d"));

            _yilNo = KayitTarihi.Year.ToString().Substring(2);
            _sayacNo++;
            KayitNo = _sayacNo.ToString("000");

            _ogrenciNo = $"{_yilNo}-{_bolumNo}-{KayitNo}";
        }

        public string KayitNo { get; }

        public string OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }

        public string OgrenciAd { get; set; }

        public string OgrenciSoyad { get; set; }

        public DateTime KayitTarihi { get; set; }

        public Donemler Donemler { get; set; } = new();

        public double GenelNotOrtalamasi { get; set; }

        public int ToplamKredi { get; set; }

        public override string ToString()
        {
            return $"{OgrenciNo} {OgrenciAd} {OgrenciSoyad} ";
        }
    }
}
