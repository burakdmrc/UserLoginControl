using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro
{
    interface IGamerManager
    {
        void Add(GamerDetails gamerDetails);
        void Update(GamerDetails gamerDetails);
        void Delete(GamerDetails gamerDetails);
    }
}
