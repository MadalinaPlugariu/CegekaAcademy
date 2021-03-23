using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{

    class SportTeam
    {
        public string NameT { get; set; }
        public string DescriptionT { get; set; }

        public string[] members = new string[3];

        SportClubs sportClubs = new SportClubs();
        public SportTeam()
        {

        }
        public SportTeam(string nameT, string description, string[] membersT)
        {
            NameT = nameT;
            DescriptionT = description;

            this.members = membersT;
        } 

        public void GetSportTeam()
        {
            Console.WriteLine($"Sport team name is: {NameT}");
            Console.WriteLine($"Sport team description is: {DescriptionT}");

            Console.WriteLine($"Sport teams members are: ");
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i]);
            }
        }

    }
}
