using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        
        private Operando()
        {
            numero = 0;
        }

        public Operando(double numero):this() 
        {
            this.numero = numero;
        }

        public Operando(string strNumero) : this()    
        {
            double.TryParse(strNumero, out this.numero);
        }
        
        public double Numero
        {
            get 
            { 
                return numero; 
            }
            
            set 
            {
                numero = ValidarOperando(value.ToString());  
            }
        }

        /// <summary>
        /// Valida el operando
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Valor del operando si se trata de un numero, 0 si no es un numero </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);
            
            return retorno;
        }

        #region MetodosBinariosDecimales.

        /// <summary>
        /// Verifica si el valor pasado es binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> true si es binario, false si no lo es </returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char item in binario)
            {
                if (item != '1' && item != '0')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Convierte el valor de Binario a Decimal.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> string con el numero convertido </returns>
        public string BinarioDecimal(string numero) //para leer datos del form
        {
            int numDecimal = 0;
            int potencia = 1;

            if (EsBinario(numero))
            {
                for (int i = numero.Length - 1; i >= 0; i--)
                {
                    if (numero[i] == '1')
                    {
                        numDecimal += potencia;
                    }
                    potencia *= 2;
                }
                return numDecimal.ToString();
            }

            return "Valor invalido";
        }

        /// <summary>
        /// Convierte el valor de Decimal a Binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> string con el valor convertido </returns>
        public string DecimalBinario(string numero) //para leer datos del form
        {
            string binarioStr = ""; //declaro variable string para armar el numero binario y luego retornarlo
            double numeroDouble;

            if (double.TryParse(numero, out numeroDouble)) //Intento parsear el string a int, si puedo entro al if y convierto. Si el string no es un numero retorno invalido
            {
                binarioStr = DecimalBinario(numeroDouble); //Reutilizo codigo
            }
            else
            {
                binarioStr = "Valor invalido";
            }
            return binarioStr;
        }
        
        /// <summary>
        /// Convierte el valor de Decimal a Binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> string con el valor convertido </returns>
        public string DecimalBinario(double numero) //para hardcodeo
        {
            string binarioStr = ""; //declaro variable string para armar el numero binario y luego retornarlo

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if ((int)numero % 2 == 0) //Casteo a int el double para sacar el modulo
                    {
                        binarioStr = "0" + binarioStr;
                    }
                    else
                    {
                        binarioStr = "1" + binarioStr;
                    }
                    numero = (int)(numero / 2); //Casteo a int para dividir
                }

            }
            else
            {
                if (numero == 0)
                {
                    binarioStr = "0";
                }
                else
                {
                    binarioStr = "Valor invalido";
                }
            }


            return binarioStr;
        }
        #endregion

        #region Sobrecarga de operadores +,-,/,*; Calculos

        /// <summary>
        /// Sobrecarga del operador +.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns> Retorna el resultado de la operacion </returns>
        public static double operator +(Operando numero1, Operando numero2)
        {
            return numero1.Numero + numero2.Numero;
        }

        /// <summary>
        /// Sobrecarga del operador -.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns> Retorna el resultado de la operacion </returns>
        public static double operator -(Operando numero1, Operando numero2)
        {
            return numero1.Numero - numero2.Numero;
        }

        /// <summary>
        /// Sobrecarga del operador /.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns> Retorna el resultado de la operacion </returns>
        public static double operator /(Operando numero1, Operando numero2)
        {
            if (numero2.Numero != 0)
            {
                return numero1.Numero / numero2.Numero;
            }
            return double.MinValue;
        }

        /// <summary>
        /// Sobrecarga del operador *.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns> Retorna el resultado de la operacion </returns>
        public static double operator *(Operando numero1, Operando numero2)
        {
            return numero1.Numero * numero2.Numero;
        }
        #endregion



    }
}
