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
            return $"{id} {nom} {mail} {budget}"; // Chaine Formatée
        }
    }

    class Program
    {
        public static List<Client> clients = new List<Client>()
        {
            new Client(1, "Patrice", 10000, "patrice@mail.fr"),
            new Client(2, "Robert", 5000, "robert@mail.fr"),
            new Client(3, "Anthony", 20000, "anthony@mail.fr"),
            new Client(4, "Michel", 100500, "michel@mail.fr"),
            new Client(5, "Jean", 15000, "jean@mail.fr"),
            new Client(6, "Zoe", 50000, "zoe@mail.fr"),
            new Client(7, "Filler", 50000, "filler@mail.fr"),
        };

        static void Main(string[] args)
        {
            var queryClients = from client in clients
                               where client.budget > 10000
                               orderby client.nom descending
                               select client;
            var queryClientDesc = clients.Where(client => client.budget > 10000).OrderByDescending(client => client.id); // Ajout de la QueryClient mais ça marche bof

            var clientQuery = from client in clients
                              where client.budget > 15000
                              select new
                              {
                                  Nom = client.nom,
                                  Mail = client.mail,
                              };

            var clientLambdaQuery = clients.Where(client => client.budget > 15000);
            Console.WriteLine("----------");
            foreach (Client c in clientLambdaQuery)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("----------");
            Console.WriteLine("----------");

            foreach (var c in queryClientDesc)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("----------");
        }
    }
}