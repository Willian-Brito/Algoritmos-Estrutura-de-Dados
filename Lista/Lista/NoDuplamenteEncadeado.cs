using System;

namespace Lista
{
    public class NoDuplamenteEncadeado
    {
        #region Propriedades da Classe
        public int valor { get; set; }
        public NoDuplamenteEncadeado proximo { get; set; }
        public NoDuplamenteEncadeado anterior { get; set; }
        #endregion

        #region Construtor
        public NoDuplamenteEncadeado(int valor)
        {
            this.valor = valor;
            this.proximo = null;
            this.anterior = null;

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