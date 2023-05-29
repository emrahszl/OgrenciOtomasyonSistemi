using OgrenciVeri.Koleksiyonlar;
using OkulVeri.Koleksiyonlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciVeri.Siniflar
{
    public class OgrenciVerileri
    {
        public Ogrenciler Ogrenciler { get; set; } = new();

        public Donemler Donemler { get; set; } = new();

        public Dersler Dersler { get; set; } = new();
    }
}
