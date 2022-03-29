using ClientSOAP.MathOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperationsClient client = new MathOperationsClient();

            // Utilisez la variable 'client' pour appeler des opérations sur le service.

            Console.WriteLine("1 + 2 = {0}",client.Add(1,2));
            Console.WriteLine("4 - 2 = {0}",client.Substract(4,2));
            Console.WriteLine("3 * 3 = {0}",client.Multiply(3,3));

            Console.ReadLine();
            // Fermez toujours le client.
            client.Close();
        }
    }
}
