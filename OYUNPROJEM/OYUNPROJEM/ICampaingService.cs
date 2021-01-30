using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    interface ICampaingService
    {
        void MakeCampaing(Campaing campaing, Player player, Game game);
        void Message(Player player, Campaing campaing);
    }
}
