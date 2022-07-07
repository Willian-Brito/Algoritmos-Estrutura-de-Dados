using System;

namespace Lista
{
    public class ListaEncadeadaExtremidadeDupla
    {
        #region Propriedades da Classe
        public No primeiro { get; set; }
        public No ultimo { get; set; }
        #endregion

        #region Construtor
        public ListaEncadeadaExtremidadeDupla()
        {
            this.primeiro = null;
            this.ultimo = null;

        }
        #endregion

        #region Metodos

        #region Basicos
        public void adicionarInicio(int valor)
        {
            var novo = new No(valor);

            if(VerificarListaVazia())
                this.ultimo = novo;

            novo.proximo = this.primeiro;
            this.primeiro = novo;
        }

        public void adicionarFinal(int valor)
        {
            var novo = new No(valor);

            if(VerificarListaVazia())
                this.primeiro = novo;
            else   
                this.ultimo.proximo = novo;

            // Remaneja o ponteiro da Cabeça da Lista
            this.ultimo = novo; 
        }

        public void removerInicio()
        {
            if(VerificarListaVazia())
            {
                Console.WriteLine("A Lista está Vazia!");
                return;
            }

            var temp = this.primeiro;
            var existirApenasUmElemento = this.primeiro == this.primeiro.proximo;

            if(existirApenasUmElemento)
                this.ultimo = null;

            this.primeiro = this.primeiro.proximo;        
        }

        public void mostrarLista()
        {
            if(VerificarListaVazia())
            {
                Console.WriteLine("A Lista está Vazia!");
                return;
            }

            var atual = this.primeiro;

            while (atual != null)
            {
                atual.mostrarNo();
                atual = atual.proximo;
            }

        }

        #endregion

        #region Auxiliares
        private bool VerificarListaVazia()
        {
            return this.primeiro == null;
        }
        #endregion

        #endregion

    }
}