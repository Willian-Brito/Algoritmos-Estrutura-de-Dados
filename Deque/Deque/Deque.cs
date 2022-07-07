using System;

namespace Deques
{
    public class Deque
    {
        #region Propriedades da Classe
        public int capacidade { get; set; }
        public int posicaoInicial { get; set; }
        public int posicaoFinal { get; set; }
        public int numeroElementos { get; set; }
        public int[] valores { get; set; }
        #endregion

        #region Construtor
        public Deque(int capacidade)
        {
            this.capacidade = capacidade;
            this.posicaoInicial = -1;
            this.posicaoFinal = 0;
            this.numeroElementos = 0;
            this.valores = new int[capacidade];
        }
        #endregion

        #region Metodos

        #region Basicos

        #region adicionarInicio
        // # O(1)
        public void adicionarInicio(int valor)
        {
            if(this.dequeEstaCheio())
            {
                Console.WriteLine("O Deque está Cheio!");
                return;
            }

            atribuirPosicaoInicial();

            this.valores[this.posicaoInicial] = valor;
            this.numeroElementos += 1;
        }
        #endregion

        #region adicionarFinal
        // # O(n)
        public void adicionarFinal(int valor)
        {
            if(this.dequeEstaCheio())
            {
                Console.WriteLine("O Deque está Cheio!");
                return;
            }

            atribuirPosicaoFinal();

            this.valores[this.posicaoFinal] = valor;
            this.numeroElementos += 1;
        }
        #endregion

        #region removerInicio
        // # O(1)
        public void removerInicio()
        {
            if(this.dequeEstaVazio())
            {
                Console.WriteLine("O Deque está Vazio!");
                return;
            }

            var temSomenteUmElemento = this.posicaoInicial == this.posicaoFinal;

            if (temSomenteUmElemento)
            {
                this.posicaoInicial = -1;
                this.posicaoFinal = -1;
            }
            else
            {                
                if(this.posicaoInicial == this.capacidade - 1)
                    this.posicaoInicial = 0;
                else
                    this.posicaoInicial += 1;
            }

            this.numeroElementos -= 1;
        }
        #endregion

        #region removerFinal
        // # O(n)
        public void removerFinal()
        {
            if(this.dequeEstaVazio())
            {
                Console.WriteLine("O Deque está Vazio!");
                return;
            }

            if(this.posicaoInicial == this.posicaoFinal)
            {
                this.posicaoInicial = -1;
                this.posicaoFinal = -1;
            }
            else if (this.posicaoInicial == 0)
            {
                this.posicaoFinal = this.capacidade -1;
            }
            else 
            {
                this.posicaoFinal -= 1;
            }

            this.numeroElementos -= 1;
        }
        #endregion

        #region imprimirDeque
        public void imprimirDeque()
        {
            for (int i = 0; i < this.numeroElementos; i++)
                Console.Write($"[{this.valores[i]}]");
        }
        #endregion

        #endregion

        #region Auxiliares

        #region dequeEstaCheio
        private bool dequeEstaCheio()
        {
            return (this.posicaoInicial == 0 && this.posicaoFinal == this.capacidade -1) || (this.posicaoInicial == this.posicaoFinal + 1) ;
        }
        #endregion

        #region dequeEstaVazio
        private bool dequeEstaVazio()
        {
            var vazio = -1;
            return this.posicaoInicial == vazio;
        }
        #endregion

        #region atribuirPosicaoInicial
        private void atribuirPosicaoInicial()
        {
            if(this.dequeEstaVazio())
            {
               this.posicaoInicial = 0;
               this.posicaoFinal = 0; 
            }
            else if(this.posicaoInicial == 0)
            {
                this.posicaoInicial = this.capacidade -1;
            }
            else
            {
                this.posicaoInicial -= 1;
            }
        }
        #endregion

        #region atribuirPosicaoFinal
        private void atribuirPosicaoFinal()
        {
            if(this.dequeEstaVazio())
            {
               this.posicaoInicial = 0;
               this.posicaoFinal = 0; 
            }
            else if(this.posicaoFinal == this.capacidade - 1)
            {
                this.posicaoFinal = 0;
            }
            else
            {
                this.posicaoFinal += 1;
            }
        }
        #endregion
        
        #region buscarValorInicio
        // # O(1)
        public int buscarValorInicio()
        {
            if(this.dequeEstaVazio())
                throw new Exception("O Deque está Vazio!");

            return this.valores[this.posicaoInicial];
        }
        #endregion

        #region buscarValorFinal
        // # O(1)
        public int buscarValorFinal()
        {
            if(this.dequeEstaVazio() || this.posicaoFinal < 0)
                throw new Exception("O Deque está Vazio!");

            return this.valores[this.posicaoFinal];
        }
        #endregion

        #endregion

        #endregion

    }
}