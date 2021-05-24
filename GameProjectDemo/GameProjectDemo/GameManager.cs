using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GameManager : IGameService
    {
        public void add(Game game)
        {
            Console.WriteLine(game.name + " added.");
        }

        public void delete(Game game)
        {
            Console.WriteLine(game.name + " deleted.");
        }

        public void update(Game game)
        {
            Console.WriteLine(game.name + " updated.");
        }
    }
}
