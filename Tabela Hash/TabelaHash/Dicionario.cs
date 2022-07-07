using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabelaHash
{
    public class Dicionario
    {
        #region Propriedades da Classe
        public ListaEncadeada[] Vetor { get; set; }        
        #endregion

        #region Construtor
        public Dicionario()
        {
            this.Vetor = new ListaEncadeada[26];
            InicializaListas();
        }
        #endregion

        #region Metodos

        #region Adicionar
        public void Adicionar(string palavra, string descricao)
        {
            var index = CalcularHash(palavra);
            this.Vetor[index].AdicionarInicio(palavra, descricao);
        }
        #endregion

        #region Remover
        public void Remover(string palavra)
        {
            var index = CalcularHash(palavra);
            this.Vetor[index].RemoverPosicao(palavra);
        }
        #endregion

        #region Buscar
        public No Buscar(string palavra)
        {
            var index = CalcularHash(palavra);
            var No = this.Vetor[index].Buscar(palavra);

            return No;
        }
        #endregion

        #region Imprimir
        public void Imprimir()
        {
            for(int i = 0; i < 26; i++)
            {
                var vetor = this.Vetor[i];

                if(vetor.primeiro != null)
                    this.Vetor[i].MostrarListaPelaFrente(i);                
            }
        }
        #endregion

        #region InicializaListas
        private void InicializaListas()
        {
            for(int i = 0; i < 26; i++)
            {
                this.Vetor[i] = new ListaEncadeada();
            }
        }
        #endregion

        #region CalcularHash
        private int CalcularHash(string palavra)
        {
            var palavraMinuscula = palavra.ToLower();
            var primeiraLetra = palavraMinuscula.Substring(0, 1);
            var posicaoTabelaASCII  = Convert.ToChar(primeiraLetra);

            return posicaoTabelaASCII - 97;
        }
        #endregion

        #endregion
    }
}