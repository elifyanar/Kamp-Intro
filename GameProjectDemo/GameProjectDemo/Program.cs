using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamerManager = new GamerManager(new PersonCheckManager());
            gamerManager.add(new Gamer { id = 1, dateOfBirth="1999", nationalityId="12345678910",FirstName = "Elif", LastName = "Yanar" });


        }
    }
}
