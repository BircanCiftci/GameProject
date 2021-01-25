using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager 
    {
        List<NewPlayer> players = new List<NewPlayer>() { };

        public void Add()
        {
            Console.WriteLine("Yeni Oyuncu Eklendi ");
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu silindi ");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu güncellendi ");
        }
    }
}
