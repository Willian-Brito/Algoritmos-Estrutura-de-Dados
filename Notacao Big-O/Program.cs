using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Notacao_Big_O
{

    public class Program
    {

        public static void Main(string[] args)
        {
            #region Notação Big-O
            /*
                # Notação Big-O

                    * Como comprarar dois algoritmos ?
                    * Comparação objetiva entre algoritmos
                    * Considera diferenças entre poder de processamento, sistema operacional, linguagem de programação.
                    * O quanto a "complexidade" do algoritmo aumenta de acordo com as entradas.
            */

            #region Exercicio 1

            var Exercicio1_TempoDeExecucao1 = new Stopwatch();

            var entrada = 1000000000;

            #region Soma 1 
            Exercicio1_TempoDeExecucao1.Start();
            var result1 = Soma1(entrada);
            Exercicio1_TempoDeExecucao1.Stop();

            PularLinha(1);
            Console.WriteLine("------- SOMA 1 -------");
            Console.WriteLine($"Soma: {result1}");
            Console.WriteLine($"Tempo de Execução: {Exercicio1_TempoDeExecucao1.Elapsed}");
            PularLinha(1);
            #endregion

            #region Soma 2

            var Exercicio1_TempoDeExecução2 = new Stopwatch();

            Exercicio1_TempoDeExecução2.Start();
            var result2 = Soma2(entrada);
            Exercicio1_TempoDeExecução2.Stop();

            PularLinha(1);
            Console.WriteLine("------- SOMA 2 -------");
            Console.WriteLine($"Soma: {result2}");
            Console.WriteLine($"Tempo de Execução: {Exercicio1_TempoDeExecução2.Elapsed}");
            PularLinha(1);
            #endregion

            #endregion

            #region Exercicio 2

            #region Lista 1 

            var Exercicio2_TempoDeExecução1 = new Stopwatch();

            Exercicio2_TempoDeExecução1.Start();
            var lista1 = CreateList_1();
            Exercicio2_TempoDeExecução1.Stop();

            PularLinha(1);
            Console.WriteLine("------- LISTA 1 -------");
            lista1.ForEach(item => Console.Write($"[{item}] "));
            PularLinha(2);
            Console.WriteLine($"Tempo de Execução: {Exercicio2_TempoDeExecução1.Elapsed} | Elementos: {lista1.Count}");
            PularLinha(1);
            #endregion

            #region Lista 2

            var Exercicio2_TempoDeExecução2 = new Stopwatch();

            Exercicio2_TempoDeExecução2.Start();
            var lista2 = CreateList_2();
            Exercicio2_TempoDeExecução2.Stop();

            PularLinha(1);
            Console.WriteLine("------- LISTA 2 -------");
            lista2.ForEach(item => Console.Write($"[{item}] "));

            PularLinha(2);
            Console.WriteLine($"Tempo de Execução: {Exercicio2_TempoDeExecução2.Elapsed} | Elementos: {lista2.Count}");
            PularLinha(2);

            #endregion

            #endregion

            #region Exercicio 3

            int[] lista = { 1, 2, 3, 4, 5 };

            Console.WriteLine("# Constant");
            Constant(lista);

            PularLinha(2);

            Console.WriteLine("# Linear");
            Linear(lista);

            PularLinha(2);

            Console.WriteLine("# Quadradic");
            Quadradic(lista);

            PularLinha(2);

            Console.WriteLine("# Combination");
            Combination(lista);
            #endregion

            #endregion
        }

        #region Exercicio 1

        #region Função 1 - O(n)
        // N Operações
        public static int Soma1(int n)
        {
            int soma = 0;

            for (int i = 0; i <= n; i++)
                soma += i;

            return soma;
        }
        #endregion    

        #region Função 2 - O(3)
        // 3 Operações ( * + / )
        public static int Soma2(int n)
        {
            return (n * (n + 1) / 2);
        }
        #endregion

        #endregion

        #region Exercicio 2 

        #region Função 3 - O(1000)
        public static List<int> CreateList_1()
        {
            List<int> lista = new List<int>();

            foreach (int i in Range(1000))
            {
                lista.Add(i);
            }

            return lista;
        }
        #endregion

        #region Função 4 - O(??)
        public static List<int> CreateList_2()
        {
            return Range(1000);
        }
        #endregion

        #region Range
        public static List<int> Range(int n)
        {
            return Enumerable.Range(1, n).ToList();
        }
        #endregion

        #endregion

        #region Exercicio 3 

        #region Funções Big-O
        /*
            # Funções Big-O

                * 1       - Constant
                * log(n)  - Logarithmic
                * n       - Linear
                * nlog(n) - Log Linear
                * n^2     - Quadradic
                * n^3     - Cubic
                * 2^n     - Exponential
                * n!      - Fatorial

        */

        #region Constant O(1)
        public static void Constant(int[] lista)
        {
            Console.WriteLine(lista[0]);
        }
        #endregion

        #region Linear O(n)
        public static void Linear(int[] lista)
        {
            foreach (int number in lista)
            {
                Console.WriteLine(number);
            }
        }
        #endregion

        #region Quadradic O(n^2)
        public static void Quadradic(int[] lista)
        {
            foreach (int i in lista)
            {
                foreach (int j in lista)
                    Console.WriteLine($"i: {i} | j: {j}");

                Console.WriteLine("---------");
            }
        }
        #endregion

        #region Combination
        public static void Combination(int[] lista)
        {
            Console.WriteLine(lista[0]); // O(1)

            foreach (int i in Range(5)) // O(5)
                Console.WriteLine($"test {i}");


            foreach (int i in lista) // O(n)
                Console.WriteLine(i);

            foreach (int i in lista) // O(n)
                Console.WriteLine(i);

            Console.WriteLine("C#"); // O(1)
            Console.WriteLine("Java"); // O(1)
            Console.WriteLine("Python"); // O(1)

            // Result O(n)
        }
        #endregion

        #endregion

       
        #endregion

        #region PularLinha
        public static void PularLinha(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
                Console.WriteLine("");
        }

        #endregion
    }
}

