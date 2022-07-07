using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;

namespace Ordenacao
{
    public class VetorNaoOrdenado
    {
        #region Propriedades Da Classe
        public int capacidade { get; set; }
        public int ultimaPosicao { get; set; }
        public int[] valores { get; set; }
        #endregion

        #region Construtor
        public VetorNaoOrdenado(int capacidade)
        {
            this.capacidade = capacidade;
            this.ultimaPosicao = -1;
            this.valores = new int[capacidade];
        }
        #endregion

        #region Metodos

        #region Basicos

        #region imprime
        // # O(n)
        public void imprime()
        {
            if (this.ultimaPosicao == -1)
            {
                Console.WriteLine("O Vetor está vazio!");
            }
            else
            {
                for (int i = 0; i < this.ultimaPosicao + 1; i++)
                {
                    Console.Write($"[{this.valores[i]}] ");
                }
            }
        }
        #endregion

        #region inserir
        // # O(1)
        public void inserir(int valor)
        {
            if (this.ultimaPosicao == this.capacidade - 1)
            {
                Console.WriteLine($"Capacidade máxima atingida");
            }
            else
            {
                this.ultimaPosicao += 1;
                this.valores[this.ultimaPosicao] = valor;
            }

        }
        #endregion

        #region pesquisaLinear
        // # O(n)
        public int pesquisaLinear(int valor)
        {
            for (int i = 0; i < this.ultimaPosicao + 1; i++)
            {
                if (valor == this.valores[i])
                    return i;
            }

            return -1;            
        }
        #endregion

        #region excluir
        // # O(n)
        public void excluir(int valor)
        {            
            var posicao = pesquisaLinear(valor);

            if (posicao == -1)
                return;
            else
            {
                for(int i = posicao; i < this.ultimaPosicao; i++ )
                    remanejarDaPosicaoAtualAteUltima(i, i + 1);

                this.ultimaPosicao -= 1;
            }
        }    
        private void remanejarDaPosicaoAtualAteUltima(int posicaoAtual, int posicaoSuperior)
        {
            this.valores[posicaoAtual] = this.valores[posicaoSuperior];
        }    
        #endregion

        #endregion        

        #region Ordenação

        #region 1- BubbleSort O(n^2) 

        #region BubbleSort
        public void BubbleSort()
        {
            for(int i = 0; i < this.ultimaPosicao; i++)
            {
                for(int j = 0; j < this.ultimaPosicao - i; j++)
                {
                    var valorAtual = this.valores[j];
                    var proximoValor = this.valores[j + 1];

                    if(valorAtual > proximoValor)
                        TrocaBubbleSort(i, j);
                }
            }
        }
        #endregion
        
        #region TrocaBubbleSort
                private void TrocaBubbleSort(int i, int  j)
        {
            var temp1 = this.valores[i];
            this.valores[i] = this.valores[j];
            this.valores[j] = temp1;
        }
        #endregion

        #endregion

        #region 2- SelectionSort O(n^2) 

        #region SelectionSort
        public void SelectionSort()
        {
            for(int i = 0; i < this.ultimaPosicao; i++)
            {
                var menorPosicao = i;
                
                for(int j = i + 1; j < this.ultimaPosicao + 1; j++)
                {
                    var menorValor = this.valores[menorPosicao];
                    var valorAtual = this.valores[j];

                    if(menorValor > valorAtual)
                        menorPosicao = j;
                }

                TrocaSelectionSort(i, menorPosicao);
            }
        }
        #endregion
        
        #region TrocaSelectionSort
        private void TrocaSelectionSort(int i, int  menorPosicao)
        {
            var temp = this.valores[i];
            this.valores[i] = this.valores[menorPosicao];
            this.valores[menorPosicao] = temp;
        }
        #endregion
        
        #endregion

        #region 3- InsertionSort O(n^2) 
        public void InsertionSort()
        {
            for(int i = 1; i < this.ultimaPosicao + 1; i++)
            {
                var marcado = this.valores[i];
                var j = i - 1;

                while (j >= 0 && marcado < this.valores[j])
                {
                    this.valores[j + 1] = this.valores[j];
                    j -= 1;
                }

                this.valores[j + 1] = marcado;               
            }
        }
        #endregion

        #region 4- ShellSort O(n^2) 
        public void ShellSort()
        {
            var intervalo = (int)(this.ultimaPosicao + 1) / 2;
 
            while (intervalo > 0)
            {
                for(int i = intervalo; i <= this.ultimaPosicao; i++)
                {
                    var temp = this.valores[i];
                    var j = i;
                    
                    while (j >= intervalo && this.valores[j - intervalo] > temp)
                    {
                        var valorTroca = this.valores[j - intervalo];

                        this.valores[j] = valorTroca;
                        j -= intervalo;
                    }

                    this.valores[j] = temp;                    
                }

                if (intervalo / 2 != 0)
                    intervalo = intervalo / 2; 
                else if (intervalo == 1)
                    intervalo = 0;
                else
                    intervalo = 1;
            }
        }
        #endregion

        #region 5- MergeSort O(n log n) 

        #region MergeSort
        public int[] MergeSort(int[] array)
        {
            int[] esquerda;
            int[] direita;
            int[] result = new int[this.ultimaPosicao];  

            #region Evitando stackoverflow
            if (array.Length <= 1)
                return array;
            #endregion

            #region Atribuindo numero de elementos 
            int meio = array.Length / 2;  
            esquerda = new int[meio];
  
            //se o array tiver um número par de elementos, o array da esquerda e da direita terá o mesmo número de elementos
            if (array.Length % 2 == 0)
                direita = new int[meio];  
            //se o array tiver um número ímpar de elementos, o array da direita terá um elemento a mais que o esquerdo
            else
                direita = new int[meio + 1]; 
            #endregion

            #region Populando array da esquerda
            for (int i = 0; i < meio; i++)
                esquerda[i] = array[i];  
            #endregion

            #region Populando array da esquerda  
            int x = 0;
            for (int i = meio; i < array.Length; i++)
            {
                direita[x] = array[i];
                x++;
            } 
            #endregion 

            #region Ordena o lado direito e esquerdo
            esquerda = MergeSort(esquerda);
            direita = MergeSort(direita);            
            result = Merge(esquerda, direita);  
            #endregion

            return result;
        }
        #endregion

        #region Merge
        //Este método será responsável por combinar nossos dois arrays ordenados em um array gigante
        private int[] Merge(int[] esquerda, int[] direita)
        {
            int resultLength = direita.Length + esquerda.Length;
            int[] result = new int[resultLength];
            int indexEsquerda = 0, indexDireita = 0, indexResult = 0;  

            //enquanto qualquer array ainda tem um elemento
            while (indexEsquerda < esquerda.Length || indexDireita < direita.Length)
            {
                //se ambos os arrays tiverem elementos
                if (indexEsquerda < esquerda.Length && indexDireita < direita.Length)  
                {  
                    //Se o item na array esquerda for menor que o item na array direita, adicione esse item à array de resultados
                    if (esquerda[indexEsquerda] <= direita[indexDireita])
                    {
                        result[indexResult] = esquerda[indexEsquerda];
                        indexEsquerda++;
                        indexResult++;
                    }
                    // caso contrário, o item na array da direita será adicionado à array de resultados
                    else
                    {
                        result[indexResult] = direita[indexDireita];
                        indexDireita++;
                        indexResult++;
                    }
                }
                //se apenas a array esquerda ainda tiver elementos, adicione todos os seus itens à array de resultados
                else if (indexEsquerda < esquerda.Length)
                {
                    result[indexResult] = esquerda[indexEsquerda];
                    indexEsquerda++;
                    indexResult++;
                }
                //se apenas o array da direita ainda tiver elementos, adicione todos os seus itens ao array de resultados
                else if (indexDireita < direita.Length)
                {
                    result[indexResult] = direita[indexDireita];
                    indexDireita++;
                    indexResult++;
                }  
            }

            return result;
        }
        #endregion

        #endregion

        #region 6- QuickSort O(n^2)

        #region QuickSort
        public void QuickSort(int inicio, int fim)
        {
            if(inicio < fim)
            {
                var posicao = Particao(inicio, fim);

                // Esquerda
                QuickSort(inicio, posicao - 1);

                // Direita
                QuickSort(posicao + 1, fim);
            }
        }
        #endregion

        #region Particao
        private int Particao(int inicio, int fim)
        {
            var pivo = this.valores[fim];
            var i = inicio - 1;

            for (int j = inicio; j < fim; j++)
            {
                if (this.valores[j] <= pivo)
                {
                    i += 1;
                    TrocarPosicao(i, j);
                }
            }

            TrocarPivo(i, fim);

            return i + 1;
        }

        #endregion
        
        #region TrocarPosicao
        private void TrocarPosicao(int i, int j)
        {
            var temp = this.valores[i];
            this.valores[i] = this.valores[j];
            this.valores[j] = temp;
        }
        #endregion

        #region TrocarPivo
        private void TrocarPivo(int i, int fim)
        {
            var temp = this.valores[i + 1];
            this.valores[i + 1] = this.valores[fim];
            this.valores[fim] = temp;
        }
        #endregion

        #endregion

        #endregion    
        
        #endregion
    }
}