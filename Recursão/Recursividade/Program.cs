using System;
using System.Diagnostics;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Recursão

            #region Exemplo 1
            // var loop = 5;

            // System.Console.WriteLine("----- ITERAÇÃO ------");
            // for (int i = 0; i < loop; i++ )
            //     System.Console.WriteLine($"Recursão {i+1}");

            
            // System.Console.WriteLine("");
            // System.Console.WriteLine("----- RECURSÃO ------");
            // recursao(0);
            #endregion

            #region Exemplo 2
            // var tempoExecucaoSemRecursao = new Stopwatch();
            // var tempoExecucaoComRecursao = new Stopwatch();

            // tempoExecucaoSemRecursao.Start();
            // somaSemRecursao(10000);
            // tempoExecucaoSemRecursao.Stop(); 

            // tempoExecucaoComRecursao.Start();
            // somaComRecursao(10000);
            // tempoExecucaoComRecursao.Stop();


            // System.Console.WriteLine($"Soma sem Recursão: {tempoExecucaoSemRecursao.ElapsedTicks * 100} nanosegundos");
            // System.Console.WriteLine($"Soma com Recursão: {tempoExecucaoComRecursao.ElapsedTicks * 100} nanosegundos");
            #endregion

            #region Exercicio 1

            #region Escopo
            /*
                Olá,

                O conteúdo de recursão será utilizado muito a partir do próximo módulo, portanto, é interessante que você 
                tente fazer os seguintes exercícios para praticar.

                O fatorial de um número inteiro m não negativo, é indicado por m! (lê-se "m fatorial") e é definido pela relação:

                m!=m⋅(m−1)⋅(m−2)⋅(m−3)...3⋅2⋅1, para m ≥ 2.

                Algumas definições são:

                - 1! = 1 (fatorial de 1) - critério de parada

                - 0! = 1 (fatorial de 0)

                Exemplos:

                - 3! = 3 . 2 . 1 = 6

                - 4! = 4 . 3 . 2 . 1 = 24

                - 6! = 6 . 5 . 4 . 3 . 2 . 1 = 72
            */
            #endregion

            // System.Console.WriteLine(fatorialSemRecursao(3));
            // System.Console.WriteLine(fatorialComRecursao(5));

            #endregion

            #region Exercicio 2 

            #region Escopo
            /*
                Crie uma função recursiva que calcule o valor de a (base) elevado a b (expoente)

                - Se o expoente for zero, a potência é igual 1 (critério de parada)
                - Não considere exponenciação de números negativos            
            */
            #endregion

            System.Console.WriteLine(potenciaComRecursao(4, 5));
            #endregion

            #endregion
        }

        public static void recursao(int i)
        {
            System.Console.WriteLine($"Recursão {i += 1}");

            if (i == 5) // 1º Regra de fim do ciclo
                return;
            else
                recursao(i); // 2º Regra de mudança de estado da variável de iteração
        }    
    
        public static int somaSemRecursao(int n)
        {
            var soma = 0;

            for(int i = 1; i <= n; i++)
                soma += i;                
            
            return soma;
        }

        public static int somaComRecursao(int n)
        {        
            if(n == 0)
                return 0;          

            return n + somaComRecursao(n - 1);
        }

        public static string somaSemRecursaoTexto(int n)
        {
            var soma = 0;
            var texto = "";

            for(int i = 1; i <= n; i++)
            {
                soma += i;
                texto += i != n ? $"{i} + " : $"{i}";
            }

            return $"{texto} = {soma}";
        }
    
        public static string fatorialSemRecursao(int valor)
        {
            var texto = "";
            var fatorial = 1;

            for (int i = 1; i <= valor; i++)
            {
                texto += i != valor ? $"{i} * " : $"{i}";
                fatorial *= i; 
            }

            return $"{texto} = {fatorial}";
        }

        public static int fatorialComRecursao(int valor)
        {         
            if (valor == 0) 
                return 1;
            
            return valor * fatorialComRecursao(valor - 1);            
        }
    
        public static int potenciaComRecursao(int BASE, int EXPOENTE)
        {

            if (EXPOENTE == 0)
                return 1;

            return BASE * potenciaComRecursao(BASE,  EXPOENTE - 1);
        }
    
    }
}

/*
Um único tique representa cem nanossegundos ou um décimo milionésimo de segundo. 
Há 10.000 tiques em um milissegundo (consulte TicksPerMillisecond ) e 10 milhões tiques em um segundo.
*/
