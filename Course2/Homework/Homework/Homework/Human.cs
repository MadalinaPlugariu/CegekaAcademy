using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Human : SportTeam
    {
        public string name;
        public DateTime birthdate;

        public Human()
        {

        }
        public Human(string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

       
        public void GetHumanData()
        {
            Console.WriteLine($"Person name is: {name}");
            Console.WriteLine($"Person birthdate is: {birthdate}");
        }
    }
}
