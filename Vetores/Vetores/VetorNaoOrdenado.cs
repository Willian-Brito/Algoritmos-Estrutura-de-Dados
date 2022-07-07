using System;

namespace Vetores
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
                    Console.WriteLine($"{i} - {this.valores[i]}");
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

        /*
          | 4 | 2 | 1 | 8 | 5 |  |  |
          | 4 | 2 |   | 8 | 5 |  |  |
          | 4 | 2 | 8 |   | 5 |  |  |
          | 4 | 2 | 8 | 5 |   |  |  |
        
        */
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
    }
}