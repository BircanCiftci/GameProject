using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSale : Games
    {
        int gamePrice;
        double campaigns;
        public GameSale(Player player, Games games, GameCampaign gameCampaign)
        {
            gamePrice = games.GamePrice;
            campaigns = gameCampaign.Campaign;
        }

        public void GameSales()
        {
            List<Games> game = new List<Games>() { };
            Console.WriteLine("Fiyatı :" + gamePrice);
            Console.WriteLine("Kampanyalı :" + (gamePrice - campaigns));
        }
    }
}
