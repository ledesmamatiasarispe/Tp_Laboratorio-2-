using System;

namespace Trabajo_Practico_1
{
    internal class Numero
    {
        private double numero;

        public Numero()
        {
            numero = 0;
        }

        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            Double.TryParse(strNumero, out retorno);
            return retorno;
        }

        public string setNumero
        {
            set
            { 
                if(value.GetType() == Type.GetType("System.String"))
                numero = ValidarNumero(value);
            }
        }
    }
}