using System;
using System.Collections.Generic;
using System.Linq;

namespace Pilha
{
    public class Pilha
    {
        #region Propriedades da Classe
        private int capacidade {get; set;}
        private int topo {get; set;}
        private char[] valores {get; set;}
        #endregion
 
        #region Construtor
        public Pilha(int capacidade)
        {
            this.capacidade = capacidade;
            this.topo = -1;
            this.valores = new char[capacidade];
        }
        #endregion

        #region Metodos

        #region empilhar
        public void empilhar(char valor)
        {
            if (pilhaCheia())
                Console.WriteLine("A Pilha está Cheia!");
            else
            {
                this.topo += 1;
                this.valores[this.topo] = valor;
            }
        }

        private bool pilhaCheia()
        {
            var pilhaEstaCheia = this.topo == this.capacidade - 1;

            if(pilhaEstaCheia)
                return true;
            else
                return false;
        }

        private bool pilhaVazia()
        {
            var pilhaEstaVazia = this.topo == -1;

            if (pilhaEstaVazia)
                return true;
            else
                return false;
        }
        #endregion

        #region desempilhar
        public void desempilhar()
        {
            if (pilhaVazia())
                Console.WriteLine("A Pilha está Vazia");
            else
                this.topo -= 1;            
        }
        #endregion

        #region verTopo
        public int verTopo()
        {
            // # 8 : 11
            var vazio = -1;

            if (this.topo != vazio)
                return this.valores[this.topo];
            else
                return vazio;
        }
        #endregion

        #region validarExpressao

        // # a[b{c}d]e}
        public bool validarExpressao(string expressao)
        {
            var _out = false;   
            var RangeDePosicaoDaExpressao = Enumerable.Range(0, expressao.Length).ToList();

            foreach(var posicao in RangeDePosicaoDaExpressao)
            {
                var caracter = expressao[posicao];
                
                empilharCaracter(caracter);

                if(caracterFechamentoEstaInvalido(caracter))
                    return _out;

                if (podeDesempilhar(caracter))
                    desempilharCaracter(caracter);
            }

            if(this.pilhaVazia())
                _out = true;

            return _out;
        }

        private void empilharCaracter(char caracter)
        {
            if(caracter == '[' || caracter == '(' || caracter == '{')
                this.empilhar(caracter);            
        }

        private bool podeDesempilhar(char caracter)
        {
            var _out = false;

            if( (this.verTopo()  == '[' && caracter == ']') || 
                (this.verTopo()  == '(' && caracter == ')') || 
                (this.verTopo()  == '{' && caracter == '}')
              )
            {
                _out = true;
                return _out;
            }                

            return _out;
        }

        private void desempilharCaracter(char caracter)
        {
            if(this.verTopo() == '[' && caracter == ']' || 
               this.verTopo() == '(' && caracter == ')' || 
               this.verTopo() == '{' && caracter == '}')
            {
                this.desempilhar();  
            }
        }

        private bool caracterFechamentoEstaInvalido(char caracter)
        {
            var _out = false;            

            if( (caracter == ')' && this.verTopo() != '(' ) || 
                (caracter == ']' && this.verTopo() != '[' ) || 
                (caracter == '}' && this.verTopo() != '{' )
              )
            {
                _out = true;
                return _out;
            }

            return _out;
        }
        #endregion

        #endregion
    }
}