using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFibonacciNet
{
    /// <summary>
    /// Esta clase es la responsable de calcular el número de una secuencia fibonacci
    /// segun una posicion,
    /// </summary>
    class Fibonacci
    {

        /// <summary>
        /// Calcula el numero fibonacci segun una posicion.
        /// </summary>
        /// <param name="numero">posicion del numero fibonacci que se quiere conocer</param>
        /// <returns>número fibonacci en la posicion dada</returns>
        public static int fibonacci(int numero)
        {
            if (numero > 1)
            {
                return fibonacci(numero - 1) + fibonacci(numero - 2);
            }
            else if (numero == 1)
            {
                return 1;
            }
            else if (numero == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
