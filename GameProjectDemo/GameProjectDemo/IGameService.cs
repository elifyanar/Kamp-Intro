using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IGameService
    {
        void add(Game game);
        void update(Game game);
        void delete(Game game);

    }
}
