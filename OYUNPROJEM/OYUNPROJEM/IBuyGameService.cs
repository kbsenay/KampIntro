using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    interface IBuyGameService
    {
        void Buy(Game game, Player player);
    }
}
