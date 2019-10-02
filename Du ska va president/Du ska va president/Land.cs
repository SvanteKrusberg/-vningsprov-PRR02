using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_ska_va_president
{
    class Land
    {
        public string name;
        private int environmentAllyReq;
        private int defenseAllyReq;
        private int healthcareAllyReq;
        private int corruptionMaximum;

        public Land(string n)
        {
            name = n;
            Random generator = new Random();
            environmentAllyReq = generator.Next(1, 101);
            defenseAllyReq = generator.Next(1, 101);
            healthcareAllyReq = generator.Next(1, 101);

        }

        public bool AllyAttempt(int e, int d, int h, int c)
        {
            
            if(e >= environmentAllyReq && d >= defenseAllyReq && h >= healthcareAllyReq && corruptionMaximum < c)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        public void CountryInformation()
        {
            Console.WriteLine("These are the requirements to become allied with " + name + ": ");
            Console.WriteLine("Environment priority: " + environmentAllyReq);
            Console.WriteLine("Defense priority: " + defenseAllyReq);
            Console.WriteLine("Healthcare priority: " + healthcareAllyReq);

        }



    }
}
