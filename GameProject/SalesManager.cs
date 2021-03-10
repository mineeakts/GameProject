using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        public void Sell(Gamer gamer,Game game)
        {
            Console.WriteLine(gamer.Name+" "+game.Name+" satın aldı.");
        }
        public void Return(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " " + game.Name + " iade etti.");
        }

        public void SellWithDiscount(Gamer gamer,Game game,Campaign campaign)
        {
            Console.WriteLine(gamer.Name + ", " + game.Name + " oyununu yüzde " + campaign.Discount + " indirimli satın aldı.");
        }
        
    }
}
