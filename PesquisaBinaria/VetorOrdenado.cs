using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaBinaria
{
    public class VetorOrdenado
    {
        #region Propriedades da Classe
        public int capacidade {get; set;}
        public int ultimaPosicao {get; set;}
        public int[] valores {get; set;}
        #endregion

        #region Construtor
        public VetorOrdenado(int capacidade)
        {
            this.capacidade = capacidade;
            this.ultimaPosicao = -1;
            this.valores = new int[capacidade];
        }        
        #endregion


        #region Metodos

        #region inserir
        public void inserir()
        {
            
        }
        #endregion

        #region pesquisaBinaria
        public int pesquisaBinaria(int valor)
        {
            var limiteInferior = 0;
            var limiteSuperior = this.ultimaPosicao;

            while(true)
            {
                var posicaoAtual = (int)(limiteInferior + limiteSuperior) / 2;
                var valorPosicaoAtual = this.valores[posicaoAtual];

                if(limiteInferior > limiteSuperior)
                    return -1;

                if(valorPosicaoAtual == valor)
                    return posicaoAtual;
                else
                {
                    if(valorPosicaoAtual < valor)                
                        limiteInferior = valorPosicaoAtual + 1;
                    else
                        limiteSuperior = valorPosicaoAtual - 1;
                }
            }            
        }
        #endregion

        #endregion
    }
}