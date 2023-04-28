using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru4
{
    internal class Program
    {
        static Dictionary<char, int> CharacterSay(string x)
        {
            var charSayaci = new Dictionary<char, int>();

            foreach (char eleman in x)
            {
                if (charSayaci.ContainsKey(eleman))
                {
                    charSayaci[eleman]++;
                }
                else
                {
                    charSayaci.Add(eleman, 1);
                }
            }
            return charSayaci;
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Enter a string: ");
            string a = Console.ReadLine();
            Dictionary<char, int> charCounts = CharacterSay(a);

            foreach (KeyValuePair<char, int> pair in charCounts)
            {
                Console.Write("{0}:{1}, ", pair.Key, pair.Value);
            }

            Console.ReadKey();
        }
    }
}
