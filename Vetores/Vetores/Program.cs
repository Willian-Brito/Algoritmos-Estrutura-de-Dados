using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teste Vetor Não Ordenado

            // var vetorNaoOrdenado = new VetorNaoOrdenado(7);

            // vetorNaoOrdenado.inserir(2);
            // vetorNaoOrdenado.imprime();

            // vetorNaoOrdenado.inserir(3);
            // vetorNaoOrdenado.inserir(5);
            // vetorNaoOrdenado.inserir(8);
            // vetorNaoOrdenado.inserir(1);

            // vetorNaoOrdenado.imprime();

            // vetorNaoOrdenado.pesquisar(8); // Caso Médio
            // vetorNaoOrdenado.pesquisar(9); // Pior Caso
            // vetorNaoOrdenado.pesquisar(3); // Melhor Caso


            // vetorNaoOrdenado.inserir(4);
            // vetorNaoOrdenado.inserir(2);
            // vetorNaoOrdenado.inserir(1);
            // vetorNaoOrdenado.inserir(8);
            // vetorNaoOrdenado.inserir(5);

            // vetorNaoOrdenado.excluir(1);

            // vetorNaoOrdenado.imprime();
            // Console.WriteLine("");
            // vetorNaoOrdenado.excluir(5);

            // vetorNaoOrdenado.imprime();

            // Console.WriteLine("");
            // vetorNaoOrdenado.inserir(5);
            // vetorNaoOrdenado.inserir(1);

            // vetorNaoOrdenado.imprime();
            #endregion

            #region Teste Vetor Ordenado

            // var vetorOrdenado = new VetorOrdenado(10);

            #region Inserir / Excluir

            // vetorOrdenado.inserir(6);
            // vetorOrdenado.inserir(4);
            // vetorOrdenado.inserir(3);
            // vetorOrdenado.inserir(5);
            // vetorOrdenado.inserir(1);
            // vetorOrdenado.inserir(8);
            // vetorOrdenado.imprimir();

            // Console.WriteLine("");
            // vetorOrdenado.excluir(5);

            // vetorOrdenado.imprimir();


            // Console.WriteLine("");
            // vetorOrdenado.excluir(1);

            // vetorOrdenado.imprimir();


            // Console.WriteLine("");
            // vetorOrdenado.excluir(8);

            // vetorOrdenado.imprimir();
            // Console.WriteLine(vetorOrdenado.pesquisar(9));
            #endregion

            #region Pesquisa Binaria

            var capacidade = 100;
            var vetorOrdenadoTeste = new VetorOrdenado(capacidade);

            for(int i = 0; i <= capacidade; i++)
            {
                vetorOrdenadoTeste.inserir(i);
            }

            vetorOrdenadoTeste.pesquisaBinaria(33);

            // vetorOrdenado.inserir(8);
            // vetorOrdenado.inserir(9);
            // vetorOrdenado.inserir(4);
            // vetorOrdenado.inserir(1);
            // vetorOrdenado.inserir(5);
            // vetorOrdenado.inserir(7);
            // vetorOrdenado.inserir(11);
            // vetorOrdenado.inserir(13);
            // vetorOrdenado.inserir(2);

            // vetorOrdenado.imprimir();

            // pularLinha(2);
            // Console.WriteLine(vetorOrdenado.pesquisaBinaria(7));
            // Console.WriteLine(vetorOrdenado.pesquisaBinaria(5));
            // Console.WriteLine(vetorOrdenado.pesquisaBinaria(13));
            // Console.WriteLine(vetorOrdenado.pesquisaBinaria(20));
            #endregion

            #endregion

            #region Teste de Performance entre Vetores (Ordenados Vs Não Ordenados)

            #region Teste (Inserir)  

            pularLinha(1);
            var quantidadeElementos = 10000;

            var tempoExecucaoVetorNaoOrdenadoInserir = new Stopwatch();
            var tempoExecucaoVetorOrdenadoInserir = new Stopwatch();
            var listaElementosParaInsert = gerarListaElementos(quantidadeElementos);

            // # Imprimir Valores do Insert
            // Console.WriteLine("---- Valores do Insert ----");
            // listaElementosParaInsert.ForEach(elemento => Console.Write($"{elemento} | "));
            // pularLinha(5);

            // Tempo de Execução da Inserção em um vetor não ordenado
            tempoExecucaoVetorNaoOrdenadoInserir.Start();
            var vetorNaoOrdenado = popularVetorNaoOrdenado(listaElementosParaInsert);
            tempoExecucaoVetorNaoOrdenadoInserir.Stop();

            // Tempo de Execução da Inserção em um vetor ordenado
            tempoExecucaoVetorOrdenadoInserir.Start();
            var vetorOrdenado = popularVetorOrdenado(listaElementosParaInsert);
            tempoExecucaoVetorOrdenadoInserir.Stop();

            // Resultado
            Console.WriteLine("---- Teste Inserir ----");
            Console.WriteLine($"Vetor Não Ordenado: {tempoExecucaoVetorNaoOrdenadoInserir.Elapsed}");
            Console.WriteLine($"Vetor Ordenado: {tempoExecucaoVetorOrdenadoInserir.Elapsed}");
            pularLinha(2);
            #endregion

            #region Teste (Pesquisar)
            
            var tempoExecucaoVetorNaoOrdenadoPesquisar = new Stopwatch();
            var tempoExecucaoVetorOrdenadoPesquisar = new Stopwatch();
            var listaElementosParaPesquisa = gerarListaElementos(quantidadeElementos);

            // # Imprimir Valores da Pesquisa
            // Console.WriteLine("---- Valores da Pesquisa ----");
            // listaElementosParaPesquisa.ForEach(elemento => Console.Write($"{elemento} | "));
            // pularLinha(5);

            // Tempo de Execução da Pesquisa em um vetor não ordenado
            tempoExecucaoVetorNaoOrdenadoPesquisar.Start();
            listaElementosParaPesquisa.ForEach(elemento => vetorNaoOrdenado.pesquisaLinear(elemento));            
            tempoExecucaoVetorNaoOrdenadoPesquisar.Stop();

            // Tempo de Execução da Pesquisa em um vetor ordenado
            tempoExecucaoVetorOrdenadoPesquisar.Start();
            listaElementosParaPesquisa.ForEach(elemento => vetorOrdenado.pesquisaBinaria(elemento));
            tempoExecucaoVetorOrdenadoPesquisar.Stop();

            // Resultado
            Console.WriteLine("---- Teste Pesquisar ----");
            Console.WriteLine($"Vetor Não Ordenado: {tempoExecucaoVetorNaoOrdenadoPesquisar.Elapsed}");
            Console.WriteLine($"Vetor Ordenado: {tempoExecucaoVetorOrdenadoPesquisar.Elapsed}");
            pularLinha(2);
            #endregion

            #endregion


            #region Metodos

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

            #endregion


        }
    }
}
