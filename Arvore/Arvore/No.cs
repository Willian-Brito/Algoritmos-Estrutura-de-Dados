using System;

namespace Arvore
{
    public class No
    {
        #region Propriedades da Classe
        public int valor { get; set; }
        public No esquerda { get; set; }
        public No direita { get; set; }
        #endregion

        #region Construtor
        public No(int valor)
        {
            this.valor = valor;
            this.esquerda = null;
            this.direita = null;
        }
        #endregion

        #region Metodos

        public void MostrarNo()
        {
            Console.WriteLine(this.valor);
        }
        #endregion
    }
}