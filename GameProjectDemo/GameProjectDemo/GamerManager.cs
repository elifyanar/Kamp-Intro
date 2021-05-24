using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GamerManager : IGamerService
    {
        IPersonCheckService eDevlet;
        public GamerManager(IPersonCheckService personCheckService)
        {
            this.eDevlet = personCheckService;
        }
        public void add(Gamer gamer)
        {
            Console.WriteLine( gamer.FirstName + " " + gamer.LastName+" recorded.");
        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " updated.");
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " deleted.");
        }
    }
    }

