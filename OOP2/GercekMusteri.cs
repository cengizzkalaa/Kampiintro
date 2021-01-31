using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri : Musteri // İndividual müsteri özelliklerini içeren class. inheritance uyguluyoruz burada yani gerçekmüsteri de bir müsteridir.
    {

        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
