using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun listenize eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun kaldırıldı.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun güncellendi.");
        }
    }
}
