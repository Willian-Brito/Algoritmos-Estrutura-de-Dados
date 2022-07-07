using System;

namespace Fila
{
    public class FilaPrioridade
    {
        #region Propridades da Classe
        public int capacidade { get; set; }
        public int numeroElementos { get; set; }
        public int[] valores { get; set; }
        #endregion

        #region Construtor
        public FilaPrioridade(int capacidade)
        {
            this.capacidade = capacidade;
            this.numeroElementos = 0;
            this.valores = new int[capacidade];
        }
        #endregion

        #region Metodos

        #region Basic

        #region enfileirar
        /* Prioridade: Numeros Menores com Prioridade Maior */
        public void enfileirar(int valor)
        {
            if(this.filaEstaCheia())
            {
                Console.WriteLine("A Fila está Cheia!");
                return;
            }

            if(this.filaEstaVazia())
            {
                this.valores[this.numeroElementos] = valor;
                this.numeroElementos += 1;
            }
            else
            {
                remanejarElementosParaTras(valor);
            }
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

            this.numeroElementos -= 1;
        }
        #endregion

        #region verInicio
        public int verInicio()
        {
            var posicaoInicial = this.numeroElementos -1;

            if (this.filaEstaVazia())
                return -1;
            
            return this.valores[posicaoInicial];
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

        #region Others

        #region filaEstaVazia
        private bool filaEstaVazia()
        {
            return this.numeroElementos == 0;
        }
        #endregion

        #region filaEstaCheia
        private bool filaEstaCheia()
        {
            return this.numeroElementos == this.capacidade;
        }
        #endregion

        #region remanejarElementosParaTras
        private void remanejarElementosParaTras(int valor)
        {            
            var posicaoDeTras = this.numeroElementos - 1;    

            while (posicaoDeTras >= 0)
            {                
                if(valor > this.valores[posicaoDeTras])
                    this.valores[posicaoDeTras + 1] = this.valores[posicaoDeTras];
                else
                    break;
    
                posicaoDeTras -= 1;                
            }

            this.valores[posicaoDeTras + 1] = valor;
            this.numeroElementos += 1;
        }
        #endregion

        #endregion

        #endregion
    }   
}