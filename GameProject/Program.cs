using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OldPlayer player1 = new OldPlayer();
            player1.Id = 1;
            player1.TcNo = "12345678901";
            player1.PlayerName = "Bircan";
            player1.PlayerLastName = "ÇİFTÇİ";
            player1.DateOfBirth = new DateTime(1998,8,21);
            player1.GameDegree = "Gold 1";

            OldPlayer player2 = new OldPlayer();
            player2.Id = 2;
            player2.TcNo = "12345678910";
            player2.PlayerName = "Serhat";
            player2.PlayerLastName = "DEVECİ";
            player2.DateOfBirth = new DateTime(1997, 8, 8);
            player2.GameDegree = "Platinum 1";

            NewPlayer player3 = new NewPlayer();
            player3.Id = 3;
            player3.TcNo = "12345678910";
            player3.PlayerName = "Serhat";
            player3.PlayerLastName = "DEVECİ";
            player3.DateOfBirth = new DateTime(1986, 5, 16);
            player3.MembershipReference = "Ocak1234";

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add();
            playerManager.Delete();
            playerManager.Update();

            Games games1 = new Games();
            games1.Id = 1;
            games1.GameName = "LOL";
            games1.GameType = "Strategy";
            games1.GamePrice = 25;
            games1.GameYear = 2010;

            Games games2 = new Games();
            games2.Id = 2;
            games2.GameName = "Days Gone";
            games2.GameType = "Action";
            games2.GamePrice = 50;
            games2.GameYear = 2018;

            GameCampaign campaing1 = new GameCampaign();
            campaing1.Id = 1;
            campaing1.CampaignName = "New Years";
            campaing1.Campaign = 10;

            GameCampaign campaing2 = new GameCampaign();
            campaing2.Id = 1;
            campaing2.CampaignName = "Student";
            campaing2.Campaign = 20;

            GameCampaign campaign = new GameCampaign();
            campaign.CampaignAdd();
            campaign.CampaignDelete();
            campaign.CampaingUpdate();

            GameManager gameManager = new GameManager();
            gameManager.Add(games1);
            gameManager.Add(games2);

            GameSale gameSale1 = new GameSale(player1, games1, campaing1);
            gameSale1.GameSales();

            GameSale gameSale2 = new GameSale(player2, games2, campaing2);
            gameSale2.GameSales();

            

        }
    }
}
