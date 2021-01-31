using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService  // veritabanına loglama yapıcak süreç aynı zaman bir Ilogger alternatifi
    {
        public void Log()
        {
            Console.WriteLine("Veritabına loglandı");

        }


    }
}
