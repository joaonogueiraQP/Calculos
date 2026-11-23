using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa Operações Aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        
        public static int Somar (int x, int y)
        {
            /// <summary>
            /// Operação Soma Inteira
            /// </summary>
            /// <returns> Retorna a Soma de Dois Números Inteiros </returns>
            return x + y;        
        }
        public static int Subtrair(int x, int y)
        {
            /// <summary>
            /// Operação Subtração Inteira
            /// </summary>
            /// <returns> Retorna a Subtração de Dois Números Inteiros </returns>
            return x - y;
        }

        public static int Multiplicar(int x, int y)
        {
            /// <summary>
            /// Operação de multiplicação.
            /// </summary>
            /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
            return x * y;
        }



    }
}
