using System;

namespace GamePro
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
            gamerManager.Add(new GamerDetails { 
                Id = 1, 
                BirthYear = 1995,
                FirstName = "Burak", 
                LastName = "Demircioğlu", 
                IdentityNumber = 123456789
            });
        }
    }
}
