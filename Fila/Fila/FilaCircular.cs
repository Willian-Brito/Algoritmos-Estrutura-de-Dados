using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fila
{
    public class FilaCircular
    {
        #region Propriedades da Classe
        public int capacidade { get; set; }
        public int posicaoInicial { get; set; }
        public int posicaoFinal { get; set; }
        public int numeroElementos { get; set; }
        public int[] valores { get; set; }
        #endregion

        #region Construtor
        public FilaCircular(int capacidade)
        {
            this.capacidade = capacidade;
            this.posicaoInicial = 0;
            this.posicaoFinal = -1;
            this.numeroElementos = 0;
            this.valores = new int[capacidade];
        }
        #endregion

        #region Metodos

        #region public

        #region enfilerar
        public void enfilerar(int valor)
        {
            if(this.filaEstaCheia())
            {
                Console.WriteLine("A Fila está Cheia!");
                return;
            }

            var estaNoFinalDaFila = this.posicaoFinal == this.capacidade - 1;

            if(estaNoFinalDaFila)
                this.posicaoFinal = -1;           

            this.incluirValor(valor);
        }
        #endregion

        #region desenfileirar
        public void desenfileirar()
        {
            if(this.filaEstaVazia())
            {
                Console.WriteLine("A Fila está Vazia!");
                return;
            }
                        
            this.posicaoInicial += 1;

            var estaNoFinalDaFila = this.posicaoInicial == this.capacidade - 1;

            if(estaNoFinalDaFila)
                this.posicaoInicial = 0;

            this.numeroElementos -= 1;
        }
        #endregion

        #region verInicio
        public int verInicio()
        {
            if (this.filaEstaVazia())
                return -1;
            
            return this.valores[this.posicaoInicial];
        }
        #endregion

        #region imprimirFila
        public void imprimirFila()
        {
            for (int i = 0; i < this.numeroElementos; i++)
                Console.Write($"[{this.valores[i]}]");
        }
        #endregion

        #endregion

        #region private
        private bool filaEstaVazia()
        {
            return this.numeroElementos == 0;
        }

        private bool filaEstaCheia()
        {
            return this.numeroElementos == this.capacidade;
        }

        private void incluirValor(int valor)
        {
            this.posicaoFinal += 1;
            this.valores[this.posicaoFinal] = valor;
            this.numeroElementos += 1;
        }
        #endregion

        #endregion
    }
}