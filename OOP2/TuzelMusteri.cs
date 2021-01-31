using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras inheritance müsteride olan her şey tüzel müsteride de kabul ediliyor.
    class TuzelMusteri : Musteri // (Coorporate)  müsteri özelliklerini içeren bir class. TuzelMNusteri yi : Musteri yapmaya miras yani inheritance diyoruz. Tüzel müşteri bir müşteridir demek.
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }



    }
}
