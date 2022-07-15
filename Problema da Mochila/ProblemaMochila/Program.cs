using System.Diagnostics;
using System;
using CommandLine;

namespace ProblemaMochila
{
 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("[+] Problema da Mochila");
            Console.WriteLine("");

            #region Objetos

            var TempoExecucao = new Stopwatch();
            var capacidade = 5;
            var lstValores = new decimal[] {60,100,120};
            var lstPesos = new int[] {1,2,3};
            var algorithm = eAlgorithm.DYNAMIC_PROGRAM;      
            var solve = 0M; 
            #endregion     
            
            #region Algoritmos

            switch(algorithm)
            {
                #region RECURSIVE

                case eAlgorithm.RECURSIVE: 

                    Console.WriteLine($"Técnica: Divisão e Conquista");

                    TempoExecucao.Start();

                    solve = AlgorithmRecursive(lstValores, lstPesos, capacidade, lstValores.Count());

                    TempoExecucao.Start();

                    Console.WriteLine($"{TempoExecucao.ElapsedMilliseconds} milisegundos");
                    Console.WriteLine($"Solução: {solve}");
                    break;
                #endregion

                #region DYNAMIC_PROGRAM

                case eAlgorithm.DYNAMIC_PROGRAM: 

                    Console.WriteLine($"Técnica: Programação Dinâmica");                    

                    TempoExecucao.Start();

                    solve = AlgorithmDynamycProgram(lstValores, lstPesos, capacidade,lstValores.Count()); 

                    TempoExecucao.Start();

                    Console.WriteLine($"{TempoExecucao.ElapsedMilliseconds} milisegundos");
                    Console.WriteLine($"Solução: {solve}");
                    break;
                #endregion

                #region GENETIC
                case eAlgorithm.GENETIC:
                    break;
                #endregion
            }
            #endregion
        }

        #region Metodos

        #region AlgorithmRecursive
        public static decimal AlgorithmRecursive(decimal[] lstValores, int[] lstPesos, int capacidade, int totalItems)
        {
            if (totalItems == 0)
                return 0;

            var cabeNaMochila = lstPesos[totalItems - 1] > capacidade;

            if (cabeNaMochila)
                return AlgorithmRecursive(lstValores, lstPesos, capacidade, totalItems - 1);
            else
            {
                var valor1 = lstValores[totalItems - 1] + AlgorithmRecursive(lstValores, lstPesos, capacidade - lstPesos[totalItems - 1], totalItems - 1);
                var valor2 = AlgorithmRecursive(lstValores, lstPesos, capacidade, totalItems - 1);

                return MaxValue(valor1, valor2);
            }                    
        }
        #endregion

        #region AlgorithmDynamycProgram
        public static decimal AlgorithmDynamycProgram(decimal[] lstValores, int[] lstPesos, int capacidade, int totalItems)
        {
            
            decimal[,] tabela = new decimal[totalItems + 1, capacidade + 1];

            for(int item = 0; item < totalItems + 1; item++)
            {
                for(int cap = 0; cap < capacidade + 1; cap++)
                {
                    if(item == 0 || cap == 0)
                    {
                        tabela[item, cap] = 0;  
                    }
                    else if (lstPesos[item - 1] <= cap) // Cabe na Mochila
                    {
                        var valor1 = lstValores[item - 1] + tabela[item - 1, cap - lstPesos[item - 1]];
                        var valor2 = tabela[item - 1, cap];

                        tabela[item, cap] = MaxValue(valor1, valor2);
                    }
                    else
                    {
                        tabela[item, cap] = tabela[item - 1, cap];
                    }
                }
            }

            return tabela[totalItems, capacidade];
        }
        #endregion 

        #region MaxValue
        private static decimal MaxValue(decimal valor1, decimal valor2)
        {
            if(valor1 > valor2)
                return valor1;

            if (valor2 > valor1)
                return valor2;

            return valor1;
        }
        #endregion

        #region eAlgorithm

        public enum eAlgorithm {
            RECURSIVE = 1,
            DYNAMIC_PROGRAM = 2,
            GENETIC = 3

        }
        #endregion

        #endregion
    }

}   