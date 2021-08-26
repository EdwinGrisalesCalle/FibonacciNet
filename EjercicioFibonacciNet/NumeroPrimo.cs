using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFibonacciNet
{
    class NumeroPrimo
    {

        public static Boolean esPrimo(int numero)
        {

            if (numero == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }


    }
}
