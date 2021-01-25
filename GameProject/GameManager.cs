using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager 
    {
        List<Games> games = new List<Games>() { };

        public void Add(Games games1)
        {
            games.Add(games1);
            Console.WriteLine("Yeni Oyun Eklendi : " + games1.GameName);
        }

        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }

        public void Update()
        {
            Console.WriteLine("Game updated!"); 
        }
    }
}
