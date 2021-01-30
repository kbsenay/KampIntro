using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class BuyGameManager : IBuyGameService
    {
        public void Buy(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " "+ player.LastName + " isimli oyuncu " + game.Name + " oyununu satın aldı.");
        }

    }
}
