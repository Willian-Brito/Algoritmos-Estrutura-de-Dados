using System.Net;
using System.IO;
using System.Diagnostics.SymbolStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arvore
{
    public class ArvoreBinariaBusca
    {
        #region Propriedades da Classe
        public No raiz { get; set; }
        public List<string> ligacoes { get; set; }
        #endregion

        #region Construtor
        public ArvoreBinariaBusca()
        {
            this.raiz = null;
            this.ligacoes = new List<string>();
        }
        #endregion

        #region Metodos

        #region Basicos

        #region Inserir
        public void Inserir(int valor)
        {
            var novo = new No(valor);

            if(this.raiz == null)
                this.raiz = novo;
            else
            {
                InserirNovoElemento(novo, valor);
            }
        }
        #endregion

        #region Pesquisar
        public No Pesquisar(int valor)
        {
            var atual = this.raiz;

            while(atual.valor != valor)
            {
                if(valor < atual.valor)
                    atual = atual.esquerda;
                else
                    atual = atual.direita;

                if(atual == null)
                    return null;
            }

            return atual;
        }
        #endregion

        #region Percorrer (Imprimir)

        #region Travessia Pré Ordem
        // # raiz, esquerda, direita
        public void TravessiaPreOrdem(No no)
        {
            var NaoForNoFolha = no != null; // # Recursão: Critério de parada

            if(NaoForNoFolha)
            {
                System.Console.WriteLine(no.valor);
                this.TravessiaPreOrdem(no.esquerda); // # Recursão: Mudança de estado a cada chamada
                this.TravessiaPreOrdem(no.direita);  // # Recursão: Mudança de estado a cada chamada
            }
        }
        #endregion

        #region Travessia Em Ordem
        // # esquerda, raiz, direita
        public void TravessiaEmOrdem(No no)
        {
            var NaoForNoFolha = no != null; // # Recursão: Critério de parada

            if(NaoForNoFolha)
            {
                this.TravessiaEmOrdem(no.esquerda); // # Recursão: Mudança de estado a cada chamada
                System.Console.WriteLine(no.valor);
                this.TravessiaEmOrdem(no.direita);  // # Recursão: Mudança de estado a cada chamada
            }
        }
        #endregion

        #region Travessia Pós Ordem
        // # esquerda, direita, raiz,
        public void TravessiaPosOrdem(No no)
        {
            var NaoForNoFolha = no != null; // # Recursão: Critério de parada

            if(NaoForNoFolha)
            {
                this.TravessiaPosOrdem(no.esquerda); // # Recursão: Mudança de estado a cada chamada
                this.TravessiaPosOrdem(no.direita);  // # Recursão: Mudança de estado a cada chamada
                System.Console.WriteLine(no.valor);
            }
        }
        #endregion

        #endregion

        #region Remover
        public void Remover(int valor)
        {
            #region Objetos
            var atual = this.raiz;
            var pai = this.raiz;
            var EhEsquerda = true;
            #endregion

            #region Arvore Vazia
            if(this.raiz == null)
            {
                System.Console.WriteLine("A árvore está vazia");
                return;
            }
            #endregion

            #region Encontrar o Nó
            while (atual.valor != valor)
            {
                pai = atual;

                if(valor < atual.valor)
                {
                    EhEsquerda = true;
                    atual = atual.esquerda;
                }
                else
                {
                    EhEsquerda = false;
                    atual = atual.direita;
                }

                if (atual == null)
                    return;
            }
            #endregion
            
            #region Remover Nó

            // # Nó Folha
            if (atual.esquerda == null && atual.direita == null)
            {
                #region Nó folha
                if(atual == this.raiz)
                {
                    this.raiz = null;
                }
                else if(EhEsquerda)
                {
                    RemoverLigacaoNoFolha(pai, atual);
                    pai.esquerda = null;
                }
                else
                {
                    RemoverLigacaoNoFolha(pai, atual);
                    pai.direita = null;
                }
                #endregion
            }
            //# Nó (1 filho)
            else if(atual.direita == null)
            {
                #region Filho está na Esquerda
                var EhUltimo = atual == this.raiz;
                RemoverLigacaoNoFolha(pai, atual);
                RemoverLigacaoNoEsquerda(atual, atual.esquerda);

                if(EhUltimo)
                {
                    this.raiz = atual.esquerda;
                    AdicionarLigacaoRaizEsquerda(this.raiz, atual.esquerda);
                }       
                else if (EhEsquerda)
                {
                    pai.esquerda = atual.esquerda;
                    AdicionarLigacaoPaiEsquerda(pai, atual.esquerda);
                }
                else
                {
                    pai.direita = atual.esquerda;                
                    AdicionarLigacaoPaiEsquerda(pai, atual.esquerda);
                }
                #endregion
            }
            else if(atual.esquerda == null)
            {
                #region Filho está na Direita
                var EhUltimo = atual == this.raiz;
                RemoverLigacaoNoFolha(pai, atual);
                RemoverLigacaoNoDireita(atual, atual.direita);

                if(EhUltimo)
                {
                    this.raiz = atual.direita;
                    AdicionarLigacaoRaizDireita(this.raiz, atual.direita);
                }
                else if (EhEsquerda)
                {
                    pai.esquerda = atual.direita;
                    AdicionarLigacaoPaiDireita(pai, atual.direita);
                }
                else
                {
                    pai.direita = atual.direita; 
                    AdicionarLigacaoPaiDireita(pai, atual.direita);
                }
                #endregion
            }
            //# Nó (2 filho)
            else
            {
                #region Nó (2 filho)
                var sucessor = GetSucessor(atual);

                RemoverLigacaoPai(pai, atual);
                RemoverLigacaoSucessorDireita(sucessor, atual.direita);
                RemoverLigacaoNoEsquerda(atual, atual.esquerda);
                RemoverLigacaoNoDireita(atual, atual.direita);

                if(atual == this.raiz)
                {
                    AdicionarLigacaoRaizSucessor(this.raiz, sucessor);
                    this.raiz = sucessor;
                }
                else if(EhEsquerda)
                {
                    AdicionarLigacaoPaiSucessor(pai, sucessor);
                    pai.esquerda = sucessor;
                }
                else
                {
                    AdicionarLigacaoPaiSucessor(pai, sucessor);
                    pai.direita = sucessor;
                }

                AdicionarLigacaoSucessorEsquerda(sucessor, atual.esquerda);
                AdicionarLigacaoSucessorDireita(sucessor, atual.direita);
                sucessor.esquerda = atual.esquerda;
                #endregion
            }
            #endregion
        }
        #endregion

        #endregion

        #region Auxiliares

        #region InserirNovoElemento
        private void InserirNovoElemento(No novo, int valor)
        {
            var atual = this.raiz;

            while (true)
            {
                var pai = atual;

                var ForParaEsquerda = valor < atual.valor;
                if(ForParaEsquerda)
                {
                    #region Inserir na Esquerda
                    atual = atual.esquerda;

                    if(atual == null)
                    {
                        pai.esquerda = novo;
                        this.ligacoes.Add($"{pai.valor} -> {novo.valor}");
                        return;
                    }
                    #endregion                    
                }
                else
                {
                    #region Inserir na Direita
                    atual = atual.direita;

                    if(atual == null)
                    {
                        pai.direita = novo;
                        this.ligacoes.Add($"{pai.valor} -> {novo.valor}");
                        return;
                    }
                    #endregion
                }
            }
        }
        #endregion

        #region RemoverLigacao

        #region RemoverLigacaoNoFolha
        private void RemoverLigacaoNoFolha(No pai, No atual)
        {
            this.ligacoes.Remove($"{pai.valor} -> {atual.valor}");
        }
        #endregion

        #region RemoverLigacaoNoEsquerda
        private void RemoverLigacaoNoEsquerda(No atual, No esquerda)
        {
            this.ligacoes.Remove($"{atual.valor} -> {esquerda.valor}");
        }
        #endregion

        #region RemoverLigacaoNoDireita
        private void RemoverLigacaoNoDireita(No atual, No direita)
        {
            this.ligacoes.Remove($"{atual.valor} -> {direita.valor}");
        }
        #endregion

        #region RemoverLigacaoPai
        private void RemoverLigacaoPai(No pai, No atual)
        {
            this.ligacoes.Remove($"{pai.valor} -> {atual.valor}");
        }
        #endregion

        #region RemoverLigacaoSucessorDireita
        private void RemoverLigacaoSucessorDireita(No sucessor, No direita)
        {
            this.ligacoes.Remove($"{direita.valor} -> {sucessor.valor}");
        }
        #endregion

        #endregion

        #region AdicionarLigacao
        
        #region Esquerda

        #region AdicionarLigacaoRaizEsquerda
        private void AdicionarLigacaoRaizEsquerda(No raiz, No esquerda)
        {
            this.ligacoes.Add($"{raiz.valor} -> {esquerda.valor}");
        }
        #endregion

        #region AdicionarLigacaoPaiEsquerda
        private void AdicionarLigacaoPaiEsquerda(No pai, No esquerda)
        {
            this.ligacoes.Add($"{pai.valor} -> {esquerda.valor}");
        }
        #endregion

        #region AdicionarLigacaoSucessorEsquerda
        private void AdicionarLigacaoSucessorEsquerda(No sucessor, No esquerda)
        {
            this.ligacoes.Add($"{sucessor.valor} -> {esquerda.valor}");
        }
        #endregion

        #endregion

        #region Direita

        #region AdicionarLigacaoRaizDireita
        private void AdicionarLigacaoRaizDireita(No raiz, No direita)
        {
            this.ligacoes.Add($"{raiz.valor} -> {direita.valor}");
        }
        #endregion

        #region AdicionarLigacaoPaiDireita
        private void AdicionarLigacaoPaiDireita(No pai, No direita)
        {
            this.ligacoes.Add($"{pai.valor} -> {direita.valor}");
        }
        #endregion

        #region AdicionarLigacaoSucessorDireita
        private void AdicionarLigacaoSucessorDireita(No sucessor, No direita)
        {
            this.ligacoes.Add($"{sucessor.valor} -> {direita.valor}");
        }
        #endregion

        #endregion

        #region AdicionarLigacaoRaizSucessor
        private void AdicionarLigacaoRaizSucessor(No raiz, No sucessor)
        {
            this.ligacoes.Add($"{raiz.valor} -> {sucessor.valor}");
        }
        #endregion

        #region AdicionarLigacaoPaiSucessor
        private void AdicionarLigacaoPaiSucessor(No pai, No sucessor)
        {
            this.ligacoes.Add($"{pai.valor} -> {sucessor.valor}");
        }
        #endregion

        #endregion        

        #region GetSucessor
        private No GetSucessor(No no)
        {
            var paiSucessor = no;
            var sucessor = no;
            var atual = no.direita;

            while(atual != null)
            {
                paiSucessor = sucessor;
                sucessor = atual;
                atual = atual.esquerda;
            }

            if(sucessor != no.direita)
            {
                paiSucessor.esquerda = sucessor.direita;
                sucessor.direita = no.direita;
            }

            return sucessor;
        }
        #endregion

        #endregion

        #endregion
    }
}