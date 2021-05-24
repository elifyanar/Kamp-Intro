using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.nationalityId.Length == 11)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
