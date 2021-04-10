using System;

namespace Trabajo_Practico_1
{
    internal class Numero
    {
        private double numero;
        /// <summary>
        /// El constructor por defecto (sin parámetros) asignará valor 0 al atributo numero.
        /// </summary>
        public Numero()
        {
            numero = 0;
        }
        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en
       /// formato double. Caso contrario, retornará 0.
        /// </summary>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            Double.TryParse(strNumero, out retorno);
            return retorno;
        }
        /// <summary>
        /// La propiedad SetNumero asignará un valor al atributo número, previa validación.
        /// </summary>
        public string setNumero
        {
            set
            {
                if (value.GetType() == Type.GetType("System.String"))
                    numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// El método privado EsBinario validará que la cadena de caracteres esté compuesta
        /// SOLAMENTE por caracteres '0' o '1'.
        ///  </summary>
        private bool EsBinario(string cadena)
        {
            bool esBinario = true;

            foreach (char numero in cadena)
            {
                if (numero != '0' || numero != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }
    }
}