using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
       /// <summary>
        /// Recibe un char y valida si es +,-,/,*.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> simbolo del operador </returns>
       private static char ValidarOperador(char operador)
       {
            if (operador == '-')
            {
                return '-';
            }
            else if (operador == '/')
            {
                return '/';
            }
            else if (operador == '*')
            {
                return '*';
            }
                
            return '+';
       }

       /// <summary>
        /// Realiza la operacion seleccionada entre dos numeros.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns> Resultado de la operacion </returns>
       public static double Operar(Operando numero1, Operando numero2, char operador)
       {
            double resultado = 0;
            
            switch(ValidarOperador(operador))
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '/':
                  resultado = numero1 / numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
            }
            
            return resultado;
       }

    }
}
