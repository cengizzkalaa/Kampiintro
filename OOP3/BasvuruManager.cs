using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {    // Method İnjection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // Kredi Manager hepsinin referansını tuttugu için onu parametre olarak gösterebiliriz.
        {    // burada tek bir kredi soruluyor hesaplattırılıyor
             //Başvuran bilgilerini değerlendirme           
             //KonutKrediManager konutKrediManager = new KonutKrediManager();
             //konutKrediManager.Hesapla(); // bu şekilde olsaydı kod butun basvurular konut kredisi üzerisinden hesaplanırdı.

            krediManager.Hesapla();  // burada bir tane krediyi hesaplıyordu
            loggerService.Log();  // Hangi loglayıcı seçilmişsse sistemde onu logla


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // Burada ise birden fazla kredinin hesabı yaptırılmak isteniyor. 
        {                                                                      // Aynı veri türünden birden fazla veriyi bir arada tutan yapı ve daha sonra eklenildiği için List kullanıyoruz
            foreach (var kredi in krediler) // liste var hepsini tek tek hesapla demek

            {
                kredi.Hesapla();
            }
        }


    }
}
