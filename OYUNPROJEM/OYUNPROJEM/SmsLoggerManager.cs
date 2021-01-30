using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class SmsLoggerManager : ILoggerService
    {
        public void Log(Player player)
        {
            Console.WriteLine(player.PhoneNumber + " numarasına SMS gönderildi.");
        }
    }


}
