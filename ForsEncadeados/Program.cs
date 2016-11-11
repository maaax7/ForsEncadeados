using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForsEncadeados
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicial = 1;
            string saida = string.Empty;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int result = inicial * j;
                    saida += result + " ";
                }
                inicial++;
                saida += "\n";
            }


            Console.WriteLine(saida);

            Console.ReadKey();
        }
    }
}
