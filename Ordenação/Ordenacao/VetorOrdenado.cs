using System;

namespace Ordenacao
{
    public class VetorOrdenado
    {
        #region Propriedades das Classes
        private int capacidade { get; set; }
        private int ultimaPosicao { get; set; }
        private int[] valores { get; set; }

        #endregion

        #region Construtor
        public VetorOrdenado(int capacidade)
        {
            this.capacidade = capacidade;
            this.ultimaPosicao = -1;
            this.valores = new int[capacidade];
        }
        #endregion

        #region Metodos

        #region inserir
        //# O(n)
        public void inserir(int valor)
        {
            #region Verifica se Vetor está Cheio
            var VetorEstaCheio = this.ultimaPosicao == this.capacidade -1;
            if(VetorEstaCheio)
            {
                Console.WriteLine("Capacidade Máxima Atingida");
                return;
            }
            #endregion

            var posicao = 0;

            posicao = econtrarPosicaoEscolhida(valor);

            remanejarDaUltimaPosicaoAteAtual(posicao);
            inserirValor(posicao, valor);            
        }

        private int econtrarPosicaoEscolhida(int valor)
        {
            var posicao = 0;

            for(int i = 0; i <= this.ultimaPosicao + 1; i++)
            {
                posicao = i;
                
                if(this.valores[posicao] > valor)
                    return posicao;                                   
            }

            return posicao;
        }

        private void remanejarDaUltimaPosicaoAteAtual(int posicao)
        {
            var ultimaPosicao = this.ultimaPosicao;

            while (ultimaPosicao >= posicao)
            {
                var posicaoSuperior = ultimaPosicao + 1;
                var valorPosicaoAtual = this.valores[ultimaPosicao];

                this.valores[posicaoSuperior] = valorPosicaoAtual;

                ultimaPosicao -= 1;
            }
        }

        private void inserirValor(int posicao, int valor)
        {
            this.valores[posicao] = valor;
            this.ultimaPosicao += 1;
        }
        #endregion

        #region excluir
        // # O(n)
        public void excluir(int valor)
        {
            var posicao = pesquisaBinaria(valor);

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

        #region imprimir
        // # O(n)
        public void imprimir()
        {
            if(this.ultimaPosicao == -1)
            {
                Console.WriteLine("O Vetor está Vazio!!");
                return ;
            }
            
            for(int i = 0; i <= this.ultimaPosicao; i++)
                Console.WriteLine($"{i} - {this.valores[i]}");
        }
        #endregion

        #region pesquisar

        // # O(n) 
        public int pesquisaLinear(int valor)
        {
            for (int i = 0; i <= this.ultimaPosicao + 1; i++)
            {
                if (this.valores[i] > valor)
                    return -1;

                if (this.valores[i] == valor)
                    return i;
            }

            return -1;
        }

        // # O(log n) 
        public int pesquisaBinaria(int valor)
        {
            int limiteInferior = 0;
            int limiteSuperior = this.ultimaPosicao;

            while(true)
            {
                #region Variaveis Auxiliares

                int posicaoAtual = (int)(limiteInferior + limiteSuperior) / 2;
                int valorPosicaoAtual = this.valores[posicaoAtual];
                #endregion

                var estaNaPosicaoAtual =  valorPosicaoAtual == valor;

                if(estaNaPosicaoAtual)
                    return posicaoAtual;


                var naoEncontrouValor = limiteInferior > limiteSuperior;

                if(naoEncontrouValor)
                    return -1;
                else
                {
                    var valorAtualForMenorQueValorPesquisado = valorPosicaoAtual < valor;

                    if(valorAtualForMenorQueValorPesquisado)
                        limiteInferior = posicaoAtual + 1;
                    else
                        limiteSuperior = posicaoAtual - 1;
                }
                
            }
        }
        #endregion

        #endregion
    }
}
