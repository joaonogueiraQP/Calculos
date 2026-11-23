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
        public enum ConversaoTemperatura
        {
            Nulo =0,
            CelsiusFahrenheit,
            FahrenheitCelsius;
        }
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

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }

    }
}
