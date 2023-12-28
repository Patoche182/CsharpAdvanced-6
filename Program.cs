using System;
using System.Linq;

namespace CsharpAdvanced_6
{
    //Class Client
    class Client
    {
        public int id;
        public string nom;
        public int budget;
        public string mail;

        public Client(int i, string n, int b, string m)
        {
            id = i;
            nom = n;
            budget = b;
            mail = m;
        }
        public override string ToString()
        {
            return $"{id} + {nom} + {mail} + {budget}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}