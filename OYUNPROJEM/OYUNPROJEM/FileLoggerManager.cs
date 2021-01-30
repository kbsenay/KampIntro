using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class FileLoggerManager : ILoggerService
    {
        public void Log(Player player)
        {
            Console.WriteLine("Kullanıcı dosyaya loglandı.");
        }
    }
}
