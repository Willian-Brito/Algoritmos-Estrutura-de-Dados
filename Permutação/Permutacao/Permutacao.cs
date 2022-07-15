using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Permutacao
{
    public class Permutacao
    {
        #region Propriedades da Classe
        public string[] lstPalavras { get; set; }
        public int possibilidades { get; set; }        
        #endregion
        
        #region Construtor
        public Permutacao(string[] lstPalavras)
        {
            this.lstPalavras = lstPalavras;
            this.possibilidades = 1;
        }
        #endregion

        #region Metodos

        #region GerarPermutacao
        public void Gerar()
        {
            var inicio = 0;
            PermutacaoRecursiva(inicio);
        }
        #endregion

        #region PermutacaoRecursiva
        public void PermutacaoRecursiva(int k)
        {
            var capacidade = this.lstPalavras.Count();

            if (k == capacidade)
            {
                Console.Write($"{this.possibilidades++} - ");

                for(int i = 0; i < this.lstPalavras.Length; i++)
                {   
                    var virgula = i == this.lstPalavras.Length - 1 ? "" : ",";
                    Console.Write($"{this.lstPalavras[i]}{virgula} ");
                }

                Console.WriteLine("");
            }
            else
            {
                for (int i = k; i < capacidade; i++)
                {
                    this.lstPalavras = TrocarCaractere(k, i);
                    PermutacaoRecursiva(k + 1);
                    this.lstPalavras = TrocarCaractere(i, k);
                }
            }
        }
        #endregion

        #region TrocarCaractere
        public string[] TrocarCaractere(int p1, int p2)
        {
            var tmp = this.lstPalavras[p1];
            this.lstPalavras[p1] = this.lstPalavras[p2];
            this.lstPalavras[p2] = tmp;
            return this.lstPalavras;
        }
        #endregion

        #endregion
    }
}