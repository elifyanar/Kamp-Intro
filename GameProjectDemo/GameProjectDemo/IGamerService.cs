using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IGamerService
    {
         void add(Gamer gamer);
         void update(Gamer gamer);
         void delete(Gamer gamer);

    }
}
