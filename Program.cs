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
            return $"{id} + {nom} + {mail} + {budget}"; // Chaine Formatée
        }
    }

    class Program
    {
        List<Client> clients = new List<Client>()
        {
            new Client(1, "Patrice", 10000, "patrice@mail.fr"),
            new Client(2, "Robert", 5000, "robert@mail.fr"),
            new Client(3, "Anthony", 20000, "anthony@mail.fr"),
            new Client(4, "Michel", 100500, "michel@mail.fr"),
            new Client(5, "Jean", 15000, "jean@mail.fr"),
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}