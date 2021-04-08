namespace entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {


        }

        private static string ValidarOperador(char operador)
        {
            if (operador != '+' || operador != '-' || operador != '*' || operador != '/')
            {
                return "+";
            }
            return operador.ToString();
        }
    }
}