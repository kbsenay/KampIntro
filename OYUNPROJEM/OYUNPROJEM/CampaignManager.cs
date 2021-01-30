using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class CampaignManager : ICampaingService
    {
       
        public void MakeCampaing(Campaing campaing, Player player, Game game)
        {

            campaing.DiscountRate = game.Cost * 0.9;
            Console.WriteLine("Kampanyalı fiyat " + campaing.DiscountRate + " ! ");
            
        }

        public void Message(Player player, Campaing campaing)
        {
            Console.WriteLine("Sayın "+ player.FirstName+" " 
                +player.LastName+ " " + campaing.CampaingName+ " size özel % 10 indirim fırsatıyla. Kampanyayı kaçırmayın!");
        }
    }
}
