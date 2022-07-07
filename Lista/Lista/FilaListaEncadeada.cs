using System;

namespace Lista
{
    public class FilaListaEncadeada
    {
        #region Propriedades da Classe
        public ListaEncadeadaExtremidadeDupla listaEncadeada { get; set; }
        #endregion

        #region Construtor
        public FilaListaEncadeada()
        {
            listaEncadeada = new ListaEncadeadaExtremidadeDupla();
        }
        #endregion

        #region Metodos
        
        #region Basicos

        public void enfileirar(int valor)
        {
            listaEncadeada.adicionarFinal(valor);
        }

        public void desenfileirar()
        {
            listaEncadeada.removerInicio();
        }

        public int verInicio()
        {
            if(filaEstaVazia())
                return -1;

            return listaEncadeada.primeiro.valor;
        }        
        #endregion

        #region Auxiliares

        private bool filaEstaVazia()
        {
            return listaEncadeada.primeiro == null;
        }
        #endregion

        #endregion
    }
}