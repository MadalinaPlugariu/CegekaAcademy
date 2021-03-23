using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams1 = new string[3] { "Steaua", "Rapid", "Otelul Galati" };
            string[] teams2 = new string[3] { "Lakers", "Knicks", "Celtics" };
            SportClubs sc1 = new SportClubs("Football", 2000, teams1);
            SportClubs sc2 = new SportClubs("Basketball", 1998, teams2);

            //"football", "basketball", "hockey"
            Console.WriteLine("*Clubs*\n");
            sc1.GetSportClubs();
            Console.WriteLine("\n");
            sc2.GetSportClubs();
            Console.WriteLine("\n");

            Console.WriteLine("*Teams*\n");
            string[] teamMembers1 = new string[3] { "Adrian Mutu", "Lionel Messi", "Cristiano Ronaldo" };
            string[] teamMembers2 = new string[3] { "LeBron James", "James Harden", "Derrick Rose" };

            SportTeam st1 = new SportTeam("Steaua", "Great performance", teamMembers1);
            SportTeam st2 = new SportTeam("Celtics", "Good games", teamMembers2);

            st1.GetSportTeam();
            Console.WriteLine("\n");
            st2.GetSportTeam();
            Console.WriteLine("\n");

            Console.WriteLine("*Human*\n");
            DateTime birthdate = new DateTime(1989, 03, 21);
            Human human1 = new Human("Leonte Alexandru", birthdate);
            human1.GetHumanData();
            Console.WriteLine("\n");


        }
    }
}
