using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class SportClubs
    {
        public string ClubName { get; private set; }
        public int FoundingYear { get; private set; }
        public string[] sportTeams = new string[3];

        public SportClubs()
        {

        }
        public SportClubs(string clubName, int foundingYear, string[] sportTeams)
        {
            ClubName = clubName;
            FoundingYear = foundingYear;

            this.sportTeams = sportTeams;

        }

        public void GetSportClubs()
        {
            Console.WriteLine($"{ClubName} club founded in {FoundingYear} with the following teams:  ");
            for (int i=0; i<sportTeams.Length; i++)
            {
                Console.WriteLine(sportTeams[i]);
            }
            
        }


    }
}
