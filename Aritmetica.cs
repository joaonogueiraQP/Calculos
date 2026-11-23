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
    internal class Aritmetica
    {
        public int Somar (int x, int y)
        {
            /// <summary>
            /// Operação Soma Inteira
            /// </summary>
            /// <returns> Retorna a Soma de Dois Números Inteiros </returns>
            return x + y;        
        }
        public int Subtrair(int x, int y)
        {
            /// <summary>
            /// Operação Subtração Inteira
            /// </summary>
            /// <returns> Retorna a Subtração de Dois Números Inteiros </returns>
            return x - y;
        }
    }
}
