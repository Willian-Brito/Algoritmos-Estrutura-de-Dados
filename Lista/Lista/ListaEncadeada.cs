using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista
{
    public class ListaEncadeada
    {
        #region Propriedades da Classe
        public No primeiro { get; set; }
        #endregion

        #region Construtor
        public ListaEncadeada()
        {
            this.primeiro = null;
        }
        #endregion

        #region Metodos

        #region Basicos

        public void adicionarInicio(int valor)
        {
            var novo = new No(valor);

            novo.proximo = this.primeiro;
            this.primeiro = novo;
        }

        public void mostrarLista()
        {
            if(this.primeiro == null)
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

        public void removerInicio()
        {
            if(this.primeiro == null)
            {
                Console.WriteLine("A Lista está Vazia!");
                return;
            }

            var temp = this.primeiro;            
            this.primeiro = this.primeiro.proximo;

            // return temp;
        }

        public No pesquisar(int valor)
        {
            if(this.primeiro == null)
                throw new Exception("A Lista está Vazia!");

            var atual = this.primeiro;

            while (atual.valor != valor)
            {
                if(atual.proximo == null)
                    return null;
                else
                    atual = atual.proximo;
            }

            return atual;
        }

        public No removerPosicao(int valor)
        {
            var atual = this.primeiro;
            var anterior = this.primeiro;

            if(this.primeiro == null)
                throw new Exception("A Lista está Vazia!");

            while(atual.valor != valor)
            {
                if(atual.proximo == null)
                    return null;
                else
                {
                    anterior = atual;
                    atual = atual.proximo;
                }
            }

            if (atual == this.primeiro)
                this.primeiro = this.primeiro.proximo;
            else    
                anterior.proximo = atual.proximo;

            return atual;
            
        }
        #endregion

        #region Auxiliares

        #endregion

        #endregion
    }
}