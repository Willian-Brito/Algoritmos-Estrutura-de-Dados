using System;

namespace Lista
{
    public class PilhaListaEncadeada
    {
        #region Propriedades da Classe
        public No topo { get; set; }
        #endregion

        #region Construtor
        public PilhaListaEncadeada()
        {
            this.topo = null;
        }
        #endregion

        #region Metodos

        #region Basicos

        #region empilhar

        public void empilhar(int valor)
        {
            var novo = new No(valor);

            novo.proximo = this.topo;
            this.topo = novo;
        }
        #endregion

        #region desempilhar
        public void desempilhar()
        {
            if (PilhaEstaVazia())
                Console.WriteLine("A Pilha está Vazia");
            else
                this.topo.valor -= 1;   

            this.topo = this.topo.proximo;
        }
        #endregion

        #region verTopo
        public int verTopo()
        {         
            if(PilhaEstaVazia())
                return -1;

            return this.topo.valor;
        }
        #endregion        

        #endregion

        #region Auxiliares

        private bool PilhaEstaVazia() 
        {
            var pilhaEstaVazia = this.topo == null;
                
            if (pilhaEstaVazia)
                return true;
            else
                return false;
        }
        #endregion

        #endregion
    }
}