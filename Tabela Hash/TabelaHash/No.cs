using System;

namespace TabelaHash
{
    public class No
    {
        #region Propriedades da Classe
        public string palavra { get; set; }
        public string descricao { get; set; }   
        public No proximo { get; set; }
        public No anterior { get; set; }
        #endregion

        #region Construtor
        public No(string palavra, string descricao)
        {
            this.palavra = palavra;
            this.descricao = descricao;
            this.proximo = null;
            this.anterior = null;
        }
        #endregion

        #region Metodos

        #region MostrarNo
        public void MostrarNo(int index)
        {
            Console.WriteLine($"{index} : {this.palavra} : {this.descricao}");
        }
        #endregion

        #endregion
    }
}