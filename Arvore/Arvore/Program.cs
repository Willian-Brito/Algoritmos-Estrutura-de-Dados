using System.Collections.Generic;
using System;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            var arvoreBinariaBusca = new ArvoreBinariaBusca();

            #region Inserir
            arvoreBinariaBusca.Inserir(53);
            arvoreBinariaBusca.Inserir(30);
            arvoreBinariaBusca.Inserir(14);
            arvoreBinariaBusca.Inserir(39);
            arvoreBinariaBusca.Inserir(9);
            arvoreBinariaBusca.Inserir(23);
            arvoreBinariaBusca.Inserir(34);
            arvoreBinariaBusca.Inserir(49);
            arvoreBinariaBusca.Inserir(72);
            arvoreBinariaBusca.Inserir(61);
            arvoreBinariaBusca.Inserir(84);
            arvoreBinariaBusca.Inserir(79);

            // Imprimindo Ligações
            // arvoreBinariaBusca.ligacoes.ForEach(item => 
            // {
            //     System.Console.WriteLine(item);
            //     //http://www.webgraphviz.com/
            // });
            #endregion

            #region Pesquisar
            // var valor = 84;

            // var resultado = arvoreBinariaBusca.Pesquisar(valor) == null 
            //               ? "Não foi possifvel encontrar este valor" 
            //               : arvoreBinariaBusca.Pesquisar(valor).valor.ToString();

            // System.Console.WriteLine(resultado);
            #endregion
        
            #region Travessia
            // arvoreBinariaBusca.TravessiaPreOrdem(arvoreBinariaBusca.raiz);
            // arvoreBinariaBusca.TravessiaEmOrdem(arvoreBinariaBusca.raiz);
            // arvoreBinariaBusca.TravessiaPosOrdem(arvoreBinariaBusca.raiz);
            #endregion
        
        
            #region Excluir

            arvoreBinariaBusca.Remover(72);
            arvoreBinariaBusca.Remover(30);
            // arvoreBinariaBusca.Remover(14);
            // arvoreBinariaBusca.Remover(79);
            // arvoreBinariaBusca.Remover(100);

            // Imprimindo Ligações
            arvoreBinariaBusca.ligacoes.ForEach(item => 
            {
                System.Console.WriteLine(item);
                //http://www.webgraphviz.com/
            });
            #endregion
        }
    }
}

