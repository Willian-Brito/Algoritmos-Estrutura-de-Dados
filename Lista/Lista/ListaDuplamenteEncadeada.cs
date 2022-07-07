using System;

namespace Lista
{
    public class ListaDuplamenteEncadeada
    {
        #region Propriedades da Classe
        public NoDuplamenteEncadeado primeiro { get; set; }
        public NoDuplamenteEncadeado ultimo { get; set; }
        #endregion

        #region Construtor
        public ListaDuplamenteEncadeada()
        {
            this.primeiro = null;
            this.ultimo = null;
        }
        #endregion

        #region Metodos
        
        #region Basicos
        
        public void adicionarInicio(int valor)
        {
            var novo = new NoDuplamenteEncadeado(valor);

            if(listaEstaVazia())
                this.ultimo = novo;
            else
                this.primeiro.anterior = novo;

            novo.proximo = this.primeiro;
            this.primeiro = novo;
        }
        public void adicionarFinal(int valor)
        {
            var novo = new NoDuplamenteEncadeado(valor);

            if(listaEstaVazia())
                this.primeiro = novo;
            else
            {
                this.ultimo.proximo = novo;
                novo.anterior = this.ultimo;
            }

            this.ultimo = novo;
        }
        public void removerInicio()
        {
            var EhUltimoElemento = this.primeiro.proximo == null;

            if(EhUltimoElemento)
                this.ultimo = null;
            else
                this.primeiro.proximo.anterior = null;
            
            this.primeiro = this.primeiro.proximo;
        }
        public void removerFinal()
        {
            var EhUltimoElemento = this.primeiro.proximo == null;

            if(EhUltimoElemento)
                this.primeiro = null;
            else
                this.ultimo.anterior.proximo = null;

            this.ultimo = this.ultimo.anterior;
        }
        public void removerPosicao(int valor)
        {
            var atual = this.primeiro;

            while(atual.valor != valor)
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
        public void mostrarListaFrente()
        {
            if(listaEstaVazia())
            {
                Console.WriteLine("A Lista está Vazia!");
                return;
            }

            var atual = this.primeiro;

            while(atual != null)
            {
                atual.mostrarNo();
                atual = atual.proximo;
            }
        }
        public void mostrarListaTras()
        {
            if(listaEstaVazia())
            {
                Console.WriteLine("A Lista está Vazia!");
                return;
            }

            var atual = this.ultimo;

            while(atual != null)
            {
                atual.mostrarNo();
                atual = atual.anterior;
            }
        }
        #endregion

        #region Auxiliares

        private bool listaEstaVazia()
        {
            return this.primeiro == null;
        }
        #endregion
        
        #endregion
    }
}