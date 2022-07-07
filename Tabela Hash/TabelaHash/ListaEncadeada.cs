using System;

namespace TabelaHash
{
    public class ListaEncadeada
    {
        #region Propriedades da Classe
        public No primeiro { get; set; }
        public No ultimo { get; set; }
        #endregion

        #region Construtor
        public ListaEncadeada()
        {
            this.primeiro = null;
            this.ultimo = null;
        }
        #endregion

        #region Metodos
        
        #region Basicos

        #region Buscar
        public No Buscar(string palavra)
        {
            if(this.primeiro == null)
                throw new Exception("A Lista está Vazia!");

            var atual = this.primeiro;

            while (atual.palavra != palavra)
            {
                if(atual.proximo == null)
                    return null;
                else
                    atual = atual.proximo;
            }

            return atual;
        }
        #endregion

        #region AdicionarInicio
        public void AdicionarInicio(string palavra, string descricao)
        {
            var novo = new No(palavra, descricao);

            if(ListaEstaVazia())
                this.ultimo = novo;
            else
                this.primeiro.anterior = novo;

            novo.proximo = this.primeiro;
            this.primeiro = novo;
        }
        #endregion

        #region AdicionarFinal
        public void AdicionarFinal(string palavra, string descricao)
        {
            var novo = new No(palavra, descricao);

            if(ListaEstaVazia())
                this.primeiro = novo;
            else
            {
                this.ultimo.proximo = novo;
                novo.anterior = this.ultimo;
            }

            this.ultimo = novo;
        }
        #endregion

        #region RemoverInicio
        public void RemoverInicio()
        {
            var EhUltimoElemento = this.primeiro.proximo == null;

            if(EhUltimoElemento)
                this.ultimo = null;
            else
                this.primeiro.proximo.anterior = null;
            
            this.primeiro = this.primeiro.proximo;
        }
        #endregion

        #region RemoverFinal
        public void RemoverFinal()
        {
            var EhUltimoElemento = this.primeiro.proximo == null;

            if(EhUltimoElemento)
                this.primeiro = null;
            else
                this.ultimo.anterior.proximo = null;

            this.ultimo = this.ultimo.anterior;
        }
        #endregion

        #region RemoverPosicao
        public void RemoverPosicao(string palavra)
        {
            var atual = this.primeiro;

            while(atual.palavra != palavra)
            {
                atual = atual.proximo;

                if(atual == null)
                    Environment.Exit(0);
            }

            var TemSomenteUmElemento = atual == this.primeiro;

            if(TemSomenteUmElemento)
                this.primeiro = atual.proximo;
            else            
                atual.anterior.proximo = atual.proximo;


            var EhUltimoElemento = atual == this.ultimo;
            
            if(EhUltimoElemento)
                this.ultimo = atual.anterior;
            else
                atual.proximo.anterior = atual.anterior;            
        }
        #endregion

        #region MostrarListaPelaFrente
        public void MostrarListaPelaFrente(int index)
        {
            if(ListaEstaVazia())
                return;

            var atual = this.primeiro;

            while(atual != null)
            {
                atual.MostrarNo(index);
                atual = atual.proximo;
            }
        }
        #endregion

        #region MostrarListaPorTras
        public void MostrarListaPorTras(int index)
        {
            if(ListaEstaVazia())
                return;

            var atual = this.ultimo;

            while(atual != null)
            {
                atual.MostrarNo(index);
                atual = atual.anterior;
            }
        }
        #endregion

        #endregion

        #region Auxiliares

        private bool ListaEstaVazia()
        {
            return this.primeiro == null;
        }
        #endregion
        
        #endregion
    }
}