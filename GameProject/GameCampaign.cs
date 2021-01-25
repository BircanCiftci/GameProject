using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameCampaign : IInGameManager
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double Campaign { get; set; }

        List<GameCampaign> gameCampaigns = new List<GameCampaign>() { };

        public void CampaignAdd()
        { 
            Console.WriteLine("Yeni kampanya eklendi ");
        }

        public void CampaignDelete()
        {
            Console.WriteLine("Kampanya silindi ");
        }

        public void CampaingUpdate()
        {
            Console.WriteLine("Kampanya güncellendi"); 
        }
    }
}
