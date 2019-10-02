using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_ska_va_president
{
    class President
    {
        public string name;
        private int environmentPrio;
        private int defensePrio;
        private int healthcarePrio;
        private int corruption;
        private int money;

        public President(string n)
        {

            name = n;
            Random generator = new Random();
            environmentPrio = generator.Next(1, 101);
            defensePrio = generator.Next(1, 101);
            healthcarePrio = generator.Next(1, 101);

        }

        public void Present()
        {
            Console.WriteLine("Present: " + name);
            Console.WriteLine("Environment: " + environmentPrio);
            Console.WriteLine("Healthcare: " + healthcarePrio);
            Console.WriteLine("Defense: " + defensePrio);
            Console.WriteLine("Money: " + money);

        }

        public bool PassLegislation (int e, int d, int h, int bribe)
        {
            Random generator = new Random();

            corruption += bribe / 10;
            int environmentReq = generator.Next(1, 101) - bribe;
            int defenseReq = generator.Next(1, 101) - bribe;
            int healthcareReq = generator.Next(1, 101) - bribe;

            if (e >= environmentReq && d >= defenseReq && h >= healthcareReq)
            {
                Console.WriteLine("You pass the legislation!");
                return true;

            }
            else
            {
                Console.WriteLine("You didn't pass the legislation :(");
                return false;

            }
        }

    }
}
