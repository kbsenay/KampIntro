using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    interface IGameManager
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
