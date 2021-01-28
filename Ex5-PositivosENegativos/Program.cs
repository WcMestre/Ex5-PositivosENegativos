using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PositivosENegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, positivos=0, negativos=0, contador=1;

            while (contador <= 10)
            {
                Console.WriteLine("Digite um número: ");
                numero1 = int.Parse(Console.ReadLine());

                if (numero1 > 0)
                {
                    positivos++;
                }

                else if (numero1 < 0)
                {
                    negativos++;
                }

               contador++;

            }

            Console.WriteLine(positivos + " Números positivos");
            Console.WriteLine(negativos + " Números negativos");

            Console.ReadKey();


        }
    }
}
