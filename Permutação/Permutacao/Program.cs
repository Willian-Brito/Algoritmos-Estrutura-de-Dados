using System;

namespace Permutacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Permutação é a combinação de todos os elementos com todos elementos

            var lstPalavras = new string[] {"Willian", "Mauricio", "Vandin", "Luis"};
            var Permutacao = new Permutacao(lstPalavras);
            
            Permutacao.Gerar();            
        }
    }
}