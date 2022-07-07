using System;
using System.Collections.Generic;
using System.Linq;


namespace Lista
{
    public class No
    {
        #region Propriedades da Classe
        public int valor { get; set; }
        public No proximo { get; set; }
        #endregion

        #region Construtor
        public No(int valor)
        {
            this.valor = valor;
            this.proximo = null;
        }
        #endregion

        #region Metodos

        #region Basicos

        public void mostrarNo()
        {
            Console.WriteLine(this.valor);
        }
        #endregion

        #region Auxiliares
        #endregion

        #endregion
    }
}