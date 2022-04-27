using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Abonnes a1 = new Abonnes("Eliel", 12);
            Abonnes a2 = new Abonnes("El", 10);
            Abonnes a3 = new Abonnes("Elie", 11);
            Abonnes a4 = new Abonnes("Elielle", 9);

            Abonnes[] listesAbonnés = { a1, a2, a3, a4};

            string nomDabonne = Console.ReadLine();

            for(int i = 0; i < listesAbonnés.Length; i++)
            {
                if (nomDabonne.Equals(listesAbonnés[i].nomAbonne))
                {
                    Console.WriteLine("Nom Abonné : " + listesAbonnés[i].nomAbonne + "\n" +
                        "Durée d'abonnement : " + listesAbonnés[i].abonneDureeAbonnement + "\n");
                }
            }

            Console.ReadLine();
        }
    }

    class Abonnes
    {
        public string nomAbonne { get; set; }
        public int abonneDureeAbonnement { get; set; }

        public Abonnes(string nomAbonne, int abonneDuree)
        {
            this.nomAbonne = nomAbonne;
            this.abonneDureeAbonnement = abonneDuree;
        }
    }
}
