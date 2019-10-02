using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_ska_va_president
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            President p1 = new President(name);
            p1.Present();
            Console.WriteLine(p1.name);

            Console.WriteLine("How much bribe?");
            int bribe = StringToInt(Console.ReadLine());
            p1.PassLegislation(50, 70, 10, bribe);

            string landName = "Sverige";
            Land L1 = new Land(landName);
            L1.CountryInformation();

            Console.ReadLine();

        }

        static public int StringToInt(string b)
        {
            int s;

            while (!int.TryParse(b, out s))
            {
                Console.WriteLine("Skriv in ett korrekt värde: ");
                b = Console.ReadLine();

            }

            return s;

        }
    }
}
