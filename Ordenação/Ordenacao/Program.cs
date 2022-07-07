using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Exercicio 1 - Testando as ordenações
            // var vetorNaoOrdenado = new VetorNaoOrdenado(10);

            // vetorNaoOrdenado.inserir(15);
            // vetorNaoOrdenado.inserir(24);
            // vetorNaoOrdenado.inserir(8);
            // vetorNaoOrdenado.inserir(3);

            // vetorNaoOrdenado.inserir(38);
            // vetorNaoOrdenado.inserir(27);
            // vetorNaoOrdenado.inserir(43);
            // vetorNaoOrdenado.inserir(3);
            // vetorNaoOrdenado.inserir(9);
            // vetorNaoOrdenado.inserir(82);
            // vetorNaoOrdenado.inserir(10);

            // vetorNaoOrdenado.inserir(10);
            // vetorNaoOrdenado.inserir(9);
            // vetorNaoOrdenado.inserir(8);
            // vetorNaoOrdenado.inserir(7);
            // vetorNaoOrdenado.inserir(6);
            // vetorNaoOrdenado.inserir(5);
            // vetorNaoOrdenado.inserir(4);
            // vetorNaoOrdenado.inserir(3);

            // System.Console.WriteLine("==== Não Ordenado ====");
            // vetorNaoOrdenado.imprime();

            // System.Console.WriteLine("");

            // System.Console.WriteLine("==== Ordenado ====");
            // vetorNaoOrdenado.BubbleSort();
            // vetorNaoOrdenado.SelectionSort();
            // vetorNaoOrdenado.InsertionSort();
            // vetorNaoOrdenado.ShellSort();
            // vetorNaoOrdenado.QuickSort(0, vetorNaoOrdenado.ultimaPosicao);
            // vetorNaoOrdenado.imprime();

            #region MergeSort
            // var vetorOrdenado = vetorNaoOrdenado.MergeSort(vetorNaoOrdenado.valores);

            // for (int i = 0; i < vetorOrdenado.Length; i++)
            // {
            //     Console.WriteLine($"{i} - {vetorOrdenado[i]}");
            // }   
            #endregion           
            
            #endregion

            #region Exercicio 2 - Medindo a Velocidade dos Algoritmos

            #region Objetos
            var quantidadeElementos = 30000;

            var TempoExecucaoBubbleSort = new Stopwatch();
            var TempoExecucaoSelectionSort = new Stopwatch();
            var TempoExecucaoInsertionSort = new Stopwatch();
            var TempoExecucaoShellSort = new Stopwatch();
            var TempoExecucaoMergeSort = new Stopwatch();
            var TempoExecucaoQuickSort = new Stopwatch();

            var listaElementosParaOrdenacao = gerarListaElementos(quantidadeElementos);
            #endregion

            #region Imprimir Valores da Pesquisa
            // Console.WriteLine("---- Valores da Pesquisa ----");
            // listaElementosParaOrdenacao.ForEach(elemento => Console.Write($"{elemento} | "));
            // pularLinha(5);
            #endregion

            #region Calculo de Tempo de Execução

            #region Tempo de Execução da Ordenação BubbleSort
            // var vetorBubbleSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            TempoExecucaoBubbleSort.Start();
            var vetorBubbleSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            vetorBubbleSort.BubbleSort();
            TempoExecucaoBubbleSort.Stop();
            #endregion

            #region Tempo de Execução da Ordenação SelectionSort
            // var vetorSelectionSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            TempoExecucaoSelectionSort.Start();
            var vetorSelectionSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            vetorSelectionSort.SelectionSort();
            TempoExecucaoSelectionSort.Stop();
            #endregion

            #region Tempo de Execução da Ordenação InsertionSort
            // var vetorInsertionSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            TempoExecucaoInsertionSort.Start();
            var vetorInsertionSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            vetorInsertionSort.InsertionSort();
            TempoExecucaoInsertionSort.Stop();
            #endregion

            #region Tempo de Execução da Ordenação ShellSort
            // var vetorShellSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            TempoExecucaoShellSort.Start();
            var vetorShellSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            vetorShellSort.ShellSort();
            TempoExecucaoShellSort.Stop();
            #endregion

            #region Tempo de Execução da Ordenação MergeSort
            // var vetorMergeSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            TempoExecucaoMergeSort.Start();
            var vetorMergeSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            vetorMergeSort.MergeSort(vetorMergeSort.valores); 
            TempoExecucaoMergeSort.Stop();
            #endregion

            #region Tempo de Execução da Ordenação QuickSort
            // var vetorQuickSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            TempoExecucaoQuickSort.Start();
            var vetorQuickSort = popularVetorNaoOrdenado(listaElementosParaOrdenacao);
            vetorQuickSort.QuickSort(0, vetorQuickSort.ultimaPosicao);
            TempoExecucaoQuickSort.Stop();
            #endregion

            #region Tempo de Execução da Inserção em um vetor ordenado
            var tempoExecucaoVetorOrdenadoInserir = new Stopwatch();
            tempoExecucaoVetorOrdenadoInserir.Start();
            var vetorOrdenado = popularVetorOrdenado(listaElementosParaOrdenacao);
            tempoExecucaoVetorOrdenadoInserir.Stop();
            #endregion

            #endregion
            
            #region Imprimindo Valores

            // Console.WriteLine("---- BubbleSort ----");
            // vetorBubbleSort.imprime();
            // pularLinha(5);

            // Console.WriteLine("---- SelectionSort ----");
            // vetorSelectionSort.imprime();
            // pularLinha(5);

            // Console.WriteLine("---- InsertionSort ----");
            // vetorInsertionSort.imprime();
            // pularLinha(5);

            // Console.WriteLine("---- MergeSort ----");
            // var vetorOrdenado = vetorMergeSort.MergeSort(vetorMergeSort.valores);

            // for (int i = 0; i < vetorOrdenado.Length; i++)
            // {
            //     Console.Write($"[{vetorOrdenado[i]}] ");
            // }
            // pularLinha(5);

            // Console.WriteLine("---- QuickSort ----");
            // vetorQuickSort.imprime();
            // pularLinha(5);

            #endregion

            #region Resultado

            pularLinha(2);
            Console.WriteLine("---- Tempo de Ordenação ----");
            Console.WriteLine($"BubbleSort:    {TempoExecucaoBubbleSort.ElapsedMilliseconds} milissegundoss");
            Console.WriteLine($"SelectionSort: {TempoExecucaoSelectionSort.ElapsedMilliseconds} milissegundos");
            Console.WriteLine($"InsertionSort: {TempoExecucaoInsertionSort.ElapsedMilliseconds} milissegundos");
            Console.WriteLine($"ShellSort:     {TempoExecucaoShellSort.ElapsedMilliseconds} milissegundos");
            Console.WriteLine($"MergeSort:     {TempoExecucaoMergeSort.ElapsedMilliseconds} milissegundos");
            Console.WriteLine($"QuickSort:     {TempoExecucaoQuickSort.ElapsedMilliseconds} milissegundos");
            pularLinha(2);

            Console.WriteLine("---- Tempo Execucao ao Adicionar Elementos em um Vetor Ordenado ----");
            Console.WriteLine($"{tempoExecucaoVetorOrdenadoInserir.ElapsedMilliseconds} milissegundos");
            pularLinha(2);
            //Segundos
            // Console.WriteLine($"BubbleSort:    {(TempoExecucaoBubbleSort.ElapsedMilliseconds / 1000)} segundo(s)");
            // Console.WriteLine($"SelectionSort: {(TempoExecucaoSelectionSort.ElapsedMilliseconds / 1000)} segundo(s)");
            // Console.WriteLine($"InsertionSort: {(TempoExecucaoInsertionSort.ElapsedMilliseconds / 1000)} segundo(s)");
            // Console.WriteLine($"ShellSort:     {(TempoExecucaoShellSort.ElapsedMilliseconds / 1000)} segundo(s)");
            // Console.WriteLine($"MergeSort:     {(TempoExecucaoMergeSort.ElapsedMilliseconds / 1000)} segundo(s)");
            // Console.WriteLine($"QuickSort:     {(TempoExecucaoQuickSort.ElapsedMilliseconds / 1000)} segundo(s)");
            #endregion

            #endregion
        }

        #region Metodos

        #region PopularLista
        static List<int> gerarListaElementos(int quantidadeElementos)
        {
            List<int> elementos = new List<int>();
            Random valoresRandomicos = new Random();

            foreach (var valor in Enumerable.Range(1, quantidadeElementos).ToList())
                elementos.Add(valoresRandomicos.Next(quantidadeElementos));

            return elementos;
        }
        #endregion

        #region popularVetorNaoOrdenado
        static VetorNaoOrdenado popularVetorNaoOrdenado(List<int> listaElementos)
        {
            var vetorNaoOrdenado = new VetorNaoOrdenado(listaElementos.Count);

            listaElementos.ForEach(elemento => vetorNaoOrdenado.inserir(elemento));

            return vetorNaoOrdenado;
        }
        #endregion

        #region popularVetorOrdenado
        static VetorOrdenado popularVetorOrdenado(List<int> listaElementos)
        {
            var vetorOrdenado = new VetorOrdenado(listaElementos.Count);

            listaElementos.ForEach(elemento => vetorOrdenado.inserir(elemento));

            return vetorOrdenado;
        }
        #endregion

        #region Pular Linha
        static void pularLinha(int quantidade)
        {
            if (quantidade <= 0)
            {
                Console.WriteLine("Valor Invalido");
                return;
            }

            for (int i = 1; i < quantidade; i++)
                Console.WriteLine("");
        }
        #endregion

        #endregion
    }
}
