using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                Name = "Mine",
                LastName = "Aktaş",
                BirthYear = 1998,
                IdentityNumber = 12345
            };
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);

            Game game1 = new Game
            {
                Id = 1,
                Name = "Pubg",
                Price = 120
            };

            Game game2 = new Game
            {
                Id = 2,
                Name = "Sims 3",
                Price = 450
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Delete(game1);
            gameManager.Delete(game2);
            gameManager.Update(game1);
            gameManager.Update(game2);

            SalesManager sales1 = new SalesManager();
            sales1.Sell(gamer1, game1);
            sales1.Sell(gamer1, game2);
            sales1.Return(gamer1, game2);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Kadınlar Günü İndirimi";
            campaign.Code = 8032021;
            campaign.Discount = 50;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            sales1.SellWithDiscount(gamer1, game1, campaign);
        }
    }
}
